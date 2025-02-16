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
            footer = new GroupBox();
            prev_btn = new Krypton.Toolkit.KryptonButton();
            nxt_btn = new Krypton.Toolkit.KryptonButton();
            submit_btn = new Krypton.Toolkit.KryptonButton();
            header = new GroupBox();
            timerbtn = new Krypton.Toolkit.KryptonButton();
            main = new SplitContainer();
            label4 = new Label();
            materialScrollBar2 = new MaterialSkin.Controls.MaterialScrollBar();
            answersection = new GroupBox();
            label2 = new Label();
            headsection = new GroupBox();
            label1 = new Label();
            questionh = new Label();
            materialScrollBar1 = new MaterialSkin.Controls.MaterialScrollBar();
            timer = new System.Windows.Forms.Timer(components);
            footer.SuspendLayout();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)main).BeginInit();
            main.Panel1.SuspendLayout();
            main.Panel2.SuspendLayout();
            main.SuspendLayout();
            answersection.SuspendLayout();
            headsection.SuspendLayout();
            SuspendLayout();
            // 
            // footer
            // 
            footer.BackColor = Color.Snow;
            footer.Controls.Add(prev_btn);
            footer.Controls.Add(nxt_btn);
            footer.Controls.Add(submit_btn);
            footer.Location = new Point(0, 480);
            footer.Name = "footer";
            footer.Size = new Size(794, 146);
            footer.TabIndex = 36;
            footer.TabStop = false;
            // 
            // prev_btn
            // 
            prev_btn.Location = new Point(387, 51);
            prev_btn.Name = "prev_btn";
            prev_btn.OverrideDefault.Back.Color1 = Color.Brown;
            prev_btn.OverrideDefault.Back.Color2 = Color.Brown;
            prev_btn.OverrideFocus.Back.Color1 = Color.Brown;
            prev_btn.OverrideFocus.Back.Color2 = Color.Brown;
            prev_btn.Size = new Size(57, 28);
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
            prev_btn.TabIndex = 32;
            prev_btn.UseMnemonic = false;
            prev_btn.Values.DropDownArrowColor = Color.Empty;
            prev_btn.Values.ImageTransparentColor = Color.White;
            prev_btn.Values.Text = "Prev";
            prev_btn.Click += prev_btn_Click;
            // 
            // nxt_btn
            // 
            nxt_btn.Location = new Point(477, 51);
            nxt_btn.Name = "nxt_btn";
            nxt_btn.OverrideDefault.Back.Color1 = Color.Brown;
            nxt_btn.OverrideDefault.Back.Color2 = Color.Brown;
            nxt_btn.OverrideFocus.Back.Color1 = Color.Brown;
            nxt_btn.OverrideFocus.Back.Color2 = Color.Brown;
            nxt_btn.Size = new Size(57, 28);
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
            nxt_btn.TabIndex = 31;
            nxt_btn.UseMnemonic = false;
            nxt_btn.Values.DropDownArrowColor = Color.Empty;
            nxt_btn.Values.ImageTransparentColor = Color.White;
            nxt_btn.Values.Text = "Next";
            nxt_btn.Click += nxt_btn_Click;
            // 
            // submit_btn
            // 
            submit_btn.Location = new Point(652, 77);
            submit_btn.Name = "submit_btn";
            submit_btn.OverrideDefault.Back.Color1 = Color.Brown;
            submit_btn.OverrideDefault.Back.Color2 = Color.Brown;
            submit_btn.OverrideFocus.Back.Color1 = Color.Brown;
            submit_btn.OverrideFocus.Back.Color2 = Color.Brown;
            submit_btn.Size = new Size(123, 41);
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
            submit_btn.TabIndex = 29;
            submit_btn.UseMnemonic = false;
            submit_btn.Values.DropDownArrowColor = Color.Empty;
            submit_btn.Values.ImageTransparentColor = Color.White;
            submit_btn.Values.Text = "Submit";
            // 
            // header
            // 
            header.BackColor = Color.Brown;
            header.Controls.Add(timerbtn);
            header.Location = new Point(0, -1);
            header.Name = "header";
            header.Size = new Size(794, 121);
            header.TabIndex = 37;
            header.TabStop = false;
            // 
            // timerbtn
            // 
            timerbtn.Enabled = false;
            timerbtn.Location = new Point(27, 37);
            timerbtn.Name = "timerbtn";
            timerbtn.OverrideDefault.Back.Color1 = Color.Brown;
            timerbtn.OverrideDefault.Back.Color2 = Color.Brown;
            timerbtn.OverrideDefault.Content.ShortText.Color1 = Color.Black;
            timerbtn.OverrideDefault.Content.ShortText.Color2 = Color.Black;
            timerbtn.OverrideFocus.Back.Color1 = Color.Brown;
            timerbtn.OverrideFocus.Back.Color2 = Color.Brown;
            timerbtn.OverrideFocus.Content.ShortText.Color1 = Color.Black;
            timerbtn.OverrideFocus.Content.ShortText.Color2 = Color.Black;
            timerbtn.Size = new Size(395, 47);
            timerbtn.StateCommon.Back.Color1 = Color.WhiteSmoke;
            timerbtn.StateCommon.Back.Color2 = SystemColors.ButtonFace;
            timerbtn.StateCommon.Back.ColorAngle = 1F;
            timerbtn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            timerbtn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            timerbtn.StateCommon.Border.ColorAngle = 1F;
            timerbtn.StateCommon.Border.Rounding = 3F;
            timerbtn.StateCommon.Border.Width = 2;
            timerbtn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            timerbtn.StateCommon.Content.LongText.Color2 = Color.White;
            timerbtn.StateCommon.Content.ShortText.Color1 = Color.White;
            timerbtn.StateCommon.Content.ShortText.Color2 = Color.White;
            timerbtn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerbtn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            timerbtn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            timerbtn.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            timerbtn.StateDisabled.Back.Color2 = Color.WhiteSmoke;
            timerbtn.StateDisabled.Border.Rounding = 3F;
            timerbtn.StateDisabled.Border.Width = 2;
            timerbtn.StateDisabled.Content.ShortText.Color1 = Color.Black;
            timerbtn.StateDisabled.Content.ShortText.Color2 = Color.Black;
            timerbtn.StateNormal.Back.Color1 = Color.WhiteSmoke;
            timerbtn.StateNormal.Back.Color2 = Color.WhiteSmoke;
            timerbtn.StateNormal.Content.ShortText.Color1 = Color.Black;
            timerbtn.StateNormal.Content.ShortText.Color2 = Color.Black;
            timerbtn.StatePressed.Back.Color1 = Color.WhiteSmoke;
            timerbtn.StatePressed.Back.Color2 = Color.WhiteSmoke;
            timerbtn.StatePressed.Border.Rounding = 3F;
            timerbtn.StatePressed.Border.Width = 5;
            timerbtn.StatePressed.Content.ShortText.Color1 = Color.Black;
            timerbtn.StatePressed.Content.ShortText.Color2 = Color.Black;
            timerbtn.StateTracking.Back.Color1 = Color.Brown;
            timerbtn.StateTracking.Back.Color2 = Color.Brown;
            timerbtn.StateTracking.Content.ShortText.Color1 = Color.Black;
            timerbtn.StateTracking.Content.ShortText.Color2 = Color.Black;
            timerbtn.TabIndex = 30;
            timerbtn.UseMnemonic = false;
            timerbtn.Values.DropDownArrowColor = Color.Empty;
            timerbtn.Values.ImageTransparentColor = Color.White;
            timerbtn.Values.Text = "timer";
            // 
            // main
            // 
            main.BackColor = SystemColors.ButtonHighlight;
            main.BorderStyle = BorderStyle.Fixed3D;
            main.Location = new Point(0, 123);
            main.Name = "main";
            // 
            // main.Panel1
            // 
            main.Panel1.Controls.Add(label4);
            main.Panel1.Controls.Add(materialScrollBar2);
            // 
            // main.Panel2
            // 
            main.Panel2.Controls.Add(answersection);
            main.Panel2.Controls.Add(headsection);
            main.Panel2.Paint += splitContainer2_Panel2_Paint;
            main.Size = new Size(794, 364);
            main.SplitterDistance = 168;
            main.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 34);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 4;
            label4.Text = "Qnumber";
            // 
            // materialScrollBar2
            // 
            materialScrollBar2.Depth = 0;
            materialScrollBar2.Location = new Point(10, 21);
            materialScrollBar2.MouseState = MaterialSkin.MouseState.HOVER;
            materialScrollBar2.Name = "materialScrollBar2";
            materialScrollBar2.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Vertical;
            materialScrollBar2.ScrollbarSize = 9;
            materialScrollBar2.Size = new Size(9, 327);
            materialScrollBar2.TabIndex = 0;
            materialScrollBar2.Text = "materialScrollBar2";
            // 
            // answersection
            // 
            answersection.Controls.Add(label2);
            answersection.Location = new Point(8, 123);
            answersection.Name = "answersection";
            answersection.Size = new Size(598, 228);
            answersection.TabIndex = 4;
            answersection.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 58);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "answer";
            // 
            // headsection
            // 
            headsection.Controls.Add(label1);
            headsection.Controls.Add(questionh);
            headsection.Location = new Point(8, 16);
            headsection.Name = "headsection";
            headsection.Size = new Size(598, 92);
            headsection.TabIndex = 3;
            headsection.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 42);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "question";
            // 
            // questionh
            // 
            questionh.AutoSize = true;
            questionh.Location = new Point(20, 42);
            questionh.Name = "questionh";
            questionh.Size = new Size(0, 20);
            questionh.TabIndex = 0;
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
            timer.Tick += timer_Tick;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 621);
            Controls.Add(main);
            Controls.Add(header);
            Controls.Add(footer);
            Name = "ExamForm";
            ShowIcon = false;
            Load += exam_Load;
            footer.ResumeLayout(false);
            header.ResumeLayout(false);
            main.Panel1.ResumeLayout(false);
            main.Panel1.PerformLayout();
            main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)main).EndInit();
            main.ResumeLayout(false);
            answersection.ResumeLayout(false);
            answersection.PerformLayout();
            headsection.ResumeLayout(false);
            headsection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox footer;
        private Krypton.Toolkit.KryptonButton prev_btn;
        private Krypton.Toolkit.KryptonButton nxt_btn;
        private Krypton.Toolkit.KryptonButton submit_btn;
        private GroupBox header;
        private SplitContainer main;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private GroupBox answersection;
        private GroupBox headsection;
        private Label questionh;
        private Label label2;
        private Label label1;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar2;
        private System.Windows.Forms.Timer timer;
        private Label label4;
        private Krypton.Toolkit.KryptonButton timerbtn;
    }
}