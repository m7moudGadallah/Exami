namespace Presentation.Forms
{
    partial class UpdateQuestions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            comboQuestion = new ComboBox();
            txtQuestion = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtOption1 = new TextBox();
            txtOption2 = new TextBox();
            txtOption3 = new TextBox();
            label6 = new Label();
            txtOption4 = new TextBox();
            label7 = new Label();
            txtAnswer = new TextBox();
            label8 = new Label();
            btnUpdate = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(253, 36);
            label1.TabIndex = 0;
            label1.Text = "Update Question";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(177, 88);
            label2.Name = "label2";
            label2.Size = new Size(193, 25);
            label2.TabIndex = 1;
            label2.Text = "Question Number: ";
            // 
            // comboQuestion
            // 
            comboQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboQuestion.ForeColor = SystemColors.InfoText;
            comboQuestion.FormattingEnabled = true;
            comboQuestion.Location = new Point(177, 126);
            comboQuestion.Name = "comboQuestion";
            comboQuestion.Size = new Size(386, 36);
            comboQuestion.TabIndex = 2;
            comboQuestion.SelectedIndexChanged += comboQuestion_SelectedIndexChanged;
            // 
            // txtQuestion
            // 
            txtQuestion.AutoSize = true;
            txtQuestion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuestion.ForeColor = Color.Brown;
            txtQuestion.Location = new Point(503, 186);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(112, 25);
            txtQuestion.TabIndex = 3;
            txtQuestion.Text = "Question: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 225);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(737, 40);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(177, 295);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 5;
            label4.Text = "Option 1 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(650, 295);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 6;
            label5.Text = "Option 2 :";
            // 
            // txtOption1
            // 
            txtOption1.Location = new Point(177, 336);
            txtOption1.Multiline = true;
            txtOption1.Name = "txtOption1";
            txtOption1.Size = new Size(303, 34);
            txtOption1.TabIndex = 7;
            // 
            // txtOption2
            // 
            txtOption2.Location = new Point(650, 336);
            txtOption2.Multiline = true;
            txtOption2.Name = "txtOption2";
            txtOption2.Size = new Size(303, 34);
            txtOption2.TabIndex = 8;
            // 
            // txtOption3
            // 
            txtOption3.Location = new Point(177, 437);
            txtOption3.Multiline = true;
            txtOption3.Name = "txtOption3";
            txtOption3.Size = new Size(303, 33);
            txtOption3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(177, 398);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 9;
            label6.Text = "Option 3 :";
            // 
            // txtOption4
            // 
            txtOption4.Location = new Point(650, 438);
            txtOption4.Multiline = true;
            txtOption4.Name = "txtOption4";
            txtOption4.Size = new Size(303, 32);
            txtOption4.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Brown;
            label7.Location = new Point(650, 398);
            label7.Name = "label7";
            label7.Size = new Size(107, 25);
            label7.TabIndex = 11;
            label7.Text = "Option 4 :";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(195, 540);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(737, 43);
            txtAnswer.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Brown;
            label8.Location = new Point(503, 500);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 13;
            label8.Text = "Answer: ";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Brown;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.Window;
            btnUpdate.Location = new Point(370, 610);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button1_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Brown;
            btnReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.Window;
            btnReset.Location = new Point(583, 610);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 40);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // UpdateQuestions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(btnReset);
            Controls.Add(btnUpdate);
            Controls.Add(txtAnswer);
            Controls.Add(label8);
            Controls.Add(txtOption4);
            Controls.Add(label7);
            Controls.Add(txtOption3);
            Controls.Add(label6);
            Controls.Add(txtOption2);
            Controls.Add(txtOption1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(txtQuestion);
            Controls.Add(comboQuestion);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.WindowText;
            Name = "UpdateQuestions";
            Size = new Size(1000, 700);
            Load += UpdateQuestions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboQuestion;
        private Label txtQuestion;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox txtOption1;
        private TextBox txtOption2;
        private TextBox txtOption3;
        private Label label6;
        private TextBox txtOption4;
        private Label label7;
        private TextBox txtAnswer;
        private Label label8;
        private Button btnUpdate;
        private Button btnReset;
    }
}
