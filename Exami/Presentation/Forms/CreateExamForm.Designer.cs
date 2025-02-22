namespace Presentation.Forms
{
    partial class CreateExamForm
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
            Krypton.Toolkit.OutlookGridGroupCollection outlookGridGroupCollection1 = new Krypton.Toolkit.OutlookGridGroupCollection();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Krypton.Toolkit.OutlookGridGroupCollection outlookGridGroupCollection2 = new Krypton.Toolkit.OutlookGridGroupCollection();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            name_lbl = new Label();
            Name_Box = new TextBox();
            subject_lbl = new Label();
            type_lbl = new Label();
            duration_lbl = new Label();
            instructions_lbl = new Label();
            Subject_Box = new ComboBox();
            Type_Box = new ComboBox();
            label8 = new Label();
            Create_Button = new Button();
            Instructions_Box = new RichTextBox();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            questionBindingSource = new BindingSource(components);
            examQuestionBindingSource = new BindingSource(components);
            examQuestionBindingSource1 = new BindingSource(components);
            subjectBindingSource = new BindingSource(components);
            examServiceBindingSource = new BindingSource(components);
            header = new Panel();
            sd_name = new Label();
            logo = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            help_link = new Krypton.Toolkit.KryptonLinkLabel();
            contactlink = new Krypton.Toolkit.KryptonLinkLabel();
            kryptonOutlookGrid1 = new Krypton.Toolkit.KryptonOutlookGrid();
            kryptonDataGridViewTextBoxColumn1 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn2 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn3 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonOutlookGrid2 = new Krypton.Toolkit.KryptonOutlookGrid();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examQuestionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examQuestionBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examServiceBindingSource).BeginInit();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonOutlookGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonOutlookGrid2).BeginInit();
            SuspendLayout();
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Tahoma", 15.75F);
            name_lbl.ForeColor = Color.Brown;
            name_lbl.Location = new Point(30, 137);
            name_lbl.Margin = new Padding(1, 0, 1, 0);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(66, 25);
            name_lbl.TabIndex = 0;
            name_lbl.Text = "Name";
            // 
            // Name_Box
            // 
            Name_Box.ForeColor = Color.FromArgb(64, 64, 64);
            Name_Box.Location = new Point(157, 136);
            Name_Box.Margin = new Padding(1);
            Name_Box.Name = "Name_Box";
            Name_Box.Size = new Size(314, 30);
            Name_Box.TabIndex = 1;
            // 
            // subject_lbl
            // 
            subject_lbl.AutoSize = true;
            subject_lbl.Font = new Font("Tahoma", 15.75F);
            subject_lbl.ForeColor = Color.Brown;
            subject_lbl.Location = new Point(24, 265);
            subject_lbl.Margin = new Padding(1, 0, 1, 0);
            subject_lbl.Name = "subject_lbl";
            subject_lbl.Size = new Size(82, 25);
            subject_lbl.TabIndex = 2;
            subject_lbl.Text = "Subject";
            // 
            // type_lbl
            // 
            type_lbl.AutoSize = true;
            type_lbl.Font = new Font("Tahoma", 15.75F);
            type_lbl.ForeColor = Color.Brown;
            type_lbl.Location = new Point(24, 202);
            type_lbl.Margin = new Padding(1, 0, 1, 0);
            type_lbl.Name = "type_lbl";
            type_lbl.Size = new Size(57, 25);
            type_lbl.TabIndex = 4;
            type_lbl.Text = "Type";
            // 
            // duration_lbl
            // 
            duration_lbl.AutoSize = true;
            duration_lbl.Font = new Font("Tahoma", 15.75F);
            duration_lbl.ForeColor = Color.Brown;
            duration_lbl.Location = new Point(24, 363);
            duration_lbl.Margin = new Padding(1, 0, 1, 0);
            duration_lbl.Name = "duration_lbl";
            duration_lbl.Size = new Size(92, 25);
            duration_lbl.TabIndex = 6;
            duration_lbl.Text = "Duration";
            // 
            // instructions_lbl
            // 
            instructions_lbl.AutoSize = true;
            instructions_lbl.Font = new Font("Tahoma", 15.75F);
            instructions_lbl.ForeColor = Color.Brown;
            instructions_lbl.Location = new Point(10, 488);
            instructions_lbl.Margin = new Padding(1, 0, 1, 0);
            instructions_lbl.Name = "instructions_lbl";
            instructions_lbl.Size = new Size(122, 25);
            instructions_lbl.TabIndex = 10;
            instructions_lbl.Text = "Instructions";
            // 
            // Subject_Box
            // 
            Subject_Box.ForeColor = Color.FromArgb(64, 64, 64);
            Subject_Box.FormattingEnabled = true;
            Subject_Box.Location = new Point(157, 259);
            Subject_Box.Margin = new Padding(1);
            Subject_Box.Name = "Subject_Box";
            Subject_Box.Size = new Size(314, 31);
            Subject_Box.TabIndex = 12;
            // 
            // Type_Box
            // 
            Type_Box.ForeColor = Color.FromArgb(64, 64, 64);
            Type_Box.FormattingEnabled = true;
            Type_Box.Items.AddRange(new object[] { "Practice", "Final" });
            Type_Box.Location = new Point(157, 202);
            Type_Box.Margin = new Padding(1);
            Type_Box.Name = "Type_Box";
            Type_Box.Size = new Size(314, 31);
            Type_Box.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(309, 366);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(14, 23);
            label8.TabIndex = 17;
            label8.Text = ":";
            // 
            // Create_Button
            // 
            Create_Button.BackColor = Color.Brown;
            Create_Button.CausesValidation = false;
            Create_Button.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Create_Button.ForeColor = Color.White;
            Create_Button.Location = new Point(662, 613);
            Create_Button.Margin = new Padding(1);
            Create_Button.Name = "Create_Button";
            Create_Button.Size = new Size(168, 42);
            Create_Button.TabIndex = 19;
            Create_Button.Text = "Create";
            Create_Button.UseVisualStyleBackColor = false;
            // 
            // Instructions_Box
            // 
            Instructions_Box.BorderStyle = BorderStyle.FixedSingle;
            Instructions_Box.ForeColor = Color.FromArgb(64, 64, 64);
            Instructions_Box.Location = new Point(157, 489);
            Instructions_Box.Margin = new Padding(1);
            Instructions_Box.Name = "Instructions_Box";
            Instructions_Box.Size = new Size(314, 166);
            Instructions_Box.TabIndex = 20;
            Instructions_Box.Text = "";
            // 
            // startDatePicker
            // 
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.Location = new Point(157, 325);
            startDatePicker.Margin = new Padding(1);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(314, 30);
            startDatePicker.TabIndex = 21;
            startDatePicker.Value = new DateTime(2029, 11, 22, 0, 0, 0, 0);
            // 
            // endDatePicker
            // 
            endDatePicker.CustomFormat = "";
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.Location = new Point(157, 399);
            endDatePicker.Margin = new Padding(1);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(314, 30);
            endDatePicker.TabIndex = 22;
            endDatePicker.Value = new DateTime(2025, 2, 18, 0, 0, 0, 0);
            // 
            // questionBindingSource
            // 
            questionBindingSource.DataSource = typeof(Entities.Question);
            // 
            // examQuestionBindingSource
            // 
            examQuestionBindingSource.DataSource = typeof(Entities.ExamQuestion);
            // 
            // examQuestionBindingSource1
            // 
            examQuestionBindingSource1.DataSource = typeof(Entities.ExamQuestion);
            // 
            // subjectBindingSource
            // 
            subjectBindingSource.DataSource = typeof(Entities.Subject);
            // 
            // examServiceBindingSource
            // 
            examServiceBindingSource.DataSource = typeof(Services.Services.ExamService);
            // 
            // header
            // 
            header.BackColor = Color.Brown;
            header.Controls.Add(sd_name);
            header.Controls.Add(logo);
            header.Controls.Add(pictureBox1);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1477, 109);
            header.TabIndex = 48;
            // 
            // sd_name
            // 
            sd_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sd_name.BackColor = Color.Transparent;
            sd_name.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sd_name.ForeColor = SystemColors.ButtonHighlight;
            sd_name.Location = new Point(956, 9);
            sd_name.Name = "sd_name";
            sd_name.Size = new Size(377, 87);
            sd_name.TabIndex = 49;
            sd_name.Text = "Name";
            sd_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logo.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logo.ForeColor = SystemColors.ButtonHighlight;
            logo.Location = new Point(361, 0);
            logo.Name = "logo";
            logo.Size = new Size(665, 109);
            logo.TabIndex = 0;
            logo.Text = "Exami";
            logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(1349, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 109);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(help_link);
            panel2.Controls.Add(contactlink);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 685);
            panel2.Name = "panel2";
            panel2.Size = new Size(1477, 101);
            panel2.TabIndex = 49;
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
            // kryptonOutlookGrid1
            // 
            kryptonOutlookGrid1.AllowUserToDeleteRows = false;
            kryptonOutlookGrid1.AllowUserToOrderColumns = true;
            kryptonOutlookGrid1.AllowUserToResizeColumns = false;
            kryptonOutlookGrid1.AllowUserToResizeRows = false;
            kryptonOutlookGrid1.BorderStyle = BorderStyle.Fixed3D;
            kryptonOutlookGrid1.ColumnHeadersHeight = 30;
            kryptonOutlookGrid1.Columns.AddRange(new DataGridViewColumn[] { kryptonDataGridViewTextBoxColumn1, kryptonDataGridViewTextBoxColumn2, kryptonDataGridViewTextBoxColumn3 });
            kryptonOutlookGrid1.DataSource = questionBindingSource;
            kryptonOutlookGrid1.FillMode = Krypton.Toolkit.GridFillMode.GroupsOnly;
            kryptonOutlookGrid1.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            kryptonOutlookGrid1.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridHeaderRowSheet;
            kryptonOutlookGrid1.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            kryptonOutlookGrid1.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            kryptonOutlookGrid1.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            kryptonOutlookGrid1.GroupCollection = outlookGridGroupCollection1;
            kryptonOutlookGrid1.HideOuterBorders = true;
            kryptonOutlookGrid1.Location = new Point(505, 137);
            kryptonOutlookGrid1.Name = "kryptonOutlookGrid1";
            kryptonOutlookGrid1.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            kryptonOutlookGrid1.PreviousSelectedGroupRow = -1;
            kryptonOutlookGrid1.ReadOnly = true;
            kryptonOutlookGrid1.RightToLeftLayout = Krypton.Toolkit.RightToLeftLayout.LeftToRight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = Color.Snow;
            dataGridViewCellStyle4.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            kryptonOutlookGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            kryptonOutlookGrid1.ShowCellErrors = false;
            kryptonOutlookGrid1.ShowCellToolTips = false;
            kryptonOutlookGrid1.Size = new Size(521, 447);
            kryptonOutlookGrid1.StateCommon.Background.Color1 = Color.White;
            kryptonOutlookGrid1.StateCommon.Background.Color2 = Color.White;
            kryptonOutlookGrid1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridHeaderRowSheet;
            kryptonOutlookGrid1.StateCommon.DataCell.Back.Color1 = Color.Snow;
            kryptonOutlookGrid1.StateCommon.DataCell.Back.Color2 = Color.Snow;
            kryptonOutlookGrid1.StateCommon.DataCell.Border.Color1 = Color.Black;
            kryptonOutlookGrid1.StateCommon.DataCell.Border.Color2 = Color.Black;
            kryptonOutlookGrid1.StateCommon.DataCell.Border.Rounding = 1F;
            kryptonOutlookGrid1.StateCommon.DataCell.Border.Width = 2;
            kryptonOutlookGrid1.StateCommon.DataCell.Content.Color1 = Color.Black;
            kryptonOutlookGrid1.StateCommon.DataCell.Content.Color2 = Color.Black;
            kryptonOutlookGrid1.StateCommon.DataCell.Content.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonOutlookGrid1.StateCommon.DataCell.Content.Padding = new Padding(3);
            kryptonOutlookGrid1.StateCommon.HeaderColumn.Back.Color1 = Color.Brown;
            kryptonOutlookGrid1.StateCommon.HeaderColumn.Back.Color2 = Color.Brown;
            kryptonOutlookGrid1.StateCommon.HeaderColumn.Border.Color1 = Color.Black;
            kryptonOutlookGrid1.StateCommon.HeaderColumn.Border.Color2 = Color.Black;
            kryptonOutlookGrid1.StateCommon.HeaderColumn.Border.Rounding = 2F;
            kryptonOutlookGrid1.StateCommon.HeaderColumn.Border.Width = 2;
            kryptonOutlookGrid1.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            kryptonOutlookGrid1.StateCommon.HeaderColumn.Content.Color2 = Color.White;
            kryptonOutlookGrid1.StateCommon.HeaderColumn.Content.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonOutlookGrid1.StateCommon.HeaderColumn.Content.Padding = new Padding(3);
            kryptonOutlookGrid1.StateCommon.HeaderRow.Back.Color1 = Color.Brown;
            kryptonOutlookGrid1.StateCommon.HeaderRow.Back.Color2 = Color.Brown;
            kryptonOutlookGrid1.StateCommon.HeaderRow.Border.Color1 = Color.Black;
            kryptonOutlookGrid1.StateCommon.HeaderRow.Border.Color2 = Color.Black;
            kryptonOutlookGrid1.StateCommon.HeaderRow.Border.Rounding = 2F;
            kryptonOutlookGrid1.StateCommon.HeaderRow.Border.Width = 2;
            kryptonOutlookGrid1.StateCommon.HeaderRow.Content.Color1 = Color.White;
            kryptonOutlookGrid1.StateCommon.HeaderRow.Content.Color2 = Color.White;
            kryptonOutlookGrid1.StateCommon.HeaderRow.Content.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonOutlookGrid1.StateCommon.HeaderRow.Content.Padding = new Padding(3);
            kryptonOutlookGrid1.TabIndex = 51;
            kryptonOutlookGrid1.CellContentClick += kryptonOutlookGrid1_CellContentClick;
            // 
            // kryptonDataGridViewTextBoxColumn1
            // 
            kryptonDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn1.DataPropertyName = "Marks";
            kryptonDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            kryptonDataGridViewTextBoxColumn1.HeaderText = "Marks";
            kryptonDataGridViewTextBoxColumn1.Name = "kryptonDataGridViewTextBoxColumn1";
            kryptonDataGridViewTextBoxColumn1.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn1.Width = 97;
            // 
            // kryptonDataGridViewTextBoxColumn2
            // 
            kryptonDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn2.DataPropertyName = "Body";
            kryptonDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            kryptonDataGridViewTextBoxColumn2.HeaderText = "Body";
            kryptonDataGridViewTextBoxColumn2.Name = "kryptonDataGridViewTextBoxColumn2";
            kryptonDataGridViewTextBoxColumn2.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn2.Width = 89;
            // 
            // kryptonDataGridViewTextBoxColumn3
            // 
            kryptonDataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn3.DataPropertyName = "QuestionType";
            kryptonDataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            kryptonDataGridViewTextBoxColumn3.HeaderText = "QuestionType";
            kryptonDataGridViewTextBoxColumn3.Name = "kryptonDataGridViewTextBoxColumn3";
            kryptonDataGridViewTextBoxColumn3.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn3.Width = 170;
            // 
            // kryptonOutlookGrid2
            // 
            kryptonOutlookGrid2.AllowUserToDeleteRows = false;
            kryptonOutlookGrid2.AllowUserToOrderColumns = true;
            kryptonOutlookGrid2.AllowUserToResizeColumns = false;
            kryptonOutlookGrid2.AllowUserToResizeRows = false;
            kryptonOutlookGrid2.BorderStyle = BorderStyle.Fixed3D;
            kryptonOutlookGrid2.ColumnHeadersHeight = 30;
            kryptonOutlookGrid2.DataMember = "Answers";
            kryptonOutlookGrid2.DataSource = questionBindingSource;
            kryptonOutlookGrid2.FillMode = Krypton.Toolkit.GridFillMode.GroupsOnly;
            kryptonOutlookGrid2.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            kryptonOutlookGrid2.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridHeaderRowSheet;
            kryptonOutlookGrid2.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            kryptonOutlookGrid2.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            kryptonOutlookGrid2.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            kryptonOutlookGrid2.GroupCollection = outlookGridGroupCollection2;
            kryptonOutlookGrid2.HideOuterBorders = true;
            kryptonOutlookGrid2.Location = new Point(1052, 137);
            kryptonOutlookGrid2.Name = "kryptonOutlookGrid2";
            kryptonOutlookGrid2.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            kryptonOutlookGrid2.PreviousSelectedGroupRow = -1;
            kryptonOutlookGrid2.ReadOnly = true;
            kryptonOutlookGrid2.RightToLeftLayout = Krypton.Toolkit.RightToLeftLayout.LeftToRight;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.Snow;
            dataGridViewCellStyle5.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            kryptonOutlookGrid2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            kryptonOutlookGrid2.ShowCellErrors = false;
            kryptonOutlookGrid2.ShowCellToolTips = false;
            kryptonOutlookGrid2.Size = new Size(403, 447);
            kryptonOutlookGrid2.StateCommon.Background.Color1 = Color.White;
            kryptonOutlookGrid2.StateCommon.Background.Color2 = Color.White;
            kryptonOutlookGrid2.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridHeaderRowSheet;
            kryptonOutlookGrid2.StateCommon.DataCell.Back.Color1 = Color.Snow;
            kryptonOutlookGrid2.StateCommon.DataCell.Back.Color2 = Color.Snow;
            kryptonOutlookGrid2.StateCommon.DataCell.Border.Color1 = Color.Black;
            kryptonOutlookGrid2.StateCommon.DataCell.Border.Color2 = Color.Black;
            kryptonOutlookGrid2.StateCommon.DataCell.Border.Rounding = 1F;
            kryptonOutlookGrid2.StateCommon.DataCell.Border.Width = 2;
            kryptonOutlookGrid2.StateCommon.DataCell.Content.Color1 = Color.Black;
            kryptonOutlookGrid2.StateCommon.DataCell.Content.Color2 = Color.Black;
            kryptonOutlookGrid2.StateCommon.DataCell.Content.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonOutlookGrid2.StateCommon.DataCell.Content.Padding = new Padding(3);
            kryptonOutlookGrid2.StateCommon.HeaderColumn.Back.Color1 = Color.Brown;
            kryptonOutlookGrid2.StateCommon.HeaderColumn.Back.Color2 = Color.Brown;
            kryptonOutlookGrid2.StateCommon.HeaderColumn.Border.Color1 = Color.Black;
            kryptonOutlookGrid2.StateCommon.HeaderColumn.Border.Color2 = Color.Black;
            kryptonOutlookGrid2.StateCommon.HeaderColumn.Border.Rounding = 2F;
            kryptonOutlookGrid2.StateCommon.HeaderColumn.Border.Width = 2;
            kryptonOutlookGrid2.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            kryptonOutlookGrid2.StateCommon.HeaderColumn.Content.Color2 = Color.White;
            kryptonOutlookGrid2.StateCommon.HeaderColumn.Content.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonOutlookGrid2.StateCommon.HeaderColumn.Content.Padding = new Padding(3);
            kryptonOutlookGrid2.StateCommon.HeaderRow.Back.Color1 = Color.Brown;
            kryptonOutlookGrid2.StateCommon.HeaderRow.Back.Color2 = Color.Brown;
            kryptonOutlookGrid2.StateCommon.HeaderRow.Border.Color1 = Color.Black;
            kryptonOutlookGrid2.StateCommon.HeaderRow.Border.Color2 = Color.Black;
            kryptonOutlookGrid2.StateCommon.HeaderRow.Border.Rounding = 2F;
            kryptonOutlookGrid2.StateCommon.HeaderRow.Border.Width = 2;
            kryptonOutlookGrid2.StateCommon.HeaderRow.Content.Color1 = Color.White;
            kryptonOutlookGrid2.StateCommon.HeaderRow.Content.Color2 = Color.White;
            kryptonOutlookGrid2.StateCommon.HeaderRow.Content.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonOutlookGrid2.StateCommon.HeaderRow.Content.Padding = new Padding(3);
            kryptonOutlookGrid2.TabIndex = 52;
            // 
            // CreateExamForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1477, 786);
            Controls.Add(kryptonOutlookGrid2);
            Controls.Add(kryptonOutlookGrid1);
            Controls.Add(panel2);
            Controls.Add(header);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(Instructions_Box);
            Controls.Add(Create_Button);
            Controls.Add(label8);
            Controls.Add(Type_Box);
            Controls.Add(Subject_Box);
            Controls.Add(instructions_lbl);
            Controls.Add(duration_lbl);
            Controls.Add(type_lbl);
            Controls.Add(subject_lbl);
            Controls.Add(Name_Box);
            Controls.Add(name_lbl);
            Margin = new Padding(1);
            Name = "CreateExamForm";
            Text = "CreateExamForm";
            ((System.ComponentModel.ISupportInitialize)questionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)examQuestionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)examQuestionBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)examServiceBindingSource).EndInit();
            header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonOutlookGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonOutlookGrid2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_lbl;
        private TextBox Name_Box;
        private Label subject_lbl;
        private Label type_lbl;
        private Label duration_lbl;
        private Label instructions_lbl;
        private ComboBox Subject_Box;
        private ComboBox Type_Box;
        private Label label8;
        private Button Create_Button;
        private RichTextBox Instructions_Box;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private BindingSource questionBindingSource;
        private BindingSource examQuestionBindingSource;
        private BindingSource examQuestionBindingSource1;
        private BindingSource subjectBindingSource;
        private BindingSource examServiceBindingSource;
        private Panel header;
        private Label sd_name;
        private Label logo;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Krypton.Toolkit.KryptonLinkLabel help_link;
        private Krypton.Toolkit.KryptonLinkLabel contactlink;
        private Krypton.Toolkit.KryptonOutlookGrid kryptonOutlookGrid1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn2;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn3;
        private Krypton.Toolkit.KryptonOutlookGrid kryptonOutlookGrid2;
    }
}