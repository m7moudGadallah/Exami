using Entities;
using Services.DTOs;
using Services.Services;
using Presentation.Helpers;
using Presentation.Forms;

namespace Presentation
{
    public partial class StudentMainForm : Form
    {
        private List<StudentExam> _stdExams = new List<StudentExam>();
        private readonly int _studentId = UserSession.LoggedInUser.Id;
        private int _selectedExamId;
        readonly StudentExamService _stdExamSerivce = ServicesRepo.GetService<StudentExamService>();

        private void LoadExams()
        {
            if (UserSession.LoggedInUser == null) return;

            var examsDto = new GetAllDto
            {
                Filters = new()
                {
                    ["StudentId"] = _studentId,
                }
            };

            _stdExams = _stdExamSerivce.GetAll(examsDto);
        }



        private void inqueue_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DateTime today = DateTime.Today;

            List<StudentExam> upcomingExams = _stdExams.Where(exam => exam.Exam.StartTime == today).ToList();

            if (upcomingExams.Count > 0)
            {
                DisplayExams(upcomingExams);
            }
            else
            {
                Messages.ShowSnackbarError("No upcoming exams found.");
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DateTime today = DateTime.Today;

            List<StudentExam> pastExams = _stdExams.Where(exam => exam.SubmissionTime < today).ToList();

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

        //private void allexams_btn_Click(object sender, EventArgs e)
        //{
        //    panel2.Controls.Clear();
        //    DisplayExams(_exams);
        //}

        private void eview_click(object sender, EventArgs e, Exam exam)
        {
            if (exam == null)
            {
                Messages.ShowSnackbarError("Selected exam not found.");
                return;
            }

            _selectedExamId = exam.Id;

            // Ensure Session is being set
            ExamSession.SetSession(_studentId, _selectedExamId);
            var examForm = FormsRepo.GetForm<ExamForm>();

            if (examForm == null)
            {
                Messages.ShowSnackbarError("Error: Exam form could not be retrieved.");
                return;
            }

            examForm.Show();
        }

        //private void LoadExams()
        //{
        //    var dto = new GetAllExamsInputDto(new Dictionary<string, object>());
        //    _exams = ExamService.GetAllExams(dto) ?? new List<Exam>(); 
        //}

        private void StudentMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread(); // Forcefully exits all running threads
            Environment.Exit(0); // Ensures full shutdown
        }

        private void StudentMainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
