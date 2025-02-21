using Entities;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class CreateExamForm : Form
    {
        public CreateExamForm()
        {
            InitializeComponent();
            SetupDatePickers();





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonDropButton1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateExamForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SetupDatePickers()
        {
            // Configure the Start Date Picker
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.CustomFormat = "dd/MM/yyyy HH:mm";  // Customize the format

            // Configure the End Date Picker
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.CustomFormat = "dd/MM/yyyy HH:mm";  // Customize the format
        }

        private void LoadSubjects()
        {
            try
            {
                // Retrieve all subjects from the database
                GetAllSubjectsInputDto inputDto = new GetAllSubjectsInputDto();
                List<Subject> subjects = SubjectService.GetAllSubjects(inputDto);

                // Clear and populate the Subject ComboBox
                Subject_Box.Items.Clear();
                foreach (var subject in subjects)
                {
                    Subject_Box.Items.Add(subject);
                }

                // Set default selection
                if (Subject_Box.Items.Count > 0)
                {
                    Subject_Box.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            try
            {
                // Get inputs from form fields
                string examName = Name_Box.Text.Trim();
                int? subjectId = Subject_Box.SelectedItem is Subject selectedSubject ? selectedSubject.Id : null;
                DateTime startTime = startDatePicker.Value;
                DateTime endTime = endDatePicker.Value;
                ExamType examType = (ExamType)Enum.Parse(typeof(ExamType), Type_Box.SelectedItem.ToString());
                string instructions = string.IsNullOrWhiteSpace(Instructions_Box.Text) ? null : Instructions_Box.Text.Trim();

                // Validate input
                if (string.IsNullOrEmpty(examName))
                {
                    MessageBox.Show("Exam name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (subjectId == null)
                {
                    MessageBox.Show("Please select a subject.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (endTime <= startTime)
                {
                    MessageBox.Show("End time must be after start time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create DTO and call the CreateExam method
                CreateExamInputDto examDto = new(examName, subjectId, startTime, endTime, examType, instructions);
                Exam createdExam = ExamService.CreateExam(examDto);

                // Display success message
                MessageBox.Show($"Exam '{createdExam.Name}' created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close form or reset fields
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating exam: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
