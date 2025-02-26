using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Entities;
using Presentation.Helpers;
using Services.Services;
using Services.DTOs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace WinFormsApp3
{
    public partial class ExamForm : Form
    {
        readonly StudentExamService _studentExamService = ServicesRepo.GetService<StudentExamService>();
        readonly ExamQuestionService _examQuestionService = ServicesRepo.GetService<ExamQuestionService>();
        readonly StudentAnswerService _studentAnswerService = ServicesRepo.GetService<StudentAnswerService>();
        int _currentQuestionIndex = 0;
        bool[] _flaggedQuestions;
        StudentExam _exam;
        User _student;
        string _examName;
        string _userName;

        List<Question> _questions;
        List<StudentAnswer> _stdAnswers;

        public ExamForm()
        {
            InitializeComponent();
            CustomizeButtons();
            _student = UserSession.LoggedInUser;
            _userName = $"{_student.FirstName} {_student.LastName}";
            var stdExamId = ExamSession.SelectedExam;

            _exam = _studentExamService.GetAll(new GetAllDto
            {
                Filters = new()
                {
                    ["Id"] = stdExamId
                }
            })[0];

            _examName = _exam.Exam.Name;

            _questions = _examQuestionService.GetAll(new GetAllDto
            {
                Filters = new()
                {
                    ["ExamId"] = _exam.Exam.Id
                }
            }).Select(q => q.Question).ToList();

            _flaggedQuestions = new bool[_questions.Count];
            _stdAnswers = _studentAnswerService.GetAll(new GetAllDto
            {
                Filters = new()
                {
                    ["StudentExamId"] = _exam.ExamId
                }
            });

            DisplayQuestion(_currentQuestionIndex);
        }

        private void CustomizeButtons()
        {
            // Apply rounded corners to all buttons
            question1Button.Region = CreateRoundedRegion(question1Button.Size, 10);

            prevButton.Region = CreateRoundedRegion(prevButton.Size, 5);
            nextButton.Region = CreateRoundedRegion(nextButton.Size, 5);
            submitButton.Region = CreateRoundedRegion(submitButton.Size, 5);
            flagButton.Region = CreateRoundedRegion(flagButton.Size, 5);
        }

        private Region CreateRoundedRegion(Size size, int radius)
        {
            Rectangle rect = new Rectangle(0, 0, size.Width, size.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90); // Top-left
            path.AddArc(rect.Width - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90); // Top-right
            path.AddArc(rect.Width - (radius * 2), rect.Height - (radius * 2), radius * 2, radius * 2, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Height - (radius * 2), radius * 2, radius * 2, 90, 90); // Bottom-left
            path.CloseFigure();
            return new Region(path);
        }

        private void DisplayQuestion(int index)
        {
            answerPanel.Controls.Clear();

            // Set exam details
            examNameTextBox.Text = _examName;
            userNameTextBox.Text = _userName;
            examTimeLabel.Text = "00:00:00"; // Implement a timer here if needed

            int panelWidth = answerPanel.Width;
            int panelHeight = answerPanel.Height;

            // Display question text
            var currQuestion = _questions[index];
            questionText.Text = currQuestion.Body;
            questionText.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            questionText.TextAlign = ContentAlignment.MiddleCenter;
            questionText.AutoSize = false;
            questionText.Size = new Size(panelWidth - 100, 100);
            questionText.Location = new Point(50, 20);
            var existingAnswers = _stdAnswers.Where(a => a.StudentExamId == _exam.Id).ToList();
            answerPanel.Controls.Add(questionText);

            int yOffset = 140; // Adjusted to center answers below the question

            if (currQuestion.QuestionType != QuestionType.ChooseAll)
            {
                // Radio buttons for single-choice questions
                RadioButton[] radioButtons = new RadioButton[currQuestion.Answers.Count];
                for (int i = 0; i < currQuestion.Answers.Count; i++)
                {
                    radioButtons[i] = new RadioButton
                    {
                        Text = currQuestion.Answers[i].AnswerText,
                        Tag = currQuestion.Answers[i].Id,
                        Font = new Font("Segoe UI", 18F, FontStyle.Regular),
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Size = new Size(panelWidth - 100, 50),
                        Location = new Point(50, yOffset + (i * 60)),
                        Checked = existingAnswers.Any(a => a.AnswerId == currQuestion.Answers[i].Id)
                    };
                    int j = i; // Capture i for event handler
                    radioButtons[i].CheckedChanged += (sender, e) =>
                    {
                        if (radioButtons[j].Checked)
                        {
                            int selectedAnswerId = (int)radioButtons[j].Tag;
                            var existingAnswer = existingAnswers.FirstOrDefault(a => a.AnswerId == selectedAnswerId);

                            if (existingAnswer == null)
                            {
                                var newStdAnswer = new StudentAnswer
                                {
                                    StudentExamId = _exam.Id,
                                    AnswerId = selectedAnswerId,
                                    CreatedAt = DateTime.Now
                                };
                                _stdAnswers.Add(newStdAnswer);
                                _studentAnswerService.Create(newStdAnswer);
                            }
                            // If an answer already exists for another option, remove it (single choice)
                            var otherAnswers = existingAnswers.Where(a => a.AnswerId != selectedAnswerId).ToList();
                            foreach (var oldAnswer in otherAnswers)
                            {
                                _stdAnswers.Remove(oldAnswer);
                                _studentAnswerService.Delete(oldAnswer.StudentExamId, oldAnswer.AnswerId); // Assuming Delete method exists
                            }
                        }
                    };
                    answerPanel.Controls.Add(radioButtons[i]);
                }
            }
            else
            {
                // Checkboxes for multiple-choice questions
                CheckBox[] checkBoxes = new CheckBox[currQuestion.Answers.Count];
                for (int i = 0; i < currQuestion.Answers.Count; i++)
                {
                    checkBoxes[i] = new CheckBox
                    {
                        Text = currQuestion.Answers[i].AnswerText,
                        Tag = currQuestion.Answers[i].Id,
                        Font = new Font("Segoe UI", 18F, FontStyle.Regular),
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Size = new Size(panelWidth - 100, 50),
                        Location = new Point(50, yOffset + (i * 60)),
                        Checked = existingAnswers.Any(a => a.AnswerId == currQuestion.Answers[i].Id)
                    };
                    int j = i; // Capture i for the event handler
                    checkBoxes[i].CheckedChanged += (sender, e) =>
                    {
                        int selectedAnswerId = (int)checkBoxes[j].Tag;
                        var existingAnswer = existingAnswers.FirstOrDefault(a => a.AnswerId == selectedAnswerId);

                        if (checkBoxes[j].Checked)
                        {
                            if (existingAnswer == null)
                            {
                                var newStdAnswer = new StudentAnswer
                                {
                                    StudentExamId = _exam.Id,
                                    AnswerId = selectedAnswerId,
                                    CreatedAt = DateTime.Now
                                };
                                _stdAnswers.Add(newStdAnswer);
                                _studentAnswerService.Create(newStdAnswer);
                            }
                        }
                        else
                        {
                            if (existingAnswer != null)
                            {
                                _stdAnswers.Remove(existingAnswer);
                                _studentAnswerService.Delete(existingAnswer.StudentExamId, existingAnswer.StudentExamId); // Assuming Delete method exists
                            }
                        }
                    };
                    answerPanel.Controls.Add(checkBoxes[i]);
                }
            }

            // Update navigation buttons
            prevButton.Visible = index > 0;
            prevButton.Size = new Size(150, 50);
            prevButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            prevButton.Location = new Point(50, panelHeight - 80);

            nextButton.Visible = index < _questions.Count - 1;
            nextButton.Size = new Size(150, 50);
            nextButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            nextButton.Location = new Point(panelWidth - 200, panelHeight - 80);

            answerPanel.Controls.Add(prevButton);
            answerPanel.Controls.Add(nextButton);

            // Update question button appearance (e.g., highlight flagged questions)
            UpdateQuestionButtons();
        }

        private void UpdateQuestionButtons()
        {
            for (int i = 0; i < _questions.Count; i++)
            {
                var foundControls = Controls.Find($"question{i + 1}Button", true);
                if (foundControls.Length > 0)
                {
                    Button btn = foundControls[0] as Button;
                    if (btn != null)
                    {
                        btn.BackColor = _flaggedQuestions[i] ? Color.DarkOrange : System.Drawing.ColorTranslator.FromHtml("#BCCCDC");
                    }
                }
            }
        }


        private void questionButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            //Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonText = clickedButton.Text;
                int index = int.Parse(buttonText.Split(' ')[1]) - 1;
                _currentQuestionIndex = index;
                DisplayQuestion(_currentQuestionIndex);
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (_currentQuestionIndex > 0)
            {
                _currentQuestionIndex--;
                DisplayQuestion(_currentQuestionIndex);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (_currentQuestionIndex < _questions.Count - 1)
            {
                _currentQuestionIndex++;
                DisplayQuestion(_currentQuestionIndex);
            }
        }

        private void flagButton_Click(object sender, EventArgs e)
        {
            _flaggedQuestions[_currentQuestionIndex] = !_flaggedQuestions[_currentQuestionIndex];
            UpdateQuestionButtons();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string results = "";
            for (int i = 0; i < _questions.Count; i++)
            {
                results += $"Question {i + 1}: {_questions[i].Text}\nAnswer: {_questions[i].Answer ?? "Not answered"}\n\n";
            }
            MessageBox.Show(results, "Exam Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Close the form after submission
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            // Initialize with the first question
            DisplayQuestion(0);
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void answerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
