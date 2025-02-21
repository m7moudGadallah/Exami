namespace Presentation
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

        private void DisplayQuestion()
        {
            if (questionlist == null || questionlist.Count == 0) return;

            var question = questionlist[currentQuestionIndex];
            qhead.Controls.Clear();

            var answers = question.Answers;

            Label qh = new Label
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = SystemColors.ActiveCaptionText,
                Location = new Point(12, 57),
                Name = "qh",
                Size = new Size(106, 29),
                TabIndex = 50,
                Text = question.Body,
                TextAlign = ContentAlignment.MiddleCenter
            };
            qhead.Controls.Add(qh);

            int yOffset = 60;

            foreach (var answer in answers)
            {
                RadioButton choice = new RadioButton
                {
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    BackColor = Color.Transparent,
                    Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = SystemColors.ActiveCaptionText,
                    AutoSize = true,
                    Location = new Point(14, yOffset),
                    Name = "choice_" + yOffset,
                    Size = new Size(128, 27),
                    TabIndex = 50,
                    TabStop = true,
                    Text = answer.AnswerText,
                    UseVisualStyleBackColor = true

                };
                choice.BringToFront();
                qbody.Controls.Add(choice);
                yOffset += 40;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            materialScrollBar1 = new MaterialSkin.Controls.MaterialScrollBar();
            timer = new System.Windows.Forms.Timer(components);
            header = new Panel();
            timer_label = new Label();
            sd_name = new Label();
            logo = new Label();
            pictureBox1 = new PictureBox();
            main = new SplitContainer();
            qnav = new Panel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            qnum = new Label();
            qbody = new Panel();
            qhead = new Panel();
            qh = new Label();
            footer = new Panel();
            next_btn = new Krypton.Toolkit.KryptonButton();
            prev_btn = new Krypton.Toolkit.KryptonButton();
            submit_btn = new Krypton.Toolkit.KryptonButton();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)main).BeginInit();
            main.Panel1.SuspendLayout();
            main.Panel2.SuspendLayout();
            main.SuspendLayout();
            qnav.SuspendLayout();
            qhead.SuspendLayout();
            footer.SuspendLayout();
            SuspendLayout();
            // 
            // materialScrollBar1
            // 
            materialScrollBar1.Depth = 0;
            materialScrollBar1.Location = new Point(0, 0);
            materialScrollBar1.MouseState = MaterialSkin.MouseState.HOVER;
            materialScrollBar1.Name = "materialScrollBar1";
            materialScrollBar1.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Vertical;
            materialScrollBar1.Size = new Size(10, 200);
            materialScrollBar1.TabIndex = 0;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            // 
            // header
            // 
            header.BackColor = Color.Brown;
            header.Controls.Add(timer_label);
            header.Controls.Add(sd_name);
            header.Controls.Add(logo);
            header.Controls.Add(pictureBox1);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1180, 109);
            header.TabIndex = 47;
            // 
            // timer_label
            // 
            timer_label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            timer_label.BackColor = Color.Transparent;
            timer_label.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timer_label.ForeColor = SystemColors.ButtonHighlight;
            timer_label.Location = new Point(0, 0);
            timer_label.Name = "timer_label";
            timer_label.Size = new Size(203, 109);
            timer_label.TabIndex = 50;
            timer_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sd_name
            // 
            sd_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sd_name.BackColor = Color.Transparent;
            sd_name.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sd_name.ForeColor = SystemColors.ButtonHighlight;
            sd_name.Location = new Point(843, 0);
            sd_name.Name = "sd_name";
            sd_name.Size = new Size(203, 109);
            sd_name.TabIndex = 49;
            sd_name.Text = "Name";
            sd_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logo.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logo.ForeColor = SystemColors.ButtonHighlight;
            logo.Location = new Point(402, 0);
            logo.Name = "logo";
            logo.Size = new Size(241, 109);
            logo.TabIndex = 0;
            logo.Text = "Exami";
            logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(1052, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 109);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // main
            // 
            main.BackColor = Color.White;
            main.BorderStyle = BorderStyle.Fixed3D;
            main.Location = new Point(0, 112);
            main.Name = "main";
            // 
            // main.Panel1
            // 
            main.Panel1.Controls.Add(qnav);
            // 
            // main.Panel2
            // 
            main.Panel2.Controls.Add(qbody);
            main.Panel2.Controls.Add(qhead);
            main.Size = new Size(1180, 501);
            main.SplitterDistance = 182;
            main.TabIndex = 48;
            // 
            // qnav
            // 
            qnav.BorderStyle = BorderStyle.Fixed3D;
            qnav.Controls.Add(kryptonButton1);
            qnav.Controls.Add(qnum);
            qnav.Location = new Point(10, 3);
            qnav.Name = "qnav";
            qnav.Size = new Size(163, 491);
            qnav.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(107, 57);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.Firebrick;
            kryptonButton1.OverrideDefault.Back.Color2 = Color.Firebrick;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.Black;
            kryptonButton1.OverrideDefault.Border.Color2 = Color.Black;
            kryptonButton1.OverrideDefault.Border.Rounding = 100F;
            kryptonButton1.OverrideFocus.Back.Color1 = Color.Red;
            kryptonButton1.OverrideFocus.Back.Color2 = Color.Red;
            kryptonButton1.OverrideFocus.Border.Rounding = 100F;
            kryptonButton1.Size = new Size(29, 29);
            kryptonButton1.StateCommon.Back.Color1 = Color.Firebrick;
            kryptonButton1.StateCommon.Back.Color2 = Color.Firebrick;
            kryptonButton1.StateCommon.Border.Color1 = Color.DimGray;
            kryptonButton1.StateCommon.Border.Color2 = Color.Black;
            kryptonButton1.StateCommon.Border.Rounding = 100F;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateDisabled.Border.Rounding = 100F;
            kryptonButton1.StateNormal.Border.Rounding = 100F;
            kryptonButton1.StatePressed.Border.Width = 100;
            kryptonButton1.StateTracking.Border.Rounding = 100F;
            kryptonButton1.TabIndex = 52;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "";
            // 
            // qnum
            // 
            qnum.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            qnum.AutoSize = true;
            qnum.BackColor = Color.Transparent;
            qnum.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qnum.ForeColor = SystemColors.ActiveCaptionText;
            qnum.Location = new Point(23, 57);
            qnum.Name = "qnum";
            qnum.Size = new Size(43, 29);
            qnum.TabIndex = 51;
            qnum.Text = "Q1";
            qnum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // qbody
            // 
            qbody.BorderStyle = BorderStyle.Fixed3D;
            qbody.Location = new Point(7, 134);
            qbody.Name = "qbody";
            qbody.Size = new Size(975, 360);
            qbody.TabIndex = 3;
            // 
            // qhead
            // 
            qhead.BorderStyle = BorderStyle.Fixed3D;
            qhead.Controls.Add(qh);
            qhead.Location = new Point(9, 3);
            qhead.Name = "qhead";
            qhead.Size = new Size(973, 125);
            qhead.TabIndex = 2;
            // 
            // qh
            // 
            qh.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            qh.AutoSize = true;
            qh.BackColor = Color.Transparent;
            qh.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qh.ForeColor = SystemColors.ActiveCaptionText;
            qh.Location = new Point(12, 57);
            qh.Name = "qh";
            qh.Size = new Size(106, 29);
            qh.TabIndex = 50;
            qh.Text = "Question";
            qh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // footer
            // 
            footer.BackColor = Color.Snow;
            footer.Controls.Add(next_btn);
            footer.Controls.Add(prev_btn);
            footer.Controls.Add(submit_btn);
            footer.Dock = DockStyle.Bottom;
            footer.Location = new Point(0, 619);
            footer.Name = "footer";
            footer.Size = new Size(1180, 101);
            footer.TabIndex = 49;
            // 
            // next_btn
            // 
            next_btn.Location = new Point(643, 24);
            next_btn.Name = "next_btn";
            next_btn.OverrideDefault.Back.Color1 = Color.Brown;
            next_btn.OverrideDefault.Back.Color2 = Color.Brown;
            next_btn.OverrideFocus.Back.Color1 = Color.Brown;
            next_btn.OverrideFocus.Back.Color2 = Color.Brown;
            next_btn.Size = new Size(73, 47);
            next_btn.StateCommon.Back.Color1 = Color.Brown;
            next_btn.StateCommon.Back.Color2 = Color.Brown;
            next_btn.StateCommon.Back.ColorAngle = 1F;
            next_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            next_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            next_btn.StateCommon.Border.ColorAngle = 1F;
            next_btn.StateCommon.Border.Rounding = 3F;
            next_btn.StateCommon.Border.Width = 2;
            next_btn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            next_btn.StateCommon.Content.LongText.Color2 = Color.White;
            next_btn.StateCommon.Content.ShortText.Color1 = Color.White;
            next_btn.StateCommon.Content.ShortText.Color2 = Color.White;
            next_btn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            next_btn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            next_btn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            next_btn.StateDisabled.Back.Color1 = Color.Brown;
            next_btn.StateDisabled.Back.Color2 = Color.Brown;
            next_btn.StateDisabled.Border.Rounding = 3F;
            next_btn.StateDisabled.Border.Width = 2;
            next_btn.StateNormal.Back.Color1 = Color.Brown;
            next_btn.StateNormal.Back.Color2 = Color.Brown;
            next_btn.StatePressed.Back.Color1 = Color.Maroon;
            next_btn.StatePressed.Back.Color2 = Color.Maroon;
            next_btn.StatePressed.Border.Rounding = 3F;
            next_btn.StatePressed.Border.Width = 5;
            next_btn.StateTracking.Back.Color1 = Color.Brown;
            next_btn.StateTracking.Back.Color2 = Color.Brown;
            next_btn.TabIndex = 45;
            next_btn.Values.DropDownArrowColor = Color.Empty;
            next_btn.Values.ImageTransparentColor = Color.White;
            next_btn.Values.Text = "Next";
            next_btn.Click += next_btn_Click;
            // 
            // prev_btn
            // 
            prev_btn.Location = new Point(566, 24);
            prev_btn.Name = "prev_btn";
            prev_btn.OverrideDefault.Back.Color1 = Color.Brown;
            prev_btn.OverrideDefault.Back.Color2 = Color.Brown;
            prev_btn.OverrideFocus.Back.Color1 = Color.Brown;
            prev_btn.OverrideFocus.Back.Color2 = Color.Brown;
            prev_btn.Size = new Size(71, 47);
            prev_btn.StateCommon.Back.Color1 = Color.Brown;
            prev_btn.StateCommon.Back.Color2 = Color.Brown;
            prev_btn.StateCommon.Back.ColorAngle = 1F;
            prev_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            prev_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            prev_btn.StateCommon.Border.ColorAngle = 1F;
            prev_btn.StateCommon.Border.Rounding = 3F;
            prev_btn.StateCommon.Border.Width = 2;
            prev_btn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            prev_btn.StateCommon.Content.LongText.Color2 = Color.White;
            prev_btn.StateCommon.Content.ShortText.Color1 = Color.White;
            prev_btn.StateCommon.Content.ShortText.Color2 = Color.White;
            prev_btn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prev_btn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            prev_btn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            prev_btn.StateDisabled.Back.Color1 = Color.Brown;
            prev_btn.StateDisabled.Back.Color2 = Color.Brown;
            prev_btn.StateDisabled.Border.Rounding = 3F;
            prev_btn.StateDisabled.Border.Width = 2;
            prev_btn.StateNormal.Back.Color1 = Color.Brown;
            prev_btn.StateNormal.Back.Color2 = Color.Brown;
            prev_btn.StatePressed.Back.Color1 = Color.Maroon;
            prev_btn.StatePressed.Back.Color2 = Color.Maroon;
            prev_btn.StatePressed.Border.Rounding = 3F;
            prev_btn.StatePressed.Border.Width = 5;
            prev_btn.StateTracking.Back.Color1 = Color.Brown;
            prev_btn.StateTracking.Back.Color2 = Color.Brown;
            prev_btn.TabIndex = 44;
            prev_btn.UseMnemonic = false;
            prev_btn.Values.DropDownArrowColor = Color.Empty;
            prev_btn.Values.ImageTransparentColor = Color.White;
            prev_btn.Values.Text = "Prev";
            prev_btn.Click += prev_btn_Click;
            // 
            // submit_btn
            // 
            submit_btn.Location = new Point(1008, 24);
            submit_btn.Name = "submit_btn";
            submit_btn.OverrideDefault.Back.Color1 = Color.Brown;
            submit_btn.OverrideDefault.Back.Color2 = Color.Brown;
            submit_btn.OverrideFocus.Back.Color1 = Color.Brown;
            submit_btn.OverrideFocus.Back.Color2 = Color.Brown;
            submit_btn.Size = new Size(138, 47);
            submit_btn.StateCommon.Back.Color1 = Color.Brown;
            submit_btn.StateCommon.Back.Color2 = Color.Brown;
            submit_btn.StateCommon.Back.ColorAngle = 1F;
            submit_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            submit_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            submit_btn.StateCommon.Border.ColorAngle = 1F;
            submit_btn.StateCommon.Border.Rounding = 3F;
            submit_btn.StateCommon.Border.Width = 2;
            submit_btn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            submit_btn.StateCommon.Content.LongText.Color2 = Color.White;
            submit_btn.StateCommon.Content.ShortText.Color1 = Color.White;
            submit_btn.StateCommon.Content.ShortText.Color2 = Color.White;
            submit_btn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submit_btn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            submit_btn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            submit_btn.StateDisabled.Back.Color1 = Color.Brown;
            submit_btn.StateDisabled.Back.Color2 = Color.Brown;
            submit_btn.StateDisabled.Border.Rounding = 3F;
            submit_btn.StateDisabled.Border.Width = 2;
            submit_btn.StateNormal.Back.Color1 = Color.Brown;
            submit_btn.StateNormal.Back.Color2 = Color.Brown;
            submit_btn.StatePressed.Back.Color1 = Color.Maroon;
            submit_btn.StatePressed.Back.Color2 = Color.Maroon;
            submit_btn.StatePressed.Border.Rounding = 3F;
            submit_btn.StatePressed.Border.Width = 5;
            submit_btn.StateTracking.Back.Color1 = Color.Brown;
            submit_btn.StateTracking.Back.Color2 = Color.Brown;
            submit_btn.TabIndex = 43;
            submit_btn.UseMnemonic = false;
            submit_btn.Values.DropDownArrowColor = Color.Empty;
            submit_btn.Values.ImageTransparentColor = Color.White;
            submit_btn.Values.Text = "Submit";
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 720);
            Controls.Add(footer);
            Controls.Add(main);
            Controls.Add(header);
            Name = "ExamForm";
            ShowIcon = false;
            Load += ExamForm_Load;
            header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            main.Panel1.ResumeLayout(false);
            main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)main).EndInit();
            main.ResumeLayout(false);
            qnav.ResumeLayout(false);
            qnav.PerformLayout();
            qhead.ResumeLayout(false);
            qhead.PerformLayout();
            footer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private System.Windows.Forms.Timer timer;
        private Panel header;
        private Label sd_name;
        private PictureBox pictureBox1;
        private Label logo;
        private SplitContainer main;
        private Panel qnav;
        private Panel qhead;
        private Panel footer;
        private Panel qbody;
        private Krypton.Toolkit.KryptonButton next_btn;
        private Krypton.Toolkit.KryptonButton prev_btn;
        private Krypton.Toolkit.KryptonButton submit_btn;
        private Label qnum;
        private Label qh;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Label timer_label;
    }
}