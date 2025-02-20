
using Presentation.Helpers;
using Entities;
using Services.DTOs;
using Services.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
namespace Presentation
{
    public partial class ExamForm : Form
    {
        private readonly int studentId = UserSession.LoggedInUser.Id;
        private readonly int examId = ExamSession.SelectedExam;
        int currentQuestionIndex = 0;
        List<Question> questionlist = new List<Question>();
        List<string> answerlist = new List<string>();
        //private int timeLeft = 600;


        public ExamForm()
        {
            //this.Load += new EventHandler(ExamForm_Load);
            //sd_name.Text = $"{UserSession.LoggedInUser.FirstName} {UserSession.LoggedInUser.LastName}";

            InitializeComponent();
            //InitializeTimer();

        }
        public void LoadExam()
        {
            var examDto = new GetAllQuestionInputDto
            {
                Filters = new Dictionary<string, object>
    {
        { "StudentId", studentId },
        { "ExamId", examId }
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
        }

        private void DisplayQuestion()
        {
            if (questionlist == null || questionlist.Count == 0) return;

            var question = questionlist[currentQuestionIndex];
            qbody.Controls.Clear();

            Label qh = new Label
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = SystemColors.ActiveCaptionText,
                Location = new Point(12, 20),
                Name = "qh",
                Size = new Size(106, 29),
                TabIndex = 50,
                Text = question.Body,
                TextAlign = ContentAlignment.MiddleCenter
            };
            qbody.Controls.Add(qh);

            int yOffset = 60;

            foreach (var answer in answerlist)
            {
                RadioButton choice = new RadioButton
                {
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    BackColor = Color.Transparent,
                    Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = SystemColors.ActiveCaptionText,
                    AutoSize = true,
                    Location = new Point(14, yOffset),
                    Name = "choice_" + yOffset,
                    Size = new Size(128, 27),
                    TabIndex = 50,
                    TabStop = true,
                    Text = answer,
                    UseVisualStyleBackColor = true
                };
                qbody.Controls.Add(choice);
                yOffset += 40;
            }
        }

























        //private void InitializeTimer()
        //{

        //    timer.Interval = 1000;
        //    timer.Tick += Timer_Tick;
        //    timer.Start();
        //}

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    if (timeLeft > 0)
        //    {
        //        timeLeft--;
        //        int minutes = timeLeft / 60;
        //        int seconds = timeLeft % 60;
        //        timerbtn.Text = $"Time Left: {minutes:D2}:{seconds:D2}";
        //    }
        //    else
        //    {
        //        timer.Stop();
        //        MessageBox.Show("Time is up! The exam will be submitted.");

        //    }
        //}



        private void nxt_btn_Click(object sender, EventArgs e)
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
