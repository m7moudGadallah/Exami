namespace Presentation.Forms
{
    partial class Instruction
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
            header = new Panel();
            instuct = new Label();
            sd_name = new Label();
            pictureBox1 = new PictureBox();
            footer = new Panel();
            help_link = new Krypton.Toolkit.KryptonLinkLabel();
            contactlink = new Krypton.Toolkit.KryptonLinkLabel();
            main = new MaterialSkin.Controls.MaterialCard();
            start_btn = new Krypton.Toolkit.KryptonButton();
            ins_txt = new Label();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            footer.SuspendLayout();
            main.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.Brown;
            header.Controls.Add(instuct);
            header.Controls.Add(sd_name);
            header.Controls.Add(pictureBox1);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1033, 109);
            header.TabIndex = 47;
            // 
            // instuct
            // 
            instuct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            instuct.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instuct.ForeColor = SystemColors.ButtonHighlight;
            instuct.Location = new Point(394, 0);
            instuct.Name = "instuct";
            instuct.Size = new Size(245, 109);
            instuct.TabIndex = 50;
            instuct.Text = "Instructions";
            instuct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sd_name
            // 
            sd_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sd_name.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sd_name.ForeColor = SystemColors.ButtonHighlight;
            sd_name.Location = new Point(636, 0);
            sd_name.Name = "sd_name";
            sd_name.Size = new Size(276, 109);
            sd_name.TabIndex = 49;
            sd_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(905, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 109);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // footer
            // 
            footer.BackColor = Color.Snow;
            footer.Controls.Add(help_link);
            footer.Controls.Add(contactlink);
            footer.Dock = DockStyle.Bottom;
            footer.Location = new Point(0, 678);
            footer.Name = "footer";
            footer.Size = new Size(1033, 101);
            footer.TabIndex = 48;
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
            // main
            // 
            main.BackColor = Color.FromArgb(255, 255, 255);
            main.BorderStyle = BorderStyle.Fixed3D;
            main.Controls.Add(start_btn);
            main.Controls.Add(ins_txt);
            main.Depth = 0;
            main.ForeColor = Color.FromArgb(222, 0, 0, 0);
            main.Location = new Point(30, 131);
            main.Margin = new Padding(14);
            main.MouseState = MaterialSkin.MouseState.HOVER;
            main.Name = "main";
            main.Padding = new Padding(14);
            main.Size = new Size(882, 525);
            main.TabIndex = 53;
            // 
            // start_btn
            // 
            start_btn.Location = new Point(706, 457);
            start_btn.Name = "start_btn";
            start_btn.OverrideDefault.Back.Color1 = Color.Brown;
            start_btn.OverrideDefault.Back.Color2 = Color.Brown;
            start_btn.OverrideFocus.Back.Color1 = Color.Brown;
            start_btn.OverrideFocus.Back.Color2 = Color.Brown;
            start_btn.Size = new Size(138, 47);
            start_btn.StateCommon.Back.Color1 = Color.Brown;
            start_btn.StateCommon.Back.Color2 = Color.Brown;
            start_btn.StateCommon.Back.ColorAngle = 1F;
            start_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            start_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            start_btn.StateCommon.Border.ColorAngle = 1F;
            start_btn.StateCommon.Border.Rounding = 3F;
            start_btn.StateCommon.Border.Width = 2;
            start_btn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            start_btn.StateCommon.Content.LongText.Color2 = Color.White;
            start_btn.StateCommon.Content.ShortText.Color1 = Color.White;
            start_btn.StateCommon.Content.ShortText.Color2 = Color.White;
            start_btn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start_btn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            start_btn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            start_btn.StateDisabled.Back.Color1 = Color.Brown;
            start_btn.StateDisabled.Back.Color2 = Color.Brown;
            start_btn.StateDisabled.Border.Rounding = 3F;
            start_btn.StateDisabled.Border.Width = 2;
            start_btn.StateNormal.Back.Color1 = Color.Brown;
            start_btn.StateNormal.Back.Color2 = Color.Brown;
            start_btn.StatePressed.Back.Color1 = Color.Maroon;
            start_btn.StatePressed.Back.Color2 = Color.Maroon;
            start_btn.StatePressed.Border.Rounding = 3F;
            start_btn.StatePressed.Border.Width = 5;
            start_btn.StateTracking.Back.Color1 = Color.Brown;
            start_btn.StateTracking.Back.Color2 = Color.Brown;
            start_btn.TabIndex = 45;
            start_btn.UseMnemonic = false;
            start_btn.Values.DropDownArrowColor = Color.Empty;
            start_btn.Values.ImageTransparentColor = Color.White;
            start_btn.Values.Text = "Start";
            start_btn.Click += start_btn_Click;
            // 
            // ins_txt
            // 
            ins_txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ins_txt.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ins_txt.ForeColor = SystemColors.ActiveCaptionText;
            ins_txt.ImageAlign = ContentAlignment.MiddleRight;
            ins_txt.Location = new Point(17, 18);
            ins_txt.Name = "ins_txt";
            ins_txt.Size = new Size(638, 486);
            ins_txt.TabIndex = 1;
            ins_txt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Instruction
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1033, 779);
            Controls.Add(main);
            Controls.Add(footer);
            Controls.Add(header);
            Name = "Instruction";
            Text = "Instruction";
            header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            footer.ResumeLayout(false);
            footer.PerformLayout();
            main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label sd_name;
        private PictureBox pictureBox1;
        private Panel footer;
        private Krypton.Toolkit.KryptonLinkLabel help_link;
        private Krypton.Toolkit.KryptonLinkLabel contactlink;
        private Label instuct;
        private MaterialSkin.Controls.MaterialCard main;
        private Label ins_txt;
        private Krypton.Toolkit.KryptonButton start_btn;
    }
}