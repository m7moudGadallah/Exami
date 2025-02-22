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

        private void SetupDatePickers()
        {
            // Configure the Start Date Picker
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.CustomFormat = "dd/MM/yyyy HH:mm";  // Customize the format

            // Configure the End Date Picker
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.CustomFormat = "dd/MM/yyyy HH:mm";  // Customize the format
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonOutlookGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
