namespace WinFormsApp3
{
    partial class ExamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            navPanel = new Panel();
            question1Button = new Button();
            flagButton = new Button();
            contentPanel = new Panel();
            submitButton = new Button();
            prevButton = new Button();
            nextButton = new Button();
            answerPanel = new Panel();
            questionText = new Label();
            userNameTextBox = new TextBox();
            examNameTextBox = new TextBox();
            examTimeLabel = new Label();
            mainPanel = new Panel();
            navPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            answerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.AutoSize = true;
            navPanel.BackColor = Color.FromArgb(217, 234, 253);
            navPanel.Controls.Add(question1Button);
            navPanel.Controls.Add(flagButton);
            navPanel.Location = new Point(0, 0);
            navPanel.Margin = new Padding(4, 5, 4, 5);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(250, 920);
            navPanel.TabIndex = 0;
            // 
            // question1Button
            // 
            question1Button.BackColor = Color.FromArgb(188, 204, 220);
            question1Button.FlatAppearance.BorderSize = 0;
            question1Button.FlatStyle = FlatStyle.Flat;
            question1Button.Font = new Font("Segoe UI", 15.75F);
            question1Button.ForeColor = Color.FromArgb(64, 64, 64);
            question1Button.Location = new Point(21, 173);
            question1Button.Name = "question1Button";
            question1Button.Size = new Size(55, 41);
            question1Button.TabIndex = 0;
            question1Button.Text = "Q1";
            question1Button.UseVisualStyleBackColor = false;
            question1Button.Click += questionButton_Click;
            // 
            // flagButton
            // 
            flagButton.BackColor = Color.FromArgb(188, 204, 220);
            flagButton.FlatAppearance.BorderSize = 0;
            flagButton.FlatStyle = FlatStyle.Flat;
            flagButton.Font = new Font("Segoe UI", 15.75F);
            flagButton.ForeColor = Color.FromArgb(64, 64, 64);
            flagButton.Location = new Point(93, 173);
            flagButton.Name = "flagButton";
            flagButton.Size = new Size(57, 41);
            flagButton.TabIndex = 5;
            flagButton.UseVisualStyleBackColor = false;
            flagButton.Click += flagButton_Click;
            // 
            // contentPanel
            // 
            contentPanel.AutoSize = true;
            contentPanel.BackColor = Color.FromArgb(248, 250, 252);
            contentPanel.Controls.Add(submitButton);
            contentPanel.Controls.Add(prevButton);
            contentPanel.Controls.Add(nextButton);
            contentPanel.Controls.Add(answerPanel);
            contentPanel.Controls.Add(userNameTextBox);
            contentPanel.Controls.Add(examNameTextBox);
            contentPanel.Controls.Add(examTimeLabel);
            contentPanel.Location = new Point(239, 0);
            contentPanel.Margin = new Padding(4, 5, 4, 5);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1163, 920);
            contentPanel.TabIndex = 0;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(255, 107, 107);
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Segoe UI", 15.75F);
            submitButton.ForeColor = Color.White;
            submitButton.Location = new Point(511, 867);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(120, 50);
            submitButton.TabIndex = 8;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // prevButton
            // 
            prevButton.BackColor = Color.FromArgb(128, 128, 128);
            prevButton.FlatAppearance.BorderSize = 0;
            prevButton.FlatStyle = FlatStyle.Flat;
            prevButton.Font = new Font("Segoe UI", 15.75F);
            prevButton.ForeColor = Color.White;
            prevButton.Location = new Point(337, 819);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(122, 50);
            prevButton.TabIndex = 6;
            prevButton.Text = "< prev";
            prevButton.UseVisualStyleBackColor = false;
            prevButton.Click += prevButton_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(128, 128, 128);
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Segoe UI", 15.75F);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(687, 819);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(126, 50);
            nextButton.TabIndex = 7;
            nextButton.Text = "next >";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // answerPanel
            // 
            answerPanel.BackColor = Color.White;
            answerPanel.Controls.Add(questionText);
            answerPanel.Location = new Point(74, 173);
            answerPanel.Name = "answerPanel";
            answerPanel.Size = new Size(973, 609);
            answerPanel.TabIndex = 4;
            answerPanel.Paint += answerPanel_Paint;
            // 
            // questionText
            // 
            questionText.AutoSize = true;
            questionText.Font = new Font("Segoe UI", 12F);
            questionText.ForeColor = Color.Black;
            questionText.Location = new Point(20, 20);
            questionText.Name = "questionText";
            questionText.Size = new Size(235, 21);
            questionText.TabIndex = 0;
            questionText.Text = "Q1. What is the color of the sun?";
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = Color.FromArgb(188, 204, 220);
            userNameTextBox.BorderStyle = BorderStyle.None;
            userNameTextBox.CausesValidation = false;
            userNameTextBox.Enabled = false;
            userNameTextBox.Font = new Font("Segoe UI", 15.75F);
            userNameTextBox.ForeColor = Color.Black;
            userNameTextBox.Location = new Point(428, 87);
            userNameTextBox.Multiline = true;
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.ReadOnly = true;
            userNameTextBox.Size = new Size(150, 42);
            userNameTextBox.TabIndex = 3;
            userNameTextBox.Text = "User Name";
            userNameTextBox.TextAlign = HorizontalAlignment.Center;
            userNameTextBox.WordWrap = false;
            // 
            // examNameTextBox
            // 
            examNameTextBox.BackColor = Color.FromArgb(188, 204, 220);
            examNameTextBox.BorderStyle = BorderStyle.None;
            examNameTextBox.CausesValidation = false;
            examNameTextBox.Enabled = false;
            examNameTextBox.Font = new Font("Segoe UI", 15.75F);
            examNameTextBox.ForeColor = Color.Black;
            examNameTextBox.Location = new Point(897, 87);
            examNameTextBox.Multiline = true;
            examNameTextBox.Name = "examNameTextBox";
            examNameTextBox.ReadOnly = true;
            examNameTextBox.Size = new Size(150, 42);
            examNameTextBox.TabIndex = 2;
            examNameTextBox.Text = "Exam Name";
            examNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // examTimeLabel
            // 
            examTimeLabel.BackColor = Color.FromArgb(188, 204, 220);
            examTimeLabel.Font = new Font("Segoe UI", 15.75F);
            examTimeLabel.ForeColor = Color.Black;
            examTimeLabel.ImageAlign = ContentAlignment.MiddleLeft;
            examTimeLabel.Location = new Point(74, 87);
            examTimeLabel.Name = "examTimeLabel";
            examTimeLabel.Size = new Size(150, 42);
            examTimeLabel.TabIndex = 1;
            examTimeLabel.Text = "00:00:00";
            examTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(200, 100);
            mainPanel.TabIndex = 0;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1402, 920);
            Controls.Add(contentPanel);
            Controls.Add(navPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ExamForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamForm";
            WindowState = FormWindowState.Maximized;
            Load += ExamForm_Load;
            navPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            answerPanel.ResumeLayout(false);
            answerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button question1Button;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button flagButton;
        private System.Windows.Forms.Panel answerPanel;
        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox examNameTextBox;
        private System.Windows.Forms.Label examTimeLabel;
    }
}