namespace Presentation.Forms
{
    partial class CreateExamForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label8 = new Label();
            Questions = new ListBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            comboBox5 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(79, 53);
            label1.Name = "label1";
            label1.Size = new Size(119, 48);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(311, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1181, 55);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(79, 225);
            label2.Name = "label2";
            label2.Size = new Size(144, 48);
            label2.TabIndex = 2;
            label2.Text = "Subject";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(79, 141);
            label3.Name = "label3";
            label3.Size = new Size(99, 48);
            label3.TabIndex = 4;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(79, 490);
            label4.Name = "label4";
            label4.Size = new Size(170, 48);
            label4.TabIndex = 6;
            label4.Text = "Duration";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(79, 354);
            label5.Name = "label5";
            label5.Size = new Size(188, 48);
            label5.TabIndex = 8;
            label5.Text = "Questions";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(79, 592);
            label6.Name = "label6";
            label6.Size = new Size(220, 48);
            label6.TabIndex = 10;
            label6.Text = "Instructions";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(311, 217);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(549, 56);
            comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(311, 133);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(549, 56);
            comboBox2.TabIndex = 13;
            // 
            // comboBox3
            // 
            comboBox3.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(310, 487);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(550, 56);
            comboBox3.TabIndex = 14;
            comboBox3.Text = "From";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(965, 487);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(526, 56);
            comboBox4.TabIndex = 15;
            comboBox4.Text = "To";
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(900, 489);
            label8.Name = "label8";
            label8.Size = new Size(28, 48);
            label8.TabIndex = 17;
            label8.Text = ":";
            label8.Click += label8_Click;
            // 
            // Questions
            // 
            Questions.ForeColor = Color.FromArgb(64, 64, 64);
            Questions.FormattingEnabled = true;
            Questions.Location = new Point(965, 306);
            Questions.Name = "Questions";
            Questions.Size = new Size(527, 148);
            Questions.TabIndex = 18;
            Questions.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.CausesValidation = false;
            button1.ForeColor = Color.White;
            button1.Location = new Point(699, 687);
            button1.Name = "button1";
            button1.Size = new Size(355, 74);
            button1.TabIndex = 19;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            richTextBox1.Location = new Point(310, 579);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1181, 79);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // comboBox5
            // 
            comboBox5.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(310, 354);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(549, 56);
            comboBox5.TabIndex = 21;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(887, 321);
            button2.Name = "button2";
            button2.Size = new Size(52, 57);
            button2.TabIndex = 22;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.ForeColor = Color.White;
            button3.Location = new Point(887, 384);
            button3.Name = "button3";
            button3.Size = new Size(52, 57);
            button3.TabIndex = 23;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = false;
            // 
            // CreateExamForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1656, 783);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox5);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(Questions);
            Controls.Add(label8);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CreateExamForm";
            Text = "CreateExamForm";
            Load += CreateExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label8;
        private ListBox Questions;
        private Button button1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox5;
        private Button button2;
        private Button button3;
    }
}