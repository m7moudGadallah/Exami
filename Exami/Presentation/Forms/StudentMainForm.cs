
using Entities;
using Services.DTOs;
using Services.Services;
using Presentation.Helpers;

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

        private void eview_click(object sender, EventArgs e)
        {
            if (selectedExamId == null)
            {
                MessageBox.Show("Selected exam not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //var examdto = new GetExamInputDto(selectedExamId);
            //var exam = ExamService.GetExam(examdto);
            //ExamSession.SetSession(studentId, selectedExamId);
            //MessageBox.Show($"Session started for {studentId} on exam {exam.Name}.");
            //Form examForm = Exam(exam);
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
