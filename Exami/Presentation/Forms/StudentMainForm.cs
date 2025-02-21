using Entities;
using Presentation.Forms;
using Presentation.Helpers;
using Services.DTOs;
using Services.Services;

namespace Presentation
{
    internal partial class StudentMainForm : Form
    {

         static List<StudentExam> _exams = new List<StudentExam>();
         readonly int studentId = UserSession.LoggedInUser.Id;
         int selectedExamId;

        private void LoadExams()
        {
            if (UserSession.LoggedInUser == null) return;

            var examsDto = new GetAllStudentExamsInputDto()
            {
                Filters = new Dictionary<string, object>
                {
                    {"StudentId", studentId }
                }
            };

            var studentExams = StudentExamService.GetAllStudentExams(examsDto);
            _exams = studentExams.Select(se => new StudentExam
            (
                se.Id,
                se.ExamId,
                se.StudentId,
                se.SubmissionTime,
                se.CreatedAt,
                se.UpdatedAt,
                se.Student,
                se.Exam
            )).ToList();
        }

        private void inqueue_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DateTime today = DateTime.Today;

            List<StudentExam> upcomingExams = _exams.Where(exam => exam.Exam.StartTime == today).ToList();

            if (upcomingExams.Count > 0)
            {
                DisplayExams(upcomingExams);
            }
            else
            {
                Messages.ShowSnackbarNotification("No upcoming exams found.");
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DateTime today = DateTime.Today;

            List<StudentExam> pastExams = _exams.Where(exam => exam.SubmissionTime < today).ToList();

            if (pastExams.Count > 0)
            {
                DisplayExams(pastExams);
                //eview.hide();
            }
            else
            {
                Messages.ShowSnackbarError("No past exams found.");
            }
        }

        private void eview_click(object sender, EventArgs e, Exam exam)
        {
            if (exam == null)
            {
                Messages.ShowSnackbarError("Selected exam not found.");
                return;
            }

            selectedExamId = exam.Id;

            var examsDto = new GetAllExamsInputDto()
            {
                Filters = new Dictionary<string, object>
                {
                    { "Id", selectedExamId }
                }
            };

            var fetchedExam = ExamService.GetAllExams(examsDto) ?? new List<Exam>();
            if (fetchedExam == null)
            {
                Messages.ShowSnackbarError("Exam not found in database.");
                return;
            }

            var insForm = new Instruction(exam);
            insForm.Show();
        }

        private void StudentMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread(); // Forcefully exits all running threads
            Environment.Exit(0); // Ensures full shutdown
        }
    }
}
