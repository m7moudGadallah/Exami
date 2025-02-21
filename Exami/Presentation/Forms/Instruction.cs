using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Helpers;
using Presentation.Forms;
using Entities;
using Services.DTOs;
using Services.Services;

namespace Presentation.Forms
{
    public partial class Instruction : Form
    {
        readonly int studentId = UserSession.LoggedInUser.Id;
        private Exam _exam;

        public Instruction(Exam exam)
        {
            InitializeComponent();
            _exam = exam;
            LoadExamDetails();
        }
        private void LoadExamDetails()
        {
            if (_exam != null)
            {
                ins_txt.Text = _exam.Instructions;
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            ExamSession.SetSession(studentId, _exam.Id);
            var examform = new ExamForm(_exam);
            examform.Show();

        }
    }
}
