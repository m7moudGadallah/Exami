using System.Drawing.Drawing2D;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(components);
            header = new Panel();
            timer_label = new Label();
            sd_name = new Label();
            logo = new Label();
            pictureBox1 = new PictureBox();
            main = new SplitContainer();
            qnav = new Panel();
            qbody = new Panel();
            qhead = new Panel();
            qh = new Label();
            footer = new Panel();
            pre_btn = new Krypton.Toolkit.KryptonButton();
            nxt_btn = new Krypton.Toolkit.KryptonButton();
            submit_btn = new Krypton.Toolkit.KryptonButton();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)main).BeginInit();
            main.Panel1.SuspendLayout();
            main.Panel2.SuspendLayout();
            main.SuspendLayout();
            qhead.SuspendLayout();
            footer.SuspendLayout();
            SuspendLayout();
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
            sd_name.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            qnav.Location = new Point(10, 3);
            qnav.Name = "qnav";
            qnav.Size = new Size(163, 491);
            qnav.TabIndex = 1;
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
            footer.Controls.Add(pre_btn);
            footer.Controls.Add(nxt_btn);
            footer.Controls.Add(submit_btn);
            footer.Dock = DockStyle.Bottom;
            footer.Location = new Point(0, 619);
            footer.Name = "footer";
            footer.Size = new Size(1180, 101);
            footer.TabIndex = 49;
            // 
            // pre_btn
            // 
            pre_btn.Location = new Point(488, 24);
            pre_btn.Name = "pre_btn";
            pre_btn.OverrideDefault.Back.Color1 = Color.Brown;
            pre_btn.OverrideDefault.Back.Color2 = Color.Brown;
            pre_btn.OverrideFocus.Back.Color1 = Color.Brown;
            pre_btn.OverrideFocus.Back.Color2 = Color.Brown;
            pre_btn.Size = new Size(81, 47);
            pre_btn.StateCommon.Back.Color1 = Color.Brown;
            pre_btn.StateCommon.Back.Color2 = Color.Brown;
            pre_btn.StateCommon.Back.ColorAngle = 1F;
            pre_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            pre_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            pre_btn.StateCommon.Border.ColorAngle = 1F;
            pre_btn.StateCommon.Border.Rounding = 3F;
            pre_btn.StateCommon.Border.Width = 2;
            pre_btn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            pre_btn.StateCommon.Content.LongText.Color2 = Color.White;
            pre_btn.StateCommon.Content.ShortText.Color1 = Color.White;
            pre_btn.StateCommon.Content.ShortText.Color2 = Color.White;
            pre_btn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pre_btn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            pre_btn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            pre_btn.StateDisabled.Back.Color1 = Color.Brown;
            pre_btn.StateDisabled.Back.Color2 = Color.Brown;
            pre_btn.StateDisabled.Border.Rounding = 3F;
            pre_btn.StateDisabled.Border.Width = 2;
            pre_btn.StateNormal.Back.Color1 = Color.Brown;
            pre_btn.StateNormal.Back.Color2 = Color.Brown;
            pre_btn.StatePressed.Back.Color1 = Color.Maroon;
            pre_btn.StatePressed.Back.Color2 = Color.Maroon;
            pre_btn.StatePressed.Border.Rounding = 3F;
            pre_btn.StatePressed.Border.Width = 5;
            pre_btn.StateTracking.Back.Color1 = Color.Brown;
            pre_btn.StateTracking.Back.Color2 = Color.Brown;
            pre_btn.TabIndex = 50;
            pre_btn.UseMnemonic = false;
            pre_btn.Values.DropDownArrowColor = Color.Empty;
            pre_btn.Values.ImageTransparentColor = Color.White;
            pre_btn.Values.Text = "Prev";
            pre_btn.Click += pre_btn_Click;
            // 
            // nxt_btn
            // 
            nxt_btn.Location = new Point(605, 24);
            nxt_btn.Name = "nxt_btn";
            nxt_btn.OverrideDefault.Back.Color1 = Color.Brown;
            nxt_btn.OverrideDefault.Back.Color2 = Color.Brown;
            nxt_btn.OverrideFocus.Back.Color1 = Color.Brown;
            nxt_btn.OverrideFocus.Back.Color2 = Color.Brown;
            nxt_btn.Size = new Size(81, 47);
            nxt_btn.StateCommon.Back.Color1 = Color.Brown;
            nxt_btn.StateCommon.Back.Color2 = Color.Brown;
            nxt_btn.StateCommon.Back.ColorAngle = 1F;
            nxt_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            nxt_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            nxt_btn.StateCommon.Border.ColorAngle = 1F;
            nxt_btn.StateCommon.Border.Rounding = 3F;
            nxt_btn.StateCommon.Border.Width = 2;
            nxt_btn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            nxt_btn.StateCommon.Content.LongText.Color2 = Color.White;
            nxt_btn.StateCommon.Content.ShortText.Color1 = Color.White;
            nxt_btn.StateCommon.Content.ShortText.Color2 = Color.White;
            nxt_btn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nxt_btn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            nxt_btn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            nxt_btn.StateDisabled.Back.Color1 = Color.Brown;
            nxt_btn.StateDisabled.Back.Color2 = Color.Brown;
            nxt_btn.StateDisabled.Border.Rounding = 3F;
            nxt_btn.StateDisabled.Border.Width = 2;
            nxt_btn.StateNormal.Back.Color1 = Color.Brown;
            nxt_btn.StateNormal.Back.Color2 = Color.Brown;
            nxt_btn.StatePressed.Back.Color1 = Color.Maroon;
            nxt_btn.StatePressed.Back.Color2 = Color.Maroon;
            nxt_btn.StatePressed.Border.Rounding = 3F;
            nxt_btn.StatePressed.Border.Width = 5;
            nxt_btn.StateTracking.Back.Color1 = Color.Brown;
            nxt_btn.StateTracking.Back.Color2 = Color.Brown;
            nxt_btn.TabIndex = 50;
            nxt_btn.UseMnemonic = false;
            nxt_btn.Values.DropDownArrowColor = Color.Empty;
            nxt_btn.Values.ImageTransparentColor = Color.White;
            nxt_btn.Values.Text = "Next";
            nxt_btn.Click += nxt_btn_Click;
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
            submit_btn.Click += submit_btn_Click;
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
            qhead.ResumeLayout(false);
            qhead.PerformLayout();
            footer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private Krypton.Toolkit.KryptonButton submit_btn;
        private Label qh;
        private Label timer_label;
        private Krypton.Toolkit.KryptonButton pre_btn;
        private Krypton.Toolkit.KryptonButton nxt_btn;
    }
}