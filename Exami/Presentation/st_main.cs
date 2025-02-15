using Entities;
using Presentation;
using Services.DTOs;
using MaterialSkin.Controls;
namespace Presentation
{
    public partial class st_main : Form
    {
        public st_main()
        {
            InitializeComponent();
        }

        private void st_main_Load(object sender, EventArgs e)
        {
            loadExams();
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadExams()
        {
            // Load exams from the database
            if (UserSession.LoggedInUser != null)
            {
                var userId = UserSession.LoggedInUser.Id;
                var examsdto = new GetExamInputDto(userId);
                Exam exam = Services.Services.ExamService.GetExam(examsdto);

                if (exam != null)
                {
                    List<Exam> exams = new List<Exam> { exam };
                    displayExams(exams); // Pass the loaded exams to displayExams
                }
                else
                {
                    // Handle the case where no exam is found
                    MessageBox.Show($"No exams found for the user.{exam.Name}");
                }
            }
        }


        private void displayExams(List<Exam> exams)
        {
            // Display exams in the UI
            foreach (var exam in exams)
            {
                var examCard = new MaterialCard();
                examCard.Width = 200;
                examCard.Height = 200;
                examCard.Text = exam.Name;
                examCard.BackColor = Color.White;
                examCard.ForeColor = Color.Black;
                examCard.Font = new Font("Arial", 12, FontStyle.Bold);
                examCard.Margin = new Padding(10);
                examCard.Click += (sender, e) =>
                {
                    // Open the exam form
                    var examForm = new exam();
                    examForm.ShowDialog();
                };
                panel.Controls.Add(examCard);
            }
        }
    }
}
