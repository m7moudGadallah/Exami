
using Entities;
using Services.DTOs;
using Services.Services;
using Presentation.Helpers;
using Presentation.Forms;

namespace Presentation
{
    public partial class StudentMainForm : Form
    {
        private List<Exam> _exams = new List<Exam>();
        private readonly HashSet<int> _loadedExamIds = new HashSet<int>();
        private readonly int studentId = UserSession.LoggedInUser.Id;
        private int selectedExamId;

        private void LoadExams()
        {
            if (UserSession.LoggedInUser == null) return;


            var examsDto = new GetAllStudentExamsInputDto()
            {
                Filters = new Dictionary<string, object>
                {
                    { "StudentId", studentId }
                }
            };
            var studentExams = StudentExamService.GetAllStudentExams(examsDto);

            foreach (var examRecord in studentExams)
            {
                if (_loadedExamIds.Contains(examRecord.ExamId)) continue;

                var exam = ExamService.GetExam(new GetExamInputDto(examRecord.ExamId));
                if (exam != null)
                {
                    _exams.Add(exam);
                    _loadedExamIds.Add(exam.Id);
                }
            }
        }

        private void inqueue_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DateTime today = DateTime.Today;

            List<Exam> upcomingExams = _exams.Where(exam => exam.StartTime > today).ToList();

            if (upcomingExams.Count > 0)
            {
                DisplayExams(upcomingExams);
            }
            else
            {
                MessageBox.Show("No upcoming exams found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DateTime today = DateTime.Today;

            List<Exam> pastExams = _exams.Where(exam => exam.EndTime < today).ToList();

            if (pastExams.Count > 0)
            {
                DisplayExams(pastExams);
            }
            else
            {
                MessageBox.Show("No past exams found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void allexams_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DisplayExams(_exams);
        }

        private void eview_click(object sender, EventArgs e, Exam exam)
        {
            if (exam == null)
            {
                MessageBox.Show("Selected exam not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selectedExamId = exam.Id;  // Store selected exam ID
            var examDto = new GetExamInputDto(selectedExamId);
            var fetchedExam = ExamService.GetExam(examDto);

            if (fetchedExam == null)
            {
                MessageBox.Show("Exam not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure Session is being set
            ExamSession.SetSession(studentId, selectedExamId);
            var examForm = FormsRepo.GetForm<ExamForm>();

            if (examForm == null)
            {
                MessageBox.Show("Error: Exam form could not be retrieved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            examForm.Show();
        }


        //private void LoadExams()
        //{
        //    var dto = new GetAllExamsInputDto(new Dictionary<string, object>());
        //    _exams = ExamService.GetAllExams(dto) ?? new List<Exam>(); // ✅ Prevent null reference issues
        //}

        private void StudentMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread(); // Forcefully exits all running threads
            Environment.Exit(0); // Ensures full shutdown
        }
    }
}
