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

namespace Presentation
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DisplayQuestion();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        //private void DisplayQuestion()
        //{
        //    groupBox1.Controls.Clear();
        //    List<Question> questions = LoadQuestions();
        //    Label lblQuestion = new Label();
        //    lblQuestion.Text = questions[0].Body;
        //    lblQuestion.AutoSize = true;
        //    lblQuestion.Location = new Point(10, 10);
        //    groupBox1.Controls.Add(lblQuestion);


        //}

        private List<Question> LoadQuestions()
        {
            List<Question> questionlist = new List<Question>();
            string connectionString = "Data Source=HEBA\\sqlEXPRESS;Initial Catalog=Exami;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT Id, Body, QuestionType FROM Question";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                questionlist.Add(new Question
                {
                    Id = reader.GetInt32(0),
                    Body = reader.GetString(1),
                    QuestionType = reader.GetString(2)
                });

            }
            return questionlist;
            connection.Close();
        }

        public class Question
        {
            public int Id { get; set; }
            public string Body { get; set; }
            public string QuestionType { get; set; }
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
