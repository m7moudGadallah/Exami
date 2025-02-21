using Entities;
using MaterialSkin;
using Presentation.Helpers;
using MaterialColorScheme = MaterialSkin.ColorScheme;

namespace Presentation
{
    internal partial class StudentMainForm
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
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }
 
        public StudentMainForm()
        {
            this.Load += new EventHandler(StudentMainForm_Load);
            InitializeComponent();
            sd_name.Text = $"{UserSession.LoggedInUser.FirstName} {UserSession.LoggedInUser.LastName}";
            this.FormClosing += StudentMainForm_FormClosing;

        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            LoadExams();
            inqueue_btn.PerformClick();
        }

        private void DisplayExams(List<StudentExam> e)
        {
            panel2.Controls.Clear();
            if (e == null || e.Count == 0)
            {
                MessageBox.Show("No exams found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int yOffset = splitContainer1.Panel2.Controls.Count * 130 + 20; // Start after existing cards

            foreach (var exam in e)
            {
                string examId = exam.Id.ToString();
                var examinfo = new MaterialSkin.Controls.MaterialCard();
                var eview = new Krypton.Toolkit.KryptonButton();
                var eduration = new Label();
                var edate = new Label();
                var ename = new Label();

                examinfo.SuspendLayout();

                // Exam Card
                examinfo.BackColor = Color.White;
                examinfo.BorderStyle = BorderStyle.Fixed3D;
                examinfo.Controls.Add(eview);
                examinfo.Controls.Add(eduration);
                examinfo.Controls.Add(edate);
                examinfo.Controls.Add(ename);
                examinfo.Depth = 0;
                examinfo.ForeColor = Color.Black;
                examinfo.Location = new Point(60, yOffset);
                examinfo.Margin = new Padding(14);
                examinfo.MouseState = MouseState.HOVER;
                examinfo.Name = $"examinfo_{examId}"; // Unique name
                examinfo.Padding = new Padding(14);
                examinfo.Size = new Size(750, 117);
                examinfo.TabIndex = 0;

                // View Button
                eview.Location = new Point(591, 37);
                eview.Name = $"eview_{examId}"; // Unique name
                eview.Size = new Size(138, 50);
                eview.StateCommon.Back.Color1 = Color.Brown;
                eview.StateCommon.Back.Color2 = Color.Brown;
                eview.StateCommon.Border.Rounding = 3F;
                eview.StateCommon.Border.Width = 2;
                eview.StateCommon.Content.ShortText.Color1 = Color.White;
                eview.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F);
                eview.Values.Text = "View";
                eview.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
                eview.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
                eview.StateNormal.Back.Color1 = Color.Brown;
                eview.StateNormal.Back.Color2 = Color.Brown;
                eview.StatePressed.Back.Color1 = Color.Maroon;
                eview.StatePressed.Back.Color2 = Color.Maroon;
                eview.StateTracking.Back.Color1 = Color.Brown;
                eview.StateTracking.Back.Color2 = Color.Brown;

                // Attach Click Event Handler (IMPORTANT)
                eview.Click += (sender, args) => eview_click(sender, args, exam.Exam);

                // Duration Label
                eduration.BackColor = Color.Brown;
                eduration.Font = new Font("Tahoma", 18F);
                eduration.ForeColor = SystemColors.ButtonHighlight;
                eduration.Location = new Point(407, 37);
                eduration.Name = $"eduration_{examId}";
                eduration.Size = new Size(143, 50);
                eduration.TabIndex = 51;
                eduration.Text = $"{exam.Exam.EndTime - exam.Exam.StartTime}";
                eduration.TextAlign = ContentAlignment.MiddleCenter;

                // Date Label
                edate.BackColor = Color.Brown;
                edate.Font = new Font("Tahoma", 18F);
                edate.ForeColor = SystemColors.ButtonHighlight;
                edate.Location = new Point(209, 37);
                edate.Name = $"edate_{examId}";
                edate.Size = new Size(143, 50);
                edate.TabIndex = 51;
                edate.Text = $"{exam.Exam.StartTime}";
                edate.TextAlign = ContentAlignment.MiddleCenter;

                // Name Label
                ename.BackColor = Color.Brown;
                ename.Font = new Font("Tahoma", 18F);
                ename.ForeColor = SystemColors.ButtonHighlight;
                ename.Location = new Point(19, 37);
                ename.Name = $"ename_{examId}";
                ename.Size = new Size(143, 50);
                ename.TabIndex = 50;
                ename.Text = $"{exam.Exam.Name}";
                ename.TextAlign = ContentAlignment.MiddleCenter;

                // Add card to panel
                splitContainer1.Panel2.Controls.Add(examinfo);

                // Adjust Y position for next card
                yOffset += 130;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            contactlink = new Krypton.Toolkit.KryptonLinkLabel();
            help_link = new Krypton.Toolkit.KryptonLinkLabel();
            done_btn = new Krypton.Toolkit.KryptonButton();
            inqueue_btn = new Krypton.Toolkit.KryptonButton();
            allexams_btn = new Krypton.Toolkit.KryptonButton();
            header = new Panel();
            sd_name = new Label();
            pictureBox1 = new PictureBox();
            logo = new Label();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // contactlink
            // 
            contactlink.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
            contactlink.Location = new Point(30, 38);
            contactlink.Name = "contactlink";
            contactlink.OverrideFocus.Padding = new Padding(3);
            contactlink.OverrideFocus.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            contactlink.OverrideFocus.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            contactlink.Size = new Size(170, 27);
            contactlink.StateCommon.Padding = new Padding(3);
            contactlink.StateCommon.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            contactlink.StateCommon.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            contactlink.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            contactlink.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactlink.StateDisabled.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            contactlink.StateDisabled.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            contactlink.StateNormal.Padding = new Padding(3);
            contactlink.StateNormal.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            contactlink.StateNormal.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            contactlink.StateNormal.ShortText.ColorAngle = 1F;
            contactlink.StateNormal.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            contactlink.StateNormal.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            contactlink.TabIndex = 40;
            contactlink.Values.Text = "Contact Your Institute";
            // 
            // help_link
            // 
            help_link.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
            help_link.Location = new Point(776, 38);
            help_link.Name = "help_link";
            help_link.OverrideFocus.Padding = new Padding(3);
            help_link.OverrideFocus.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            help_link.OverrideFocus.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            help_link.Size = new Size(100, 27);
            help_link.StateCommon.Padding = new Padding(3);
            help_link.StateCommon.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            help_link.StateCommon.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            help_link.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            help_link.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            help_link.StateNormal.Padding = new Padding(3);
            help_link.StateNormal.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            help_link.StateNormal.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            help_link.StateNormal.ShortText.ColorAngle = 1F;
            help_link.StateNormal.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            help_link.StateNormal.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            help_link.TabIndex = 41;
            help_link.Values.Text = "Help Centre";
            // 
            // done_btn
            // 
            done_btn.Location = new Point(672, 21);
            done_btn.Name = "done_btn";
            done_btn.OverrideDefault.Back.Color1 = Color.Brown;
            done_btn.OverrideDefault.Back.Color2 = Color.Brown;
            done_btn.OverrideFocus.Back.Color1 = Color.Brown;
            done_btn.OverrideFocus.Back.Color2 = Color.Brown;
            done_btn.Size = new Size(138, 47);
            done_btn.StateCommon.Back.Color1 = Color.Brown;
            done_btn.StateCommon.Back.Color2 = Color.Brown;
            done_btn.StateCommon.Back.ColorAngle = 1F;
            done_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            done_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            done_btn.StateCommon.Border.ColorAngle = 1F;
            done_btn.StateCommon.Border.Rounding = 3F;
            done_btn.StateCommon.Border.Width = 2;
            done_btn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            done_btn.StateCommon.Content.LongText.Color2 = Color.White;
            done_btn.StateCommon.Content.ShortText.Color1 = Color.White;
            done_btn.StateCommon.Content.ShortText.Color2 = Color.White;
            done_btn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            done_btn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            done_btn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            done_btn.StateDisabled.Back.Color1 = Color.Brown;
            done_btn.StateDisabled.Back.Color2 = Color.Brown;
            done_btn.StateDisabled.Border.Rounding = 3F;
            done_btn.StateDisabled.Border.Width = 2;
            done_btn.StateNormal.Back.Color1 = Color.Brown;
            done_btn.StateNormal.Back.Color2 = Color.Brown;
            done_btn.StatePressed.Back.Color1 = Color.Maroon;
            done_btn.StatePressed.Back.Color2 = Color.Maroon;
            done_btn.StatePressed.Border.Rounding = 3F;
            done_btn.StatePressed.Border.Width = 5;
            done_btn.StateTracking.Back.Color1 = Color.Brown;
            done_btn.StateTracking.Back.Color2 = Color.Brown;
            done_btn.TabIndex = 44;
            done_btn.UseMnemonic = false;
            done_btn.Values.DropDownArrowColor = Color.Empty;
            done_btn.Values.ImageTransparentColor = Color.White;
            done_btn.Values.Text = "Done";
            done_btn.Click += done_btn_Click;

            // 
            // inqueue_btn
            // 
            inqueue_btn.Location = new Point(60, 21);
            inqueue_btn.Name = "inqueue_btn";
            inqueue_btn.OverrideDefault.Back.Color1 = Color.Brown;
            inqueue_btn.OverrideDefault.Back.Color2 = Color.Brown;
            inqueue_btn.OverrideFocus.Back.Color1 = Color.Brown;
            inqueue_btn.OverrideFocus.Back.Color2 = Color.Brown;
            inqueue_btn.Size = new Size(138, 47);
            inqueue_btn.StateCommon.Back.Color1 = Color.Brown;
            inqueue_btn.StateCommon.Back.Color2 = Color.Brown;
            inqueue_btn.StateCommon.Back.ColorAngle = 1F;
            inqueue_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            inqueue_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            inqueue_btn.StateCommon.Border.ColorAngle = 1F;
            inqueue_btn.StateCommon.Border.Rounding = 3F;
            inqueue_btn.StateCommon.Border.Width = 2;
            inqueue_btn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            inqueue_btn.StateCommon.Content.LongText.Color2 = Color.White;
            inqueue_btn.StateCommon.Content.ShortText.Color1 = Color.White;
            inqueue_btn.StateCommon.Content.ShortText.Color2 = Color.White;
            inqueue_btn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inqueue_btn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            inqueue_btn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            inqueue_btn.StateDisabled.Back.Color1 = Color.Brown;
            inqueue_btn.StateDisabled.Back.Color2 = Color.Brown;
            inqueue_btn.StateDisabled.Border.Rounding = 3F;
            inqueue_btn.StateDisabled.Border.Width = 2;
            inqueue_btn.StateNormal.Back.Color1 = Color.Brown;
            inqueue_btn.StateNormal.Back.Color2 = Color.Brown;
            inqueue_btn.StatePressed.Back.Color1 = Color.Maroon;
            inqueue_btn.StatePressed.Back.Color2 = Color.Maroon;
            inqueue_btn.StatePressed.Border.Rounding = 3F;
            inqueue_btn.StatePressed.Border.Width = 5;
            inqueue_btn.StateTracking.Back.Color1 = Color.Brown;
            inqueue_btn.StateTracking.Back.Color2 = Color.Brown;
            inqueue_btn.TabIndex = 43;
            inqueue_btn.UseMnemonic = false;
            inqueue_btn.Values.DropDownArrowColor = Color.Empty;
            inqueue_btn.Values.ImageTransparentColor = Color.White;
            inqueue_btn.Values.Text = "In Queue";
            inqueue_btn.Click += inqueue_btn_Click;
            // 
            // allexams_btn
            // 
            allexams_btn.Location = new Point(361, 21);
            allexams_btn.Name = "allexams_btn";
            allexams_btn.OverrideDefault.Back.Color1 = Color.Brown;
            allexams_btn.OverrideDefault.Back.Color2 = Color.Brown;
            allexams_btn.OverrideFocus.Back.Color1 = Color.Brown;
            allexams_btn.OverrideFocus.Back.Color2 = Color.Brown;
            allexams_btn.Size = new Size(138, 47);
            allexams_btn.StateCommon.Back.Color1 = Color.Brown;
            allexams_btn.StateCommon.Back.Color2 = Color.Brown;
            allexams_btn.StateCommon.Back.ColorAngle = 1F;
            allexams_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            allexams_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            allexams_btn.StateCommon.Border.ColorAngle = 1F;
            allexams_btn.StateCommon.Border.Rounding = 3F;
            allexams_btn.StateCommon.Border.Width = 2;
            allexams_btn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            allexams_btn.StateCommon.Content.LongText.Color2 = Color.White;
            allexams_btn.StateCommon.Content.ShortText.Color1 = Color.White;
            allexams_btn.StateCommon.Content.ShortText.Color2 = Color.White;
            allexams_btn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allexams_btn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            allexams_btn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            allexams_btn.StateDisabled.Back.Color1 = Color.Brown;
            allexams_btn.StateDisabled.Back.Color2 = Color.Brown;
            allexams_btn.StateDisabled.Border.Rounding = 3F;
            allexams_btn.StateDisabled.Border.Width = 2;
            allexams_btn.StateNormal.Back.Color1 = Color.Brown;
            allexams_btn.StateNormal.Back.Color2 = Color.Brown;
            allexams_btn.StatePressed.Back.Color1 = Color.Maroon;
            allexams_btn.StatePressed.Back.Color2 = Color.Maroon;
            allexams_btn.StatePressed.Border.Rounding = 3F;
            allexams_btn.StatePressed.Border.Width = 5;
            allexams_btn.StateTracking.Back.Color1 = Color.Brown;
            allexams_btn.StateTracking.Back.Color2 = Color.Brown;
            allexams_btn.TabIndex = 42;
            allexams_btn.UseMnemonic = false;
            allexams_btn.Values.DropDownArrowColor = Color.Empty;
            allexams_btn.Values.ImageTransparentColor = Color.White;
            allexams_btn.Values.Text = "All Exams";
            //allexams_btn.Click += allexams_btn_Click;
            // 
            // header
            // 
            header.BackColor = Color.Brown;
            header.Controls.Add(sd_name);
            header.Controls.Add(pictureBox1);
            header.Controls.Add(logo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1000, 109);
            header.TabIndex = 46;
            // 
            // sd_name
            // 
            sd_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sd_name.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sd_name.ForeColor = SystemColors.ButtonHighlight;
            sd_name.Location = new Point(641, 0);
            sd_name.Name = "sd_name";
            sd_name.Size = new Size(235, 109);
            sd_name.TabIndex = 49;
            sd_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(872, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 109);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logo.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logo.ForeColor = SystemColors.ButtonHighlight;
            logo.Location = new Point(390, 0);
            logo.Name = "logo";
            logo.Size = new Size(163, 109);
            logo.TabIndex = 0;
            logo.Text = "Exami";
            logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(help_link);
            panel2.Controls.Add(contactlink);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 666);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 101);
            panel2.TabIndex = 47;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(54, 138);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(allexams_btn);
            splitContainer1.Panel1.Controls.Add(inqueue_btn);
            splitContainer1.Panel1.Controls.Add(done_btn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Size = new Size(882, 509);
            splitContainer1.SplitterDistance = 97;
            splitContainer1.TabIndex = 48;
            // 
            // StudentMainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CausesValidation = false;
            ClientSize = new Size(1000, 767);
            Controls.Add(splitContainer1);
            Controls.Add(panel2);
            Controls.Add(header);
            HelpButton = true;
            Name = "StudentMainForm";
            ShowIcon = false;
            header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
       
        private Krypton.Toolkit.KryptonLinkLabel contactlink;
        private Krypton.Toolkit.KryptonLinkLabel help_link;
        private Krypton.Toolkit.KryptonButton done_btn;
        private Krypton.Toolkit.KryptonButton inqueue_btn;
        private Krypton.Toolkit.KryptonButton allexams_btn;
        private Krypton.Toolkit.KryptonButton examname;
        private Krypton.Toolkit.KryptonButton duration;
        private Krypton.Toolkit.KryptonButton date;
        private Krypton.Toolkit.KryptonButton view_btn;
        private Panel header;
        private Label logo;
        private Panel panel2;
        private Label sd_name;
        private PictureBox pictureBox1;
        private SplitContainer splitContainer1;
    }
}