
using Services.DTOs;
namespace Presentation
{
    public partial class ExamForm : Form
    {
        int currentQuestionIndex = 0;
        List<Question> questionlist = new List<Question>();
        //private int timeLeft = 600;


        public ExamForm()
        {
            InitializeComponent();
            //InitializeTimer();

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

        private void exam_Load(object sender, EventArgs e)
        {
            LoadQuestions();
            if (questionlist.Count > 0)
            {
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("No questions found in the database.");
            }
        }



        private void DisplayQuestion()
        {
            if (questionlist.Count == 0) return;
            var question = questionlist[currentQuestionIndex];
            headsection.Controls.Clear();
            answersection.Controls.Clear();

            Label questionLabel = new Label
            {
                Text = question.Body,
                AutoSize = true,
                Location = new Point(29, 48)
            };

            headsection.Controls.Add(questionLabel);


            int yOffset = 67;
            foreach (var answer in question.AnswerList)
            {
                RadioButton choice = new RadioButton
                {
                    Text = answer,
                    Location = new Point(29, yOffset),
                    AutoSize = true
                };
                answersection.Controls.Add(choice);
                yOffset += 30;
            }
        }


        private void LoadQuestions()
        {
            questionlist.Clear();
            GetStudentExamInputDto dto = new GetStudentExamInputDto(1);
        }

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void kryptonGroup1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public class Question
        {
            public int Id { get; set; }
            public string Body { get; set; }
            public List<string> AnswerList { get; set; }
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
