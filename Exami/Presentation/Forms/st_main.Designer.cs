using MaterialSkin;
using MaterialColorScheme = MaterialSkin.ColorScheme;

namespace Presentation
{
    partial class st_main
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
        public st_main()
        {
            InitializeComponent();
        }

        private void st_main_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.Pink200,
                TextShade.WHITE);
            LoadExams();
            DisplayExams(_exams);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            header = new Krypton.Toolkit.KryptonTextBox();
            contactlink = new Krypton.Toolkit.KryptonLinkLabel();
            help_link = new Krypton.Toolkit.KryptonLinkLabel();
            done_btn = new Krypton.Toolkit.KryptonButton();
            inqueue_btn = new Krypton.Toolkit.KryptonButton();
            allexams_btn = new Krypton.Toolkit.KryptonButton();
            view_btn = new Krypton.Toolkit.KryptonButton();
            examname = new Krypton.Toolkit.KryptonButton();
            duration = new Krypton.Toolkit.KryptonButton();
            date = new Krypton.Toolkit.KryptonButton();
            content = new FlowLayoutPanel();
            name = new Label();
            d = new Label();
            du = new Label();
            view = new Krypton.Toolkit.KryptonButton();
            content.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Cursor = Cursors.No;
            header.Dock = DockStyle.Top;
            header.Enabled = false;
            header.Location = new Point(0, 0);
            header.MaxLength = 3;
            header.Name = "header";
            header.ReadOnly = true;
            header.Size = new Size(893, 44);
            header.StateActive.Border.Color1 = Color.Black;
            header.StateActive.Border.Color2 = Color.Black;
            header.StateActive.Border.Width = 1;
            header.StateActive.Content.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            header.StateCommon.Back.Color1 = Color.Brown;
            header.StateCommon.Border.Color1 = Color.Black;
            header.StateCommon.Border.Color2 = Color.Black;
            header.StateCommon.Border.Rounding = 3F;
            header.StateCommon.Border.Width = 0;
            header.StateCommon.Content.Color1 = Color.White;
            header.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header.StateCommon.Content.Padding = new Padding(10);
            header.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            header.TabIndex = 39;
            header.Text = "Exami";
            header.TextAlign = HorizontalAlignment.Center;
            // 
            // contactlink
            // 
            contactlink.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
            contactlink.Location = new Point(23, 666);
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
            help_link.Location = new Point(771, 666);
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
            done_btn.Location = new Point(556, 141);
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
            inqueue_btn.Location = new Point(225, 141);
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
            allexams_btn.Location = new Point(390, 141);
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
            allexams_btn.Click += allexams_btn_Click;
            // 
            // view_btn
            // 
            view_btn.Location = new Point(0, 0);
            view_btn.Name = "view_btn";
            view_btn.Size = new Size(90, 25);
            view_btn.TabIndex = 0;
            // 
            // examname
            // 
            examname.Location = new Point(0, 0);
            examname.Name = "examname";
            examname.Size = new Size(90, 25);
            examname.TabIndex = 0;
            // 
            // duration
            // 
            duration.Enabled = false;
            duration.Location = new Point(234, 45);
            duration.Name = "duration";
            duration.OverrideDefault.Back.Color1 = Color.Brown;
            duration.OverrideDefault.Back.Color2 = Color.Brown;
            duration.OverrideFocus.Back.Color1 = Color.Brown;
            duration.OverrideFocus.Back.Color2 = Color.Brown;
            duration.Size = new Size(138, 47);
            duration.StateCommon.Back.Color1 = Color.Brown;
            duration.StateCommon.Back.Color2 = Color.Brown;
            duration.StateCommon.Back.ColorAngle = 1F;
            duration.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            duration.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            duration.StateCommon.Border.ColorAngle = 1F;
            duration.StateCommon.Border.Rounding = 3F;
            duration.StateCommon.Border.Width = 2;
            duration.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            duration.StateCommon.Content.LongText.Color2 = Color.White;
            duration.StateCommon.Content.ShortText.Color1 = Color.White;
            duration.StateCommon.Content.ShortText.Color2 = Color.White;
            duration.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duration.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            duration.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            duration.StateDisabled.Back.Color1 = Color.Brown;
            duration.StateDisabled.Back.Color2 = Color.Brown;
            duration.StateDisabled.Border.Rounding = 3F;
            duration.StateDisabled.Border.Width = 2;
            duration.StateDisabled.Content.ShortText.Color1 = Color.White;
            duration.StateDisabled.Content.ShortText.Color2 = Color.White;
            duration.StateNormal.Back.Color1 = Color.Brown;
            duration.StateNormal.Back.Color2 = Color.Brown;
            duration.StatePressed.Back.Color1 = Color.Maroon;
            duration.StatePressed.Back.Color2 = Color.Maroon;
            duration.StatePressed.Border.Rounding = 3F;
            duration.StatePressed.Border.Width = 5;
            duration.StateTracking.Back.Color1 = Color.Brown;
            duration.StateTracking.Back.Color2 = Color.Brown;
            duration.TabIndex = 27;
            duration.UseMnemonic = false;
            duration.Values.DropDownArrowColor = Color.Empty;
            duration.Values.ImageTransparentColor = Color.White;
            // 
            // date
            // 
            date.Enabled = false;
            date.Location = new Point(455, 45);
            date.Name = "date";
            date.OverrideDefault.Back.Color1 = Color.Brown;
            date.OverrideDefault.Back.Color2 = Color.Brown;
            date.OverrideFocus.Back.Color1 = Color.Brown;
            date.OverrideFocus.Back.Color2 = Color.Brown;
            date.Size = new Size(138, 47);
            date.StateCommon.Back.Color1 = Color.Brown;
            date.StateCommon.Back.Color2 = Color.Brown;
            date.StateCommon.Back.ColorAngle = 1F;
            date.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            date.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            date.StateCommon.Border.ColorAngle = 1F;
            date.StateCommon.Border.Rounding = 3F;
            date.StateCommon.Border.Width = 2;
            date.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            date.StateCommon.Content.LongText.Color2 = Color.White;
            date.StateCommon.Content.ShortText.Color1 = Color.White;
            date.StateCommon.Content.ShortText.Color2 = Color.White;
            date.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            date.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            date.StateDisabled.Back.Color1 = Color.Brown;
            date.StateDisabled.Back.Color2 = Color.Brown;
            date.StateDisabled.Border.Rounding = 3F;
            date.StateDisabled.Border.Width = 2;
            date.StateDisabled.Content.ShortText.Color1 = Color.White;
            date.StateDisabled.Content.ShortText.Color2 = Color.White;
            date.StateNormal.Back.Color1 = Color.Brown;
            date.StateNormal.Back.Color2 = Color.Brown;
            date.StatePressed.Back.Color1 = Color.Maroon;
            date.StatePressed.Back.Color2 = Color.Maroon;
            date.StatePressed.Border.Rounding = 3F;
            date.StatePressed.Border.Width = 5;
            date.StateTracking.Back.Color1 = Color.Brown;
            date.StateTracking.Back.Color2 = Color.Brown;
            date.TabIndex = 28;
            date.UseMnemonic = false;
            date.Values.DropDownArrowColor = Color.Empty;
            date.Values.ImageTransparentColor = Color.White;
            // 
            // content
            // 
            content.AllowDrop = true;
            content.AutoSize = true;
            content.Controls.Add(name);
            content.Controls.Add(d);
            content.Controls.Add(du);
            content.Controls.Add(view);
            content.Location = new Point(73, 283);
            content.Name = "content";
            content.Size = new Size(753, 59);
            content.TabIndex = 45;
            content.WrapContents = false;
            // 
            // name
            // 
            name.AccessibleRole = AccessibleRole.Grouping;
            name.BackColor = Color.Brown;
            name.BorderStyle = BorderStyle.Fixed3D;
            name.FlatStyle = FlatStyle.Popup;
            content.SetFlowBreak(name, true);
            name.ForeColor = Color.White;
            name.Location = new Point(5, 5);
            name.Margin = new Padding(5);
            name.Name = "name";
            name.Padding = new Padding(10);
            name.Size = new Size(181, 47);
            name.TabIndex = 0;
            name.Text = "name";
            name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // d
            // 
            d.AccessibleRole = AccessibleRole.Grouping;
            d.BackColor = Color.Brown;
            d.BorderStyle = BorderStyle.Fixed3D;
            d.FlatStyle = FlatStyle.Popup;
            content.SetFlowBreak(d, true);
            d.ForeColor = Color.White;
            d.Location = new Point(196, 5);
            d.Margin = new Padding(5);
            d.Name = "d";
            d.Padding = new Padding(10);
            d.Size = new Size(181, 47);
            d.TabIndex = 1;
            d.Text = "duration";
            d.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // du
            // 
            du.AccessibleRole = AccessibleRole.Grouping;
            du.BackColor = Color.Brown;
            du.BorderStyle = BorderStyle.Fixed3D;
            du.FlatStyle = FlatStyle.Popup;
            content.SetFlowBreak(du, true);
            du.ForeColor = Color.White;
            du.Location = new Point(387, 5);
            du.Margin = new Padding(5);
            du.Name = "du";
            du.Padding = new Padding(10);
            du.Size = new Size(181, 47);
            du.TabIndex = 2;
            du.Text = "date";
            du.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // view
            // 
            view.Location = new Point(578, 5);
            view.Margin = new Padding(5);
            view.Name = "view";
            view.OverrideDefault.Back.Color1 = Color.Brown;
            view.OverrideDefault.Back.Color2 = Color.Brown;
            view.OverrideFocus.Back.Color1 = Color.Brown;
            view.OverrideFocus.Back.Color2 = Color.Brown;
            view.Size = new Size(170, 47);
            view.StateCommon.Back.Color1 = Color.Brown;
            view.StateCommon.Back.Color2 = Color.Brown;
            view.StateCommon.Back.ColorAngle = 1F;
            view.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            view.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            view.StateCommon.Border.ColorAngle = 1F;
            view.StateCommon.Border.Rounding = 3F;
            view.StateCommon.Border.Width = 2;
            view.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            view.StateCommon.Content.LongText.Color2 = Color.White;
            view.StateCommon.Content.ShortText.Color1 = Color.White;
            view.StateCommon.Content.ShortText.Color2 = Color.White;
            view.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            view.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            view.StateDisabled.Back.Color1 = Color.Brown;
            view.StateDisabled.Back.Color2 = Color.Brown;
            view.StateDisabled.Border.Rounding = 3F;
            view.StateDisabled.Border.Width = 2;
            view.StateNormal.Back.Color1 = Color.Brown;
            view.StateNormal.Back.Color2 = Color.Brown;
            view.StatePressed.Back.Color1 = Color.Maroon;
            view.StatePressed.Back.Color2 = Color.Maroon;
            view.StatePressed.Border.Rounding = 3F;
            view.StatePressed.Border.Width = 5;
            view.StateTracking.Back.Color1 = Color.Brown;
            view.StateTracking.Back.Color2 = Color.Brown;
            view.TabIndex = 45;
            view.UseMnemonic = false;
            view.Values.DropDownArrowColor = Color.Empty;
            view.Values.ImageTransparentColor = Color.White;
            view.Values.Text = "view";
            view.Click += view_Click;
            // 
            // st_main
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(893, 722);
            Controls.Add(content);
            Controls.Add(done_btn);
            Controls.Add(inqueue_btn);
            Controls.Add(allexams_btn);
            Controls.Add(help_link);
            Controls.Add(contactlink);
            Controls.Add(header);
            HelpButton = true;
            Name = "st_main";
            ShowIcon = false;
            Load += st_main_Load;
            content.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox header;
        private Krypton.Toolkit.KryptonLinkLabel contactlink;
        private Krypton.Toolkit.KryptonLinkLabel help_link;
        private Krypton.Toolkit.KryptonButton done_btn;
        private Krypton.Toolkit.KryptonButton inqueue_btn;
        private Krypton.Toolkit.KryptonButton allexams_btn;
        private Krypton.Toolkit.KryptonButton view;
        private Krypton.Toolkit.KryptonButton examname;
        private Krypton.Toolkit.KryptonButton duration;
        private Krypton.Toolkit.KryptonButton date;
        private Krypton.Toolkit.KryptonButton view_btn;
        private FlowLayoutPanel content;
        private Label name;
        private Label d;
        private Label du;
        private Label label3;
    }
}