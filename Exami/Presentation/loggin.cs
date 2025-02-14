namespace Presentation
{
    public partial class loggin : Form
    {
        public loggin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonBorderEdge2 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonBorderEdge3 = new Krypton.Toolkit.KryptonBorderEdge();
            box2 = new Krypton.Toolkit.KryptonBorderEdge();
            groupBox1 = new GroupBox();
            kryptonBorderEdge4 = new Krypton.Toolkit.KryptonBorderEdge();
            signin_btn = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            pass_input = new TextBox();
            ribbon = new Krypton.Toolkit.KryptonTextBox();
            groupBox2 = new GroupBox();
            kryptonLinkLabel2 = new Krypton.Toolkit.KryptonLinkLabel();
            help_link = new Krypton.Toolkit.KryptonLinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.ForeColor = Color.White;
            materialLabel1.Location = new Point(158, 90);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(50, 24);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Email";
            materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
            materialLabel1.Click += materialLabel1_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel2.Location = new Point(158, 191);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(89, 24);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Password";
            materialLabel2.Click += materialLabel2_Click;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.GridHeaderRowSheet;
            kryptonBorderEdge1.Cursor = Cursors.No;
            kryptonBorderEdge1.Enabled = false;
            kryptonBorderEdge1.Location = new Point(185, 130);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365SilverDarkMode;
            kryptonBorderEdge1.Size = new Size(543, 4);
            kryptonBorderEdge1.StateCommon.Color2 = Color.Silver;
            kryptonBorderEdge1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonBorderEdge1.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            kryptonBorderEdge1.StateCommon.Width = 4;
            kryptonBorderEdge1.Text = "box1";
            kryptonBorderEdge1.ToolTipValues.ImageTransparentColor = Color.FromArgb(64, 64, 64);
            kryptonBorderEdge1.ToolTipValues.ToolTipPosition.PlacementRectangle = new Rectangle(3, 3, 3, 3);
            // 
            // kryptonBorderEdge2
            // 
            kryptonBorderEdge2.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.GridHeaderRowSheet;
            kryptonBorderEdge2.Cursor = Cursors.No;
            kryptonBorderEdge2.Location = new Point(-4, 449);
            kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            kryptonBorderEdge2.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365SilverDarkMode;
            kryptonBorderEdge2.Size = new Size(552, 5);
            kryptonBorderEdge2.StateCommon.Color2 = Color.Silver;
            kryptonBorderEdge2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonBorderEdge2.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            kryptonBorderEdge2.StateCommon.Width = 5;
            kryptonBorderEdge2.Text = "box3";
            kryptonBorderEdge2.ToolTipValues.ImageTransparentColor = Color.FromArgb(64, 64, 64);
            kryptonBorderEdge2.ToolTipValues.ToolTipPosition.PlacementRectangle = new Rectangle(3, 3, 3, 3);
            // 
            // kryptonBorderEdge3
            // 
            kryptonBorderEdge3.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.GridHeaderRowSheet;
            kryptonBorderEdge3.Cursor = Cursors.No;
            kryptonBorderEdge3.Enabled = false;
            kryptonBorderEdge3.Location = new Point(-3, -10);
            kryptonBorderEdge3.Name = "kryptonBorderEdge3";
            kryptonBorderEdge3.Orientation = Orientation.Vertical;
            kryptonBorderEdge3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlackDarkMode;
            kryptonBorderEdge3.Size = new Size(5, 464);
            kryptonBorderEdge3.StateCommon.Color2 = Color.Silver;
            kryptonBorderEdge3.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonBorderEdge3.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            kryptonBorderEdge3.StateCommon.Width = 5;
            kryptonBorderEdge3.Text = "box4";
            kryptonBorderEdge3.ToolTipValues.ImageTransparentColor = Color.FromArgb(64, 64, 64);
            kryptonBorderEdge3.ToolTipValues.ToolTipPosition.PlacementRectangle = new Rectangle(3, 3, 3, 3);
            // 
            // box2
            // 
            box2.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.GridHeaderRowSheet;
            box2.Cursor = Cursors.No;
            box2.Enabled = false;
            box2.Location = new Point(728, 130);
            box2.Name = "box2";
            box2.Orientation = Orientation.Vertical;
            box2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlackDarkMode;
            box2.Size = new Size(5, 458);
            box2.StateCommon.Color2 = Color.White;
            box2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            box2.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            box2.StateCommon.Width = 5;
            box2.Text = "box2";
            box2.ToolTipValues.ImageTransparentColor = Color.FromArgb(64, 64, 64);
            box2.ToolTipValues.ToolTipPosition.PlacementRectangle = new Rectangle(3, 3, 3, 3);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(kryptonBorderEdge4);
            groupBox1.Controls.Add(signin_btn);
            groupBox1.Controls.Add(kryptonTextBox2);
            groupBox1.Controls.Add(kryptonTextBox1);
            groupBox1.Controls.Add(kryptonBorderEdge3);
            groupBox1.Controls.Add(kryptonBorderEdge2);
            groupBox1.Controls.Add(pass_input);
            groupBox1.Controls.Add(materialLabel1);
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Location = new Point(185, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 454);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // kryptonBorderEdge4
            // 
            kryptonBorderEdge4.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.GridHeaderRowSheet;
            kryptonBorderEdge4.Cursor = Cursors.No;
            kryptonBorderEdge4.Location = new Point(-3, 1);
            kryptonBorderEdge4.Name = "kryptonBorderEdge4";
            kryptonBorderEdge4.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365SilverDarkMode;
            kryptonBorderEdge4.Size = new Size(546, 11);
            kryptonBorderEdge4.StateCommon.Color1 = Color.Brown;
            kryptonBorderEdge4.StateCommon.Color2 = Color.Brown;
            kryptonBorderEdge4.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonBorderEdge4.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            kryptonBorderEdge4.StateCommon.Width = 11;
            kryptonBorderEdge4.Text = "box3";
            kryptonBorderEdge4.ToolTipValues.ImageTransparentColor = Color.FromArgb(64, 64, 64);
            kryptonBorderEdge4.ToolTipValues.ToolTipPosition.PlacementRectangle = new Rectangle(3, 3, 3, 3);
            // 
            // signin_btn
            // 
            signin_btn.Location = new Point(205, 298);
            signin_btn.Name = "signin_btn";
            signin_btn.OverrideDefault.Back.Color1 = Color.Brown;
            signin_btn.OverrideDefault.Back.Color2 = Color.Brown;
            signin_btn.OverrideFocus.Back.Color1 = Color.Brown;
            signin_btn.OverrideFocus.Back.Color2 = Color.Brown;
            signin_btn.Size = new Size(138, 47);
            signin_btn.StateCommon.Back.Color1 = Color.Brown;
            signin_btn.StateCommon.Back.Color2 = Color.Brown;
            signin_btn.StateCommon.Back.ColorAngle = 1F;
            signin_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            signin_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            signin_btn.StateCommon.Border.ColorAngle = 1F;
            signin_btn.StateCommon.Border.Rounding = 3F;
            signin_btn.StateCommon.Border.Width = 2;
            signin_btn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            signin_btn.StateCommon.Content.LongText.Color2 = Color.White;
            signin_btn.StateCommon.Content.ShortText.Color1 = Color.White;
            signin_btn.StateCommon.Content.ShortText.Color2 = Color.White;
            signin_btn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signin_btn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            signin_btn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            signin_btn.StateDisabled.Back.Color1 = Color.Brown;
            signin_btn.StateDisabled.Back.Color2 = Color.Brown;
            signin_btn.StateDisabled.Border.Rounding = 3F;
            signin_btn.StateDisabled.Border.Width = 2;
            signin_btn.StateNormal.Back.Color1 = Color.Brown;
            signin_btn.StateNormal.Back.Color2 = Color.Brown;
            signin_btn.StatePressed.Back.Color1 = Color.Maroon;
            signin_btn.StatePressed.Back.Color2 = Color.Maroon;
            signin_btn.StatePressed.Border.Rounding = 3F;
            signin_btn.StatePressed.Border.Width = 5;
            signin_btn.StateTracking.Back.Color1 = Color.Brown;
            signin_btn.StateTracking.Back.Color2 = Color.Brown;
            signin_btn.TabIndex = 24;
            signin_btn.UseMnemonic = false;
            signin_btn.Values.DropDownArrowColor = Color.Empty;
            signin_btn.Values.ImageTransparentColor = Color.White;
            signin_btn.Values.Text = "Login";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Cursor = Cursors.IBeam;
            kryptonTextBox2.Location = new Point(158, 130);
            kryptonTextBox2.MaxLength = 16;
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(250, 29);
            kryptonTextBox2.StateActive.Border.Color1 = Color.Black;
            kryptonTextBox2.StateActive.Border.Color2 = Color.Black;
            kryptonTextBox2.StateActive.Border.Width = 1;
            kryptonTextBox2.StateActive.Content.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox2.StateCommon.Border.Color1 = Color.Black;
            kryptonTextBox2.StateCommon.Border.Color2 = Color.Black;
            kryptonTextBox2.StateCommon.Border.Rounding = 3F;
            kryptonTextBox2.StateCommon.Border.Width = 0;
            kryptonTextBox2.TabIndex = 21;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Cursor = Cursors.IBeam;
            kryptonTextBox1.Location = new Point(158, 226);
            kryptonTextBox1.MaxLength = 16;
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.PasswordChar = '*';
            kryptonTextBox1.Size = new Size(250, 29);
            kryptonTextBox1.StateActive.Border.Color1 = Color.Black;
            kryptonTextBox1.StateActive.Border.Color2 = Color.Black;
            kryptonTextBox1.StateActive.Border.Width = 1;
            kryptonTextBox1.StateActive.Content.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.StateCommon.Border.Color1 = Color.Black;
            kryptonTextBox1.StateCommon.Border.Color2 = Color.Black;
            kryptonTextBox1.StateCommon.Border.Rounding = 3F;
            kryptonTextBox1.StateCommon.Border.Width = 0;
            kryptonTextBox1.TabIndex = 20;
            kryptonTextBox1.TextChanged += kryptonTextBox1_TextChanged;
            // 
            // pass_input
            // 
            pass_input.Cursor = Cursors.IBeam;
            pass_input.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass_input.Location = new Point(158, 226);
            pass_input.Name = "pass_input";
            pass_input.Size = new Size(250, 27);
            pass_input.TabIndex = 1;
            // 
            // ribbon
            // 
            ribbon.Cursor = Cursors.No;
            ribbon.Dock = DockStyle.Top;
            ribbon.Enabled = false;
            ribbon.Location = new Point(0, 0);
            ribbon.MaxLength = 3;
            ribbon.Name = "ribbon";
            ribbon.ReadOnly = true;
            ribbon.Size = new Size(889, 44);
            ribbon.StateActive.Border.Color1 = Color.Black;
            ribbon.StateActive.Border.Color2 = Color.Black;
            ribbon.StateActive.Border.Width = 1;
            ribbon.StateActive.Content.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ribbon.StateCommon.Back.Color1 = Color.Brown;
            ribbon.StateCommon.Border.Color1 = Color.Black;
            ribbon.StateCommon.Border.Color2 = Color.Black;
            ribbon.StateCommon.Border.Rounding = 3F;
            ribbon.StateCommon.Border.Width = 0;
            ribbon.StateCommon.Content.Color1 = Color.White;
            ribbon.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ribbon.StateCommon.Content.Padding = new Padding(10);
            ribbon.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ribbon.TabIndex = 27;
            ribbon.Text = "Exami";
            ribbon.TextAlign = HorizontalAlignment.Center;
            ribbon.TextChanged += kryptonTextBox3_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(kryptonLinkLabel2);
            groupBox2.Controls.Add(help_link);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(889, 718);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // kryptonLinkLabel2
            // 
            kryptonLinkLabel2.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
            kryptonLinkLabel2.Location = new Point(17, 670);
            kryptonLinkLabel2.Name = "kryptonLinkLabel2";
            kryptonLinkLabel2.OverrideFocus.Padding = new Padding(3);
            kryptonLinkLabel2.OverrideFocus.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonLinkLabel2.OverrideFocus.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonLinkLabel2.Size = new Size(170, 27);
            kryptonLinkLabel2.StateCommon.Padding = new Padding(3);
            kryptonLinkLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonLinkLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonLinkLabel2.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonLinkLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLinkLabel2.StateDisabled.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonLinkLabel2.StateDisabled.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonLinkLabel2.StateNormal.Padding = new Padding(3);
            kryptonLinkLabel2.StateNormal.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonLinkLabel2.StateNormal.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonLinkLabel2.StateNormal.ShortText.ColorAngle = 1F;
            kryptonLinkLabel2.StateNormal.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonLinkLabel2.StateNormal.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLinkLabel2.TabIndex = 20;
            kryptonLinkLabel2.Values.Text = "Contact Your Institute";
            // 
            // help_link
            // 
            help_link.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
            help_link.Location = new Point(730, 670);
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
            help_link.TabIndex = 0;
            help_link.Values.Text = "Help Centre";
            // 
            // loggin
            // 
            BackColor = Color.White;
            ClientSize = new Size(889, 718);
            Controls.Add(ribbon);
            Controls.Add(kryptonBorderEdge1);
            Controls.Add(box2);
            Controls.Add(groupBox2);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "loggin";
            ShowIcon = false;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, Krypton.Toolkit.ColorEventArgs e)
        {

        }

        private void kryptonGroupBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        private Krypton.Toolkit.KryptonBorderEdge box2;
        private GroupBox groupBox1;
        private TextBox pass_input;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox ribbon;
        private GroupBox groupBox2;
        private Krypton.Toolkit.KryptonLinkLabel help_link;
        private Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel2;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge4;
        private Krypton.Toolkit.KryptonButton signin_btn;

        private void email_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ribbon_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}
