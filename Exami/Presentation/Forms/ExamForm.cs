
using Presentation.Helpers;
using Entities;
using Services.DTOs;
using Services.Services;
namespace Presentation
{
    public partial class ExamForm : Form
    {
        private readonly int examId = ExamSession.SelectedExam;
        List<Question> questionlist = new List<Question>();
        int currentQuestionIndex = 0;



        public ExamForm()
        {
            InitializeComponent();
            sd_name.Text = $"{UserSession.LoggedInUser.FirstName} {UserSession.LoggedInUser.LastName}";
            InitializeTimer();
        }
        public void LoadExam()
        {
            var examDto = new GetAllQuestionInputDto
            {
                Filters = new Dictionary<string, object>
    {
        { "Id", examId }
    }
            };


            var questionsFromService = QuestionService.GetAllQuestions(examDto);


            questionlist = questionsFromService.Select(q => new Question(
             q.Id,
             q.Marks,
             q.Body,
             q.QuestionType,
             q.SubjectId
            )).ToList();


            foreach (var question in questionlist)
            {
                var answersFromService = AnswerService.GetAllAnswers(new GetAllAnswersInputDto(new Dictionary<string, object>
            {
                { "QuestionId", question.Id }
            }));
                question.Answers = answersFromService.ToList();
            }

            var q = questionlist[currentQuestionIndex];


        }


        private void InitializeTimer()
        {

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            var exam = ExamService.GetAllExams(new GetAllExamsInputDto
            {
                Filters = new Dictionary<string, object>
        {
            { "Id", examId }
        }
            }).FirstOrDefault();

            if (exam == null)
            {
                timer.Stop();
                MessageBox.Show("Exam not found.");
                return;
            }

            var duration = exam.EndTime - exam.StartTime;

            var timeElapsed = DateTime.Now - exam.StartTime;
            var timeLeft = duration - timeElapsed;

            if (timeLeft.TotalSeconds > 0)
            {
                int minutes = timeLeft.Minutes;
                int seconds = timeLeft.Seconds;
                timer_label.Text = $"{minutes:D2}:{seconds:D2}";
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Time is up! The exam will be submitted.");
            }
        }


        private void next_btn_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < questionlist.Count - 1)
            {
                currentQuestionIndex++;
                DisplayQuestion();
            }

        }


        private void prev_btn_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestion();
            }
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadExam();
            DisplayQuestion();
        }

    }
}
