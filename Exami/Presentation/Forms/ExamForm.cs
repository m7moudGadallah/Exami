
using Presentation.Helpers;
using Entities;
using Services.DTOs;
using Services.Services;
using System.Drawing.Drawing2D;
using Presentation.Forms;
using MaterialSkin.Controls;
namespace Presentation
{
    public partial class ExamForm : Form
    {
        private readonly int examId = ExamSession.SelectedExam;
        private readonly int StudentExamId = ExamSession.LoggedInUser;
        List<Question> questionlist = new List<Question>();
        int currentQuestionIndex = 0;
        public ExamForm(Exam exam)
        {
            InitializeComponent();
            sd_name.Text = $"{UserSession.LoggedInUser.FirstName} {UserSession.LoggedInUser.LastName}";
            InitializeTimer();
        }
        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadExam();
            CreateFlagButtons();
            DisplayQuestion();
        }

        //load all exam questions yastaaaa
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

            // Debugging: Check how many questions are returned from the service
            //MessageBox.Show($"Questions fetched: {questionsFromService.Count}");

            if (questionsFromService.Count == 0)
            {
                MessageBox.Show("No questions were retrieved. Check if examId is correct.");
                return;
            }

            questionlist = questionsFromService.Select(q => new Question(
                q.Id,
                q.Marks,
                q.Body,
                q.QuestionType,
                q.SubjectId
            )).ToList();

            // Debugging: Check how many questions are in questionlist after conversion
            //MessageBox.Show($"Questions in list after conversion: {questionlist.Count}");

            foreach (var question in questionlist)
            {
                var answersFromService = AnswerService.GetAllAnswers(new GetAllAnswersInputDto(new Dictionary<string, object>
        {
            { "QuestionId", question.Id }
        }));

                question.Answers = answersFromService.ToList();

                // Debugging: Check how many answers were loaded for each question
                //MessageBox.Show($"Question {question.Id}: '{question.Body}' has {question.Answers.Count} answers.");
            }
        }
        private void DisplayQuestion()
        {
            if (questionlist == null || questionlist.Count == 0) return;

            var question = questionlist[currentQuestionIndex];

            qhead.Controls.Clear();
            qbody.Controls.Clear();

            Label qh = new Label
            {
                AutoSize = true,
                Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = SystemColors.ActiveCaptionText,
                Location = new Point(12, 57),
                Name = "qh",
                Text = question.Body,
                TextAlign = ContentAlignment.MiddleCenter
            };
            qhead.Controls.Add(qh);

            int yOffset = 60;
            int tabIndex = 1;

            foreach (var answer in question.Answers)
            {
                RadioButton choice = new RadioButton
                {
                    AutoSize = true,
                    Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = SystemColors.ActiveCaptionText,
                    Location = new Point(14, yOffset),
                    Name = "choice_" + yOffset,
                    Text = answer.AnswerText,
                    UseVisualStyleBackColor = true,
                    TabIndex = tabIndex++
                };

                choice.CheckedChanged += (s, e) => UpdateFlagColors(); // Update button when answer changes

                qbody.Controls.Add(choice);
                yOffset += 40;
            }

            UpdateFlagColors();
            if (currentQuestionIndex == questionlist.Count - 1)
            {
                nxt_btn.Hide();
            }
            if (currentQuestionIndex == 0)
            {
                pre_btn.Hide();
            }
        }
        private bool IsAnswerSelected()
        {
            return qbody.Controls.OfType<RadioButton>().Any(rb => rb.Checked);
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
        private void nxt_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Moving to question {currentQuestionIndex + 1} of {questionlist.Count}"); // Debugging

            if (currentQuestionIndex < questionlist.Count - 1)
            {
                if (!IsAnswerSelected())
                {
                    MessageBox.Show("Please select an answer before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                currentQuestionIndex++;
                DisplayQuestion();
                MessageBox.Show($"Moving to question {currentQuestionIndex + 1} of {questionlist.Count}"); // Debugging

            }
        }
        private void pre_btn_Click(object sender, EventArgs e)
        {

            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestion();
            }
        }
        private void CreateFlagButtons()
        {
            qnav.Controls.Clear();
            int buttonSize = 30;
            int spacing = 20;
            int xOffset = 108;
            int yOffset = 59;
            int x0 = 25;
            int y0 = 60;
            for (int i = 0; i < questionlist.Count; i++)
            {
                Button flagButton = new Button
                {
                    Size = new Size(buttonSize, buttonSize),
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    BackColor = Color.Red,
                    Name = "flag_" + i,
                    Tag = i,
                    Text = "",
                    Location = new Point(xOffset, yOffset)
                };

                int labelsize = 29;
                Label qnumber = new Label
                {
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    BackColor = Color.Transparent,
                    Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    ForeColor = SystemColors.ActiveCaptionText,
                    Location = new Point(x0, y0),
                    Tag = i,
                    Name = "qnumber_" + i,
                    Size = new Size(43, 29),
                    TabIndex = 51,
                    Text = $"Q{i + 1}",
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, flagButton.Width, flagButton.Height);
                flagButton.Region = new Region(path);
                flagButton.Click += FlagButton_Click;
                qnav.Controls.Add(flagButton);
                qnav.Controls.Add(qnumber);
                y0 += labelsize + spacing;
                yOffset += buttonSize + spacing;
            }
        }
        internal void submit_btn_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> userResponses = new Dictionary<int, string>(); 

            for (int i = 0; i < questionlist.Count; i++)
            {
                var selectedAnswer = qbody.Controls
                    .OfType<RadioButton>()
                    .FirstOrDefault(rb => rb.Checked);

                if (selectedAnswer != null)
                {
                    userResponses[questionlist[i].Id] = selectedAnswer.Text;
                }
            }

            if (userResponses.Count < questionlist.Count)
            {
                Messages.ShowSnackbarError("Please answer all questions before submitting.");
                return;
            }

            SaveResponses(userResponses);
            Messages.ShowSnackbarNotification("Exam submitted successfully!");
            var studentForm = FormsRepo.GetForm<StudentMainForm>();
            studentForm.Show();
            this.Close();
        }
        //FIX it please ya ma7moud
        internal void SaveResponses(Dictionary<int, string> responses)
        {
            foreach (var response in responses)
            {
                var studentanswerdto = new CreateStudentAnswerInputDto(StudentExamId, response.Key);

                try
                {
                    var studentanswer = StudentAnswerService.CreateStudentAnswer(studentanswerdto);
                }
                catch (Utilities.Exceptoins.AppException ex)
                {
                    if (ex.Message.Contains("Cannot insert duplicate key"))
                    {
                        Messages.ShowSnackbarError($"Duplicate answer detected for Question ID: {response.Key}. Please review your answers.");
                        return;
                    }
                    else if (ex.Message.Contains("The given key 'StudentExamId' was not present in the dictionary"))
                    {
                        Messages.ShowSnackbarError($"The key 'StudentExamId' was not found for Question ID: {response.Key}.");
                        return;
                    }
                    else if (ex.Message.Contains("The INSERT statement conflicted with the FOREIGN KEY constraint"))
                    {
                        Messages.ShowSnackbarError($"Foreign key constraint violation for Question ID: {response.Key}. Please ensure the StudentExamId is valid.");
                        return;
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
        private void FlagButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button flagButton)
            {
                int? questionIndex = flagButton.Tag as int?;
                if (questionIndex.HasValue)
                {
                    flagButton.BackColor = flagButton.BackColor == Color.Red ? Color.Orange : Color.Red; // Toggle flag status
                }
            }
        }
        private void UpdateFlagColors()
        {
            foreach (Control ctrl in qnav.Controls)
            {
                if (ctrl is Button flagButton)
                {
                    int? questionIndex = flagButton.Tag as int?;
                    if (questionIndex.HasValue)
                    {
                        bool isAnswered = qbody.Controls.OfType<RadioButton>().Any(rb => rb.Checked);
                        flagButton.BackColor = isAnswered ? Color.Green : Color.Red; // Green if answered, Red if not
                    }
                }
            }
        }

    }
}
