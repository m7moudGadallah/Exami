using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Presentation
{
    public partial class exam : Form
    {
        int currentQuestionIndex = 0;
        List<Question> questionlist = new List<Question>();
        private int timeLeft = 600;


        public exam()
        {
            InitializeComponent();
            InitializeTimer();

        }
        private void InitializeTimer()
        {
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                int minutes = timeLeft / 60;
                int seconds = timeLeft % 60;
                timerbtn.Text = $"Time Left: {minutes:D2}:{seconds:D2}";
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Time is up! The exam will be submitted.");
               
            }
        }

        private void exam_Load(object sender, EventArgs e)
        {
            LoadQuestions();  // Load all questions once
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
                Location = new Point(29, 48) // Adjust position inside headsection
            };

            headsection.Controls.Add(questionLabel); // Add the question label to headsection


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
            questionlist.Clear(); // Prevent duplication on reload

            string connectionString = "Data Source=HEBA\\sqlEXPRESS;Initial Catalog=Exami;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT Question.Id, Question.Body, Answer.AnswerText 
                    FROM Question
                    JOIN Answer ON Answer.QuestionId = Question.Id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Dictionary<int, Question> questionMap = new Dictionary<int, Question>();

                while (reader.Read())
                {
                    int questionId = reader.GetInt32(0);
                    string questionBody = reader.GetString(1);
                    string answerText = reader.GetString(2);

                    if (!questionMap.ContainsKey(questionId))
                    {
                        questionMap[questionId] = new Question
                        {
                            Id = questionId,
                            Body = questionBody,
                            AnswerList = new List<string>()
                        };
                    }

                    questionMap[questionId].AnswerList.Add(answerText);
                }

                questionlist = new List<Question>(questionMap.Values);
            }


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
