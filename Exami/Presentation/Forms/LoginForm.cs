using System.Diagnostics;
using Entities;
using Presentation.Helpers;
using Services.DTOs;
using Services.Services;
using Utilities.Exceptoins;
namespace Presentation.Forms
{
    public partial class LoginForm : Form
    {
        readonly AuthService _authService = ServicesRepo.GetService<AuthService>();
        #region  UI Components
        #region componnents intialzation
        public LoginForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            email_txt_box = new Krypton.Toolkit.KryptonTextBox();
            pass_txt = new Krypton.Toolkit.KryptonTextBox();
            login_btn = new Krypton.Toolkit.KryptonButton();
            pass_txt_box = new MaterialSkin.Controls.MaterialLabel();
            email_label = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            logo = new Label();
            panel2 = new Panel();
            help_link = new Krypton.Toolkit.KryptonLinkLabel();
            contactlink = new Krypton.Toolkit.KryptonLinkLabel();
            materialCard1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.BorderStyle = BorderStyle.Fixed3D;
            materialCard1.Controls.Add(email_txt_box);
            materialCard1.Controls.Add(pass_txt);
            materialCard1.Controls.Add(login_btn);
            materialCard1.Controls.Add(pass_txt_box);
            materialCard1.Controls.Add(email_label);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(223, 167);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(520, 392);
            materialCard1.TabIndex = 28;
            // 
            // email_txt_box
            // 
            email_txt_box.Cursor = Cursors.IBeam;
            email_txt_box.Location = new Point(112, 106);
            email_txt_box.MaxLength = 32;
            email_txt_box.Name = "email_txt_box";
            email_txt_box.Size = new Size(293, 34);
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
            pass_txt.Location = new Point(112, 208);
            pass_txt.MaxLength = 16;
            pass_txt.Name = "pass_txt";
            pass_txt.PasswordChar = '*';
            pass_txt.Size = new Size(293, 34);
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
            // login_btn
            // 
            login_btn.ImeMode = ImeMode.NoControl;
            login_btn.Location = new Point(208, 295);
            login_btn.Name = "login_btn";
            login_btn.OverrideDefault.Back.Color1 = Color.Brown;
            login_btn.OverrideDefault.Back.Color2 = Color.Brown;
            login_btn.OverrideFocus.Back.Color1 = Color.Brown;
            login_btn.OverrideFocus.Back.Color2 = Color.Brown;
            login_btn.Size = new Size(103, 53);
            login_btn.StateCommon.Back.Color1 = Color.Brown;
            login_btn.StateCommon.Back.Color2 = Color.Brown;
            login_btn.StateCommon.Back.ColorAngle = 1F;
            login_btn.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            login_btn.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            login_btn.StateCommon.Border.ColorAngle = 1F;
            login_btn.StateCommon.Border.Rounding = 4F;
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
            // pass_txt_box
            // 
            pass_txt_box.AutoSize = true;
            pass_txt_box.Depth = 0;
            pass_txt_box.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            pass_txt_box.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            pass_txt_box.ImeMode = ImeMode.NoControl;
            pass_txt_box.Location = new Point(112, 167);
            pass_txt_box.MouseState = MaterialSkin.MouseState.HOVER;
            pass_txt_box.Name = "pass_txt_box";
            pass_txt_box.Size = new Size(89, 24);
            pass_txt_box.TabIndex = 10;
            pass_txt_box.Text = "Password";
            // 
            // email_label
            // 
            email_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            email_label.AutoSize = true;
            email_label.BackColor = Color.Transparent;
            email_label.Depth = 0;
            email_label.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            email_label.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            email_label.ForeColor = Color.White;
            email_label.ImeMode = ImeMode.NoControl;
            email_label.Location = new Point(112, 55);
            email_label.MouseState = MaterialSkin.MouseState.HOVER;
            email_label.Name = "email_label";
            email_label.Size = new Size(50, 24);
            email_label.TabIndex = 9;
            email_label.Text = "Email";
            email_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(logo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 109);
            panel1.TabIndex = 31;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logo.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logo.Location = new Point(337, 0);
            logo.Name = "logo";
            logo.Size = new Size(264, 109);
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
            panel2.Location = new Point(0, 624);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 101);
            panel2.TabIndex = 32;
            // 
            // help_link
            // 
            help_link.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
            help_link.Location = new Point(790, 37);
            help_link.Name = "help_link";
            help_link.OverrideFocus.Padding = new Padding(3);
            help_link.OverrideFocus.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            help_link.OverrideFocus.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            help_link.Size = new Size(123, 32);
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
            help_link.TabIndex = 43;
            help_link.Values.Text = "Help Centre";
            // 
            // contactlink
            // 
            contactlink.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
            contactlink.Location = new Point(94, 37);
            contactlink.Name = "contactlink";
            contactlink.OverrideFocus.Padding = new Padding(3);
            contactlink.OverrideFocus.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            contactlink.OverrideFocus.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            contactlink.Size = new Size(211, 32);
            contactlink.StateCommon.Padding = new Padding(3);
            contactlink.StateCommon.ShortText.Color1 = Color.Black;
            contactlink.StateCommon.ShortText.Color2 = Color.Black;
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
            contactlink.TabIndex = 42;
            contactlink.Values.Text = "Contact Your Institute";
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            ClientSize = new Size(984, 725);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(materialCard1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        #region controls
        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Krypton.Toolkit.KryptonTextBox email_txt_box;
        private Krypton.Toolkit.KryptonTextBox pass_txt;
        private Krypton.Toolkit.KryptonButton login_btn;
        private MaterialSkin.Controls.MaterialLabel pass_txt_box;
        private Panel panel1;
        private Panel panel2;
        private Label logo;
        private Krypton.Toolkit.KryptonLinkLabel help_link;
        private Krypton.Toolkit.KryptonLinkLabel contactlink;
        private MaterialSkin.Controls.MaterialLabel email_label;

        #endregion

        #region Login Button Click Event
        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = email_txt_box.Text.Trim();
            string password = pass_txt.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                Messages.ShowSnackbarError("Please enter both email and password.");
                return;
            }

            var loginDto = new LoginInputDto(email, password);

            try
            {
                User user = _authService.Login(loginDto);
                if (user == null)
                {
                    Messages.ShowSnackbarError("Invalid email or password.");
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
                        var studentForm = FormsRepo.GetForm<StudentMainForm>();
                        studentForm.Show();
                        break;

                    case UserRole.Teacher:
                        MessageBox.Show("Welcome Teacher!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        Messages.ShowSnackbarError("Invalid Role");
                        return;
                }

                Hide();
            }
            catch (AppException ex)
            {
                Messages.ShowSnackbarError(ex.Message);
            }
            catch (Exception ex)
            {
                Messages.ShowSnackbarError(ex.Message);
            }
        }
        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }

}
