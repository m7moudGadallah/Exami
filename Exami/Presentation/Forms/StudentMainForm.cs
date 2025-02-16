
using Entities;
using Services.DTOs;
using MaterialSkin.Controls;
using Services.Services;
using Krypton.Toolkit;
using Presentation.Helpers;

namespace Presentation
{
    public partial class StudentMainForm : Form
    {
        private readonly List<Exam> _exams = new List<Exam>();
        private readonly HashSet<int> _loadedExamIds = new HashSet<int>();
        private readonly int studentId = UserSession.LoggedInUser.Id;
        private  int selectedExamId;

        private void LoadExams()
        {
            if (UserSession.LoggedInUser == null) return;

            var filters = new Dictionary<string, object>
            {
                { "StudentId", studentId }
            };
            var examsDto = new GetAllStudentExamsInputDto(filters);
            var studentExams = StudentExamService.GetAllStudentExams(examsDto);

            foreach (var examRecord in studentExams)
            {
                if (_loadedExamIds.Contains(examRecord.ExamId)) continue;

                var exam = ExamService.GetExam(new GetExamInputDto(examRecord.ExamId));
                if (exam != null)
                {
                    _exams.Add(exam);
                    _loadedExamIds.Add(exam.Id);
                }
            }
        }

        private void DisplayExams(List<Exam> e)
        {
            if (_exams.Count == 0)
            {
                MessageBox.Show("No exams found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            content.Controls.Clear();
            content.AutoScroll = true;

            var examPanel = new FlowLayoutPanel
            {
                Location = new Point(73, 283),
                FlowDirection = FlowDirection.TopDown, // Stack exam cards vertically
                AutoSize = true,
                WrapContents = false,
                Padding = new Padding(20),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            };

            foreach (var exam in _exams)
            {
                var examCard = new MaterialCard
                {

                    Width = 753,
                    Height = 100,
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    Margin = new Padding(15),
                    Padding = new Padding(10),
                };

                // Horizontal layout for labels and button
                var horizontalPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight, // Align items in a row
                    AutoSize = true,
                    Dock = DockStyle.Fill,
                    WrapContents = false,
                    Padding = new Padding(5),
                };

                var examNameLabel = new Label
                {
                    Text = $"{exam.Name}",
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.Brown,
                    AutoSize = true,
                    Location = new Point(5, 5),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(5)
                };

                var dateLabel = new Label
                {
                    Text = $"{exam.StartTime:yyyy-MM-dd HH:mm}",
                    Font = new Font("Arial", 14, FontStyle.Regular),
                    ForeColor = Color.White,
                    BackColor = Color.Brown,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(5),
                    Location = new Point(196, 5),

                };

                var durationLabel = new Label
                {
                    Text = $"{(exam.EndTime - exam.StartTime).TotalMinutes} mins",
                    Font = new Font("Arial", 14, FontStyle.Regular),
                    ForeColor = Color.White,
                    BackColor = Color.Brown,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(5),
                    Location = new Point(387, 5),

                };

                var viewBtn = new KryptonButton
                {
                    Text = "View Exam",
                    AutoSize = true,
                    StateCommon =
    {
        Back =
        {
            Color1 = Color.Brown,
            Color2 = Color.Brown
        },
        Content =
        {
            ShortText =
            {
                Color1 = Color.White,
                Font = new Font("Arial", 14, FontStyle.Bold)
            }
        }
    },
                };
                Location = new Point(578, 5);

                viewBtn.StatePressed.Back.Color1 = Color.Brown;
                viewBtn.StatePressed.Back.Color2 = Color.Brown;
                viewBtn.StatePressed.Content.ShortText.Color1 = Color.White;
                viewBtn.StateTracking.Back.Color1 = Color.Brown;
                viewBtn.StateTracking.Back.Color2 = Color.Brown;
                viewBtn.StateTracking.Content.ShortText.Color1 = Color.White;
                viewBtn.StateNormal.Back.Color1 = Color.Brown;
                viewBtn.StateNormal.Back.Color2 = Color.Brown;
                viewBtn.StateNormal.Content.ShortText.Color1 = Color.White;
                viewBtn.StateDisabled.Back.Color1 = Color.Brown;
                viewBtn.StateDisabled.Back.Color2 = Color.Brown;
                viewBtn.StateDisabled.Content.ShortText.Color1 = Color.White;
                viewBtn.StateCommon.Back.Color1 = Color.Brown;
                viewBtn.StateCommon.Back.Color2 = Color.Brown;
                viewBtn.StateCommon.Content.ShortText.Color1 = Color.White;

                // Add elements to horizontal layout
                horizontalPanel.Controls.Add(examNameLabel);
                horizontalPanel.Controls.Add(dateLabel);
                horizontalPanel.Controls.Add(durationLabel);
                horizontalPanel.Controls.Add(viewBtn);

                // Add horizontal layout to the card
                examCard.Controls.Add(horizontalPanel);
                examPanel.Controls.Add(examCard);
                // Inside the foreach loop in DisplayExams()
                viewBtn.Click += (s, e) =>
                {
                    selectedExamId = exam.Id; // Store the selected exam's ID
                    view_Click(s, e); // Trigger the view_Click event
                };

            }

            content.Controls.Add(examPanel);
            content.Controls.SetChildIndex(examPanel, 0); // Ensure it's centered
        }

        private void inqueue_btn_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            List<Exam> upcomingExams = new List<Exam>();

            foreach (var exam in _exams)
            {
                if (exam.StartTime > today)
                {
                    upcomingExams.Add(exam);
                    DisplayExams(upcomingExams);
                }
                else
                {
                    MessageBox.Show("No upcoming exams found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            List<Exam> pastExams = new List<Exam>();
            foreach (var exam in _exams)
            {
                if (exam.EndTime < today)
                {
                    pastExams.Add(exam);
                    DisplayExams(pastExams);
                }
                else
                {
                    MessageBox.Show("No past exams found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void allexams_btn_Click(object sender, EventArgs e)
        {
            DisplayExams(_exams);
        }

        private void view_Click(object sender, EventArgs e)
        {
   
            if (selectedExamId == null)
            {
                MessageBox.Show("Selected exam not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Exam selectedExam = ExamService.GetExam(new GetExamInputDto(selectedExamId));
            ExamSession.SetSession(studentId, selectedExamId);
            MessageBox.Show($"Session started for {studentId} on exam {selectedExam.Name}.");
        }

    }
}
