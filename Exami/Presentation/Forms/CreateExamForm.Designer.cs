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
            name_lbl = new Label();
            Name_Box = new TextBox();
            subject_lbl = new Label();
            type_lbl = new Label();
            duration_lbl = new Label();
            instructions_lbl = new Label();
            Subject_Box = new ComboBox();
            Type_Box = new ComboBox();
            label8 = new Label();
            Create_Button = new Button();
            Instructions_Box = new RichTextBox();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_lbl.ForeColor = Color.Brown;
            name_lbl.Location = new Point(79, 53);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(119, 48);
            name_lbl.TabIndex = 0;
            name_lbl.Text = "Name";
            name_lbl.Click += label1_Click_1;
            // 
            // Name_Box
            // 
            Name_Box.ForeColor = Color.FromArgb(64, 64, 64);
            Name_Box.Location = new Point(311, 53);
            Name_Box.Name = "Name_Box";
            Name_Box.Size = new Size(1276, 55);
            Name_Box.TabIndex = 1;
            // 
            // subject_lbl
            // 
            subject_lbl.AutoSize = true;
            subject_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subject_lbl.ForeColor = Color.Brown;
            subject_lbl.Location = new Point(79, 241);
            subject_lbl.Name = "subject_lbl";
            subject_lbl.Size = new Size(144, 48);
            subject_lbl.TabIndex = 2;
            subject_lbl.Text = "Subject";
            // 
            // type_lbl
            // 
            type_lbl.AutoSize = true;
            type_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_lbl.ForeColor = Color.Brown;
            type_lbl.Location = new Point(79, 153);
            type_lbl.Name = "type_lbl";
            type_lbl.Size = new Size(99, 48);
            type_lbl.TabIndex = 4;
            type_lbl.Text = "Type";
            // 
            // duration_lbl
            // 
            duration_lbl.AutoSize = true;
            duration_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            duration_lbl.ForeColor = Color.Brown;
            duration_lbl.Location = new Point(80, 328);
            duration_lbl.Name = "duration_lbl";
            duration_lbl.Size = new Size(170, 48);
            duration_lbl.TabIndex = 6;
            duration_lbl.Text = "Duration";
            // 
            // instructions_lbl
            // 
            instructions_lbl.AutoSize = true;
            instructions_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructions_lbl.ForeColor = Color.Brown;
            instructions_lbl.Location = new Point(80, 440);
            instructions_lbl.Name = "instructions_lbl";
            instructions_lbl.Size = new Size(220, 48);
            instructions_lbl.TabIndex = 10;
            instructions_lbl.Text = "Instructions";
            instructions_lbl.Click += label6_Click;
            // 
            // Subject_Box
            // 
            Subject_Box.ForeColor = Color.FromArgb(64, 64, 64);
            Subject_Box.FormattingEnabled = true;
            Subject_Box.Location = new Point(311, 233);
            Subject_Box.Name = "Subject_Box";
            Subject_Box.Size = new Size(576, 56);
            Subject_Box.TabIndex = 12;
            Subject_Box.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Type_Box
            // 
            Type_Box.ForeColor = Color.FromArgb(64, 64, 64);
            Type_Box.FormattingEnabled = true;
            Type_Box.Items.AddRange(new object[] { "Practice", "Final" });
            Type_Box.Location = new Point(311, 145);
            Type_Box.Name = "Type_Box";
            Type_Box.Size = new Size(576, 56);
            Type_Box.TabIndex = 13;
            Type_Box.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(930, 327);
            label8.Name = "label8";
            label8.Size = new Size(28, 48);
            label8.TabIndex = 17;
            label8.Text = ":";
            label8.Click += label8_Click;
            // 
            // Create_Button
            // 
            Create_Button.BackColor = Color.Brown;
            Create_Button.CausesValidation = false;
            Create_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Create_Button.ForeColor = Color.White;
            Create_Button.Location = new Point(678, 657);
            Create_Button.Name = "Create_Button";
            Create_Button.Size = new Size(374, 88);
            Create_Button.TabIndex = 19;
            Create_Button.Text = "Create";
            Create_Button.UseVisualStyleBackColor = false;
            Create_Button.Click += button1_Click;
            // 
            // Instructions_Box
            // 
            Instructions_Box.BorderStyle = BorderStyle.None;
            Instructions_Box.ForeColor = Color.FromArgb(64, 64, 64);
            Instructions_Box.Location = new Point(311, 427);
            Instructions_Box.Name = "Instructions_Box";
            Instructions_Box.Size = new Size(1276, 197);
            Instructions_Box.TabIndex = 20;
            Instructions_Box.Text = "";
            Instructions_Box.TextChanged += richTextBox1_TextChanged;
            // 
            // startDatePicker
            // 
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.Location = new Point(311, 326);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(576, 55);
            startDatePicker.TabIndex = 21;
            startDatePicker.Value = new DateTime(2029, 11, 22, 0, 0, 0, 0);
            startDatePicker.ValueChanged += startDatePicker_ValueChanged;
            // 
            // endDatePicker
            // 
            endDatePicker.CustomFormat = "";
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.Location = new Point(1011, 327);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(576, 55);
            endDatePicker.TabIndex = 22;
            endDatePicker.Value = new DateTime(2025, 2, 18, 0, 0, 0, 0);
            endDatePicker.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // CreateExamForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1656, 783);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(Instructions_Box);
            Controls.Add(Create_Button);
            Controls.Add(label8);
            Controls.Add(Type_Box);
            Controls.Add(Subject_Box);
            Controls.Add(instructions_lbl);
            Controls.Add(duration_lbl);
            Controls.Add(type_lbl);
            Controls.Add(subject_lbl);
            Controls.Add(Name_Box);
            Controls.Add(name_lbl);
            Name = "CreateExamForm";
            Text = "CreateExamForm";
            Load += CreateExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_lbl;
        private TextBox Name_Box;
        private Label subject_lbl;
        private Label type_lbl;
        private Label duration_lbl;
        private Label instructions_lbl;
        private ComboBox Subject_Box;
        private ComboBox Type_Box;
        private Label label8;
        private Button Create_Button;
        private RichTextBox Instructions_Box;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
    }
}