using Presentation.Helpers;
using Entities;
using Services.Services;
using System.Drawing.Drawing2D;
using Presentation.Forms;
using Services.DTOs;
namespace Presentation
{
    public partial class ExamForm : Form
    {
        public ExamForm()
        {
            InitializeComponent();
            sd_name.Text = $"{UserSession.LoggedInUser.FirstName} {UserSession.LoggedInUser.LastName}";
            InitializeTimer();
        }

        readonly ExamQuestionService _examQuestionService = ServicesRepo.GetService<ExamQuestionService>();
        readonly StudentExamService _stdExamService = ServicesRepo.GetService<StudentExamService>();
        readonly StudentAnswerService _stdAnswerService = ServicesRepo.GetService<StudentAnswerService>();
        readonly int _examId = ExamSession.SelectedExam;
        StudentExam _stdExam;
        List<Question> _questionlist = new();
        int _currentQuestionIndex = 0;

        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadExam();
            CreateFlagButtons();
            DisplayQuestion();
        }


        public void LoadExam()
        {
            var getExamdto = new GetAllDto
            {
                Filters = new()
                {
                    ["Id"] = _examId,
                }
            };

            _stdExam = _stdExamService.GetAll(getExamdto).FirstOrDefault();


            var getExamQuestions = new GetAllDto
            {
                Filters = new()
                {
                    ["ExamId"] = _examId,
                }
            };

            _questionlist = _examQuestionService.GetAll(getExamdto).Select(q => q.Question).ToList();

            if (_questionlist.Count == 0)
            {
                MessageBox.Show("No questions were retrieved. Check if examId is correct.");
                return;
            }
        }
        private void DisplayQuestion()
        {
            if (_questionlist.Count == 0) return;

            var question = _questionlist[_currentQuestionIndex];

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
                    TabIndex = tabIndex++,
                    Tag = answer.Id
                };

                choice.CheckedChanged += (s, e) => UpdateFlagColors(); // Update button when answer changes

                qbody.Controls.Add(choice);
                yOffset += 40;
            }

            UpdateFlagColors();
            if (_currentQuestionIndex == _questionlist.Count - 1)
            {
                nxt_btn.Hide();
            }
            if (_currentQuestionIndex == 0)
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
            var duration = _stdExam.Exam.EndTime - _stdExam.Exam.StartTime;

            var timeElapsed = DateTime.Now - _stdExam.Exam.StartTime;
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
            MessageBox.Show($"Moving to question {_currentQuestionIndex + 1} of {_questionlist.Count}"); // Debugging

            if (_currentQuestionIndex < _questionlist.Count - 1)
            {
                if (!IsAnswerSelected())
                {
                    MessageBox.Show("Please select an answer before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _currentQuestionIndex++;
                DisplayQuestion();
                MessageBox.Show($"Moving to question {_currentQuestionIndex + 1} of {_questionlist.Count}"); // Debugging

            }
        }
        private void pre_btn_Click(object sender, EventArgs e)
        {

            if (_currentQuestionIndex > 0)
            {
                _currentQuestionIndex--;
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
            for (int i = 0; i < _questionlist.Count; i++)
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
            List<int> responsedAnswers = new();

            for (int i = 0; i < _questionlist.Count; i++)
            {
                // TODO: enable multiple selection
                var selectedAnswer = qbody.Controls
                    .OfType<RadioButton>()
                    .FirstOrDefault(rb => rb.Checked);

                if (selectedAnswer != null)
                {
                    responsedAnswers.Add(Convert.ToInt32(selectedAnswer.Tag));
                }
            }

            if (responsedAnswers.Count < _questionlist.Count)
            {
                Messages.ShowSnackbarError("Please answer all questions before submitting.");
                return;
            }

            SaveResponses(responsedAnswers);
            Messages.ShowSnackbarNotification("Exam submitted successfully!");
            var studentForm = FormsRepo.GetForm<StudentMainForm>();
            studentForm.Show();
            this.Close();
        }
        //FIX it please ya ma7moud
        internal void SaveResponses(List<int> responsedAnswers)
        {
            foreach (var answerId in responsedAnswers)
            {
                try
                {
                    _stdAnswerService.Create(new StudentAnswer() { StudentExamId = _stdExam.Id, AnswerId = answerId });
                }
                catch (Utilities.Exceptoins.AppException ex)
                {
                    //if (ex.Message.Contains("Cannot insert duplicate key"))
                    //{
                    //    Messages.ShowSnackbarError($"Duplicate answer detected for Question ID: {response.Key}. Please review your answers.");
                    //    return;
                    //}
                    //else if (ex.Message.Contains("The given key 'StudentExamId' was not present in the dictionary"))
                    //{
                    //    Messages.ShowSnackbarError($"The key 'StudentExamId' was not found for Question ID: {response.Key}.");
                    //    return;
                    //}
                    //else if (ex.Message.Contains("The INSERT statement conflicted with the FOREIGN KEY constraint"))
                    //{
                    //    Messages.ShowSnackbarError($"Foreign key constraint violation for Question ID: {response.Key}. Please ensure the StudentExamId is valid.");
                    //    return;
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                    Messages.ShowSnackbarError(ex.Message);
                    return;
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
