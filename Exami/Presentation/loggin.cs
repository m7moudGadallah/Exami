using System.Diagnostics;
using Entities;
using Services.DTOs;
using Services.Services;
using Utilities.Exceptoins;
namespace Presentation
{
    public partial class loggin : Form
    {
        #region componnents intialzation
        public loggin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            email_label = new MaterialSkin.Controls.MaterialLabel();
            pass_txt_box = new MaterialSkin.Controls.MaterialLabel();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonBorderEdge2 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonBorderEdge3 = new Krypton.Toolkit.KryptonBorderEdge();
            box2 = new Krypton.Toolkit.KryptonBorderEdge();
            groupBox1 = new GroupBox();
            kryptonBorderEdge4 = new Krypton.Toolkit.KryptonBorderEdge();
            login_btn = new Krypton.Toolkit.KryptonButton();
            email_txt_box = new Krypton.Toolkit.KryptonTextBox();
            pass_txt = new Krypton.Toolkit.KryptonTextBox();
            pass_input = new TextBox();
            header = new Krypton.Toolkit.KryptonTextBox();
            groupBox2 = new GroupBox();
            kryptonLinkLabel2 = new Krypton.Toolkit.KryptonLinkLabel();
            help_link = new Krypton.Toolkit.KryptonLinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.BackColor = Color.Transparent;
            email_label.Depth = 0;
            email_label.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            email_label.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            email_label.ForeColor = Color.White;
            email_label.Location = new Point(158, 90);
            email_label.MouseState = MaterialSkin.MouseState.HOVER;
            email_label.Name = "email_label";
            email_label.Size = new Size(50, 24);
            email_label.TabIndex = 9;
            email_label.Text = "Email";
            email_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pass_txt_box
            // 
            pass_txt_box.AutoSize = true;
            pass_txt_box.Depth = 0;
            pass_txt_box.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            pass_txt_box.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            pass_txt_box.Location = new Point(158, 191);
            pass_txt_box.MouseState = MaterialSkin.MouseState.HOVER;
            pass_txt_box.Name = "pass_txt_box";
            pass_txt_box.Size = new Size(89, 24);
            pass_txt_box.TabIndex = 10;
            pass_txt_box.Text = "Password";
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
            groupBox1.Controls.Add(login_btn);
            groupBox1.Controls.Add(email_txt_box);
            groupBox1.Controls.Add(pass_txt);
            groupBox1.Controls.Add(kryptonBorderEdge3);
            groupBox1.Controls.Add(kryptonBorderEdge2);
            groupBox1.Controls.Add(pass_input);
            groupBox1.Controls.Add(email_label);
            groupBox1.Controls.Add(pass_txt_box);
            groupBox1.Location = new Point(185, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 454);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
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
            // login_btn
            // 
            login_btn.Location = new Point(205, 298);
            login_btn.Name = "login_btn";
            login_btn.OverrideDefault.Back.Color1 = Color.Brown;
            login_btn.OverrideDefault.Back.Color2 = Color.Brown;
            login_btn.OverrideFocus.Back.Color1 = Color.Brown;
            login_btn.OverrideFocus.Back.Color2 = Color.Brown;
            login_btn.Size = new Size(138, 47);
            login_btn.StateCommon.Back.Color1 = Color.Brown;
            login_btn.StateCommon.Back.Color2 = Color.Brown;
            login_btn.StateCommon.Back.ColorAngle = 1F;
            login_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            login_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            login_btn.StateCommon.Border.ColorAngle = 1F;
            login_btn.StateCommon.Border.Rounding = 3F;
            login_btn.StateCommon.Border.Width = 2;
            login_btn.StateCommon.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            login_btn.StateCommon.Content.LongText.Color2 = Color.White;
            login_btn.StateCommon.Content.ShortText.Color1 = Color.White;
            login_btn.StateCommon.Content.ShortText.Color2 = Color.White;
            login_btn.StateCommon.Content.ShortText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            login_btn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            login_btn.StateDisabled.Back.Color1 = Color.Brown;
            login_btn.StateDisabled.Back.Color2 = Color.Brown;
            login_btn.StateDisabled.Border.Rounding = 3F;
            login_btn.StateDisabled.Border.Width = 2;
            login_btn.StateNormal.Back.Color1 = Color.Brown;
            login_btn.StateNormal.Back.Color2 = Color.Brown;
            login_btn.StatePressed.Back.Color1 = Color.Maroon;
            login_btn.StatePressed.Back.Color2 = Color.Maroon;
            login_btn.StatePressed.Border.Rounding = 3F;
            login_btn.StatePressed.Border.Width = 5;
            login_btn.StateTracking.Back.Color1 = Color.Brown;
            login_btn.StateTracking.Back.Color2 = Color.Brown;
            login_btn.TabIndex = 24;
            login_btn.UseMnemonic = false;
            login_btn.Values.DropDownArrowColor = Color.Empty;
            login_btn.Values.ImageTransparentColor = Color.White;
            login_btn.Values.Text = "Login";
            login_btn.Click += login_btn_Click;
            // 
            // email_txt_box
            // 
            email_txt_box.Cursor = Cursors.IBeam;
            email_txt_box.Location = new Point(158, 130);
            email_txt_box.MaxLength = 32;
            email_txt_box.Name = "email_txt_box";
            email_txt_box.Size = new Size(250, 29);
            email_txt_box.StateActive.Border.Color1 = Color.Black;
            email_txt_box.StateActive.Border.Color2 = Color.Black;
            email_txt_box.StateActive.Border.Width = 1;
            email_txt_box.StateActive.Content.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_txt_box.StateCommon.Border.Color1 = Color.Black;
            email_txt_box.StateCommon.Border.Color2 = Color.Black;
            email_txt_box.StateCommon.Border.Rounding = 3F;
            email_txt_box.StateCommon.Border.Width = 0;
            email_txt_box.TabIndex = 21;
            // 
            // pass_txt
            // 
            pass_txt.Cursor = Cursors.IBeam;
            pass_txt.Location = new Point(158, 226);
            pass_txt.MaxLength = 16;
            pass_txt.Name = "pass_txt";
            pass_txt.PasswordChar = '*';
            pass_txt.Size = new Size(250, 29);
            pass_txt.StateActive.Border.Color1 = Color.Black;
            pass_txt.StateActive.Border.Color2 = Color.Black;
            pass_txt.StateActive.Border.Width = 1;
            pass_txt.StateActive.Content.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass_txt.StateCommon.Border.Color1 = Color.Black;
            pass_txt.StateCommon.Border.Color2 = Color.Black;
            pass_txt.StateCommon.Border.Rounding = 3F;
            pass_txt.StateCommon.Border.Width = 0;
            pass_txt.TabIndex = 20;
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
            // header
            // 
            header.Cursor = Cursors.No;
            header.Dock = DockStyle.Top;
            header.Enabled = false;
            header.Location = new Point(0, 0);
            header.MaxLength = 3;
            header.Name = "header";
            header.ReadOnly = true;
            header.Size = new Size(889, 44);
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
            header.TabIndex = 27;
            header.Text = "Exami";
            header.TextAlign = HorizontalAlignment.Center;
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
            Controls.Add(header);
            Controls.Add(kryptonBorderEdge1);
            Controls.Add(box2);
            Controls.Add(groupBox2);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "loggin";
            ShowIcon = false;
            Load += loggin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        #region controls
        private MaterialSkin.Controls.MaterialLabel email_label;
        private MaterialSkin.Controls.MaterialLabel pass_txt_box;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        private Krypton.Toolkit.KryptonBorderEdge box2;
        private GroupBox groupBox1;
        private TextBox pass_input;
        private Krypton.Toolkit.KryptonTextBox pass_txt;
        private Krypton.Toolkit.KryptonTextBox email_txt_box;
        private Krypton.Toolkit.KryptonTextBox header;
        private GroupBox groupBox2;
        private Krypton.Toolkit.KryptonLinkLabel help_link;
        private Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel2;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge4;
        private Krypton.Toolkit.KryptonButton login_btn;
        #endregion

        #region Login Button Click Event
        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = email_txt_box.Text.Trim();
            string password = pass_txt.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var loginDto = new LoginInputDto(email, password);

            try
            {
                User user = AuthService.Login(loginDto);
                if (user == null)
                {
                    MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserSession.SetUser(user);
                var role = user.Role;

                switch (role)
                {
                    case UserRole.Admin:
                        MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case UserRole.Student:
                        var studentForm = new st_main();
                        studentForm.Show();
                        break;

                    case UserRole.Teacher:
                        MessageBox.Show("Welcome Teacher!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        MessageBox.Show("Invalid Role", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                Hide();
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred. Please try again later.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"Unexpected error: {ex.Message}\n{ex}");
            }
        }

        #endregion

        private void loggin_Load(object sender, EventArgs e)
        {

        }
    }

}
