namespace MIS
{
    partial class frmAEStudent
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtSName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPhoneNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtNationality = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtAdmNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPrevSchool = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtWPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFGWAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGuardian = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtScholarship = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAdmStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.btnPicture = new DevComponents.DotNetBar.ButtonX();
            this.opf = new System.Windows.Forms.OpenFileDialog();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.btnRemovePic = new DevComponents.DotNetBar.ButtonX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.dtDOB = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbxClass = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.dtAdmDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.cbxSection = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAdmDate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::MIS.Properties.Resources.Exit__2_1;
            this.btnClose.Location = new System.Drawing.Point(745, 499);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Tooltip = "Click To Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::MIS.Properties.Resources.Save_b;
            this.btnSave.Location = new System.Drawing.Point(681, 499);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSave.Tooltip = "Click To Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(22, 28);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(163, 23);
            this.labelX3.TabIndex = 24;
            this.labelX3.Text = "Add / Edit Student";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(25, 122);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 23);
            this.labelX2.TabIndex = 25;
            this.labelX2.Text = "Name";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(25, 148);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(70, 23);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "D.O.B";
            // 
            // txtSName
            // 
            // 
            // 
            // 
            this.txtSName.Border.Class = "TextBoxBorder";
            this.txtSName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtSName, true);
            this.txtSName.Location = new System.Drawing.Point(115, 123);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(267, 20);
            this.txtSName.TabIndex = 2;
            this.txtSName.WatermarkText = "Name of Student";
            // 
            // txtPhoneNo
            // 
            // 
            // 
            // 
            this.txtPhoneNo.Border.Class = "TextBoxBorder";
            this.txtPhoneNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtPhoneNo, true);
            this.txtPhoneNo.Location = new System.Drawing.Point(115, 386);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(267, 20);
            this.txtPhoneNo.TabIndex = 8;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(25, 381);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(70, 23);
            this.labelX4.TabIndex = 23;
            this.labelX4.Text = "Phone No.";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(25, 174);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(70, 23);
            this.labelX6.TabIndex = 23;
            this.labelX6.Text = "Natinality";
            // 
            // txtNationality
            // 
            // 
            // 
            // 
            this.txtNationality.Border.Class = "TextBoxBorder";
            this.txtNationality.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtNationality, true);
            this.txtNationality.Location = new System.Drawing.Point(115, 176);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(267, 20);
            this.txtNationality.TabIndex = 4;
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // txtAdmNo
            // 
            // 
            // 
            // 
            this.txtAdmNo.Border.Class = "TextBoxBorder";
            this.txtAdmNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtAdmNo, true);
            this.txtAdmNo.Location = new System.Drawing.Point(115, 72);
            this.txtAdmNo.Name = "txtAdmNo";
            this.txtAdmNo.Size = new System.Drawing.Size(267, 20);
            this.txtAdmNo.TabIndex = 0;
            this.txtAdmNo.WatermarkText = "Admission No.";
            // 
            // txtPrevSchool
            // 
            // 
            // 
            // 
            this.txtPrevSchool.Border.Class = "TextBoxBorder";
            this.txtPrevSchool.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtPrevSchool, true);
            this.txtPrevSchool.Location = new System.Drawing.Point(115, 259);
            this.txtPrevSchool.Multiline = true;
            this.txtPrevSchool.Name = "txtPrevSchool";
            this.txtPrevSchool.Size = new System.Drawing.Size(267, 58);
            this.txtPrevSchool.TabIndex = 6;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtAddress, true);
            this.txtAddress.Location = new System.Drawing.Point(114, 323);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(267, 57);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBoxX3_TextChanged);
            // 
            // txtWPhone
            // 
            // 
            // 
            // 
            this.txtWPhone.Border.Class = "TextBoxBorder";
            this.txtWPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtWPhone, true);
            this.txtWPhone.Location = new System.Drawing.Point(540, 386);
            this.txtWPhone.Multiline = true;
            this.txtWPhone.Name = "txtWPhone";
            this.txtWPhone.Size = new System.Drawing.Size(267, 20);
            this.txtWPhone.TabIndex = 16;
            // 
            // txtFGWAddress
            // 
            // 
            // 
            // 
            this.txtFGWAddress.Border.Class = "TextBoxBorder";
            this.txtFGWAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtFGWAddress, true);
            this.txtFGWAddress.Location = new System.Drawing.Point(540, 338);
            this.txtFGWAddress.Multiline = true;
            this.txtFGWAddress.Name = "txtFGWAddress";
            this.txtFGWAddress.Size = new System.Drawing.Size(267, 42);
            this.txtFGWAddress.TabIndex = 15;
            // 
            // txtFName
            // 
            // 
            // 
            // 
            this.txtFName.Border.Class = "TextBoxBorder";
            this.txtFName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtFName, true);
            this.txtFName.Location = new System.Drawing.Point(540, 208);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(267, 20);
            this.txtFName.TabIndex = 10;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtEmail, true);
            this.txtEmail.Location = new System.Drawing.Point(540, 412);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // txtMMobile
            // 
            // 
            // 
            // 
            this.txtMMobile.Border.Class = "TextBoxBorder";
            this.txtMMobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtMMobile, true);
            this.txtMMobile.Location = new System.Drawing.Point(540, 287);
            this.txtMMobile.Name = "txtMMobile";
            this.txtMMobile.Size = new System.Drawing.Size(267, 20);
            this.txtMMobile.TabIndex = 13;
            // 
            // txtFMobile
            // 
            // 
            // 
            // 
            this.txtFMobile.Border.Class = "TextBoxBorder";
            this.txtFMobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtFMobile, true);
            this.txtFMobile.Location = new System.Drawing.Point(540, 234);
            this.txtFMobile.Name = "txtFMobile";
            this.txtFMobile.Size = new System.Drawing.Size(267, 20);
            this.txtFMobile.TabIndex = 11;
            // 
            // txtMName
            // 
            // 
            // 
            // 
            this.txtMName.Border.Class = "TextBoxBorder";
            this.txtMName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtMName, true);
            this.txtMName.Location = new System.Drawing.Point(540, 260);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(267, 20);
            this.txtMName.TabIndex = 12;
            // 
            // txtGuardian
            // 
            // 
            // 
            // 
            this.txtGuardian.Border.Class = "TextBoxBorder";
            this.txtGuardian.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtGuardian, true);
            this.txtGuardian.Location = new System.Drawing.Point(540, 313);
            this.txtGuardian.Name = "txtGuardian";
            this.txtGuardian.Size = new System.Drawing.Size(267, 20);
            this.txtGuardian.TabIndex = 14;
            // 
            // txtScholarship
            // 
            // 
            // 
            // 
            this.txtScholarship.Border.Class = "TextBoxBorder";
            this.txtScholarship.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtScholarship, true);
            this.txtScholarship.Location = new System.Drawing.Point(115, 414);
            this.txtScholarship.Name = "txtScholarship";
            this.txtScholarship.Size = new System.Drawing.Size(266, 20);
            this.txtScholarship.TabIndex = 9;
            this.txtScholarship.Text = "0";
            this.txtScholarship.WatermarkText = "0";
            // 
            // txtRemarks
            // 
            // 
            // 
            // 
            this.txtRemarks.Border.Class = "TextBoxBorder";
            this.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtRemarks, true);
            this.txtRemarks.Location = new System.Drawing.Point(114, 471);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(693, 20);
            this.txtRemarks.TabIndex = 19;
            // 
            // txtAdmStatus
            // 
            // 
            // 
            // 
            this.txtAdmStatus.Border.Class = "TextBoxBorder";
            this.txtAdmStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtAdmStatus, true);
            this.txtAdmStatus.Location = new System.Drawing.Point(115, 445);
            this.txtAdmStatus.Multiline = true;
            this.txtAdmStatus.Name = "txtAdmStatus";
            this.txtAdmStatus.Size = new System.Drawing.Size(692, 20);
            this.txtAdmStatus.TabIndex = 18;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(25, 199);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(70, 23);
            this.labelX8.TabIndex = 34;
            this.labelX8.Text = "Class";
            // 
            // pbStudent
            // 
            this.pbStudent.BackColor = System.Drawing.Color.Transparent;
            this.pbStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStudent.Image = global::MIS.Properties.Resources.NoImage;
            this.pbStudent.Location = new System.Drawing.Point(421, 71);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(126, 126);
            this.pbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudent.TabIndex = 35;
            this.pbStudent.TabStop = false;
            // 
            // btnPicture
            // 
            this.btnPicture.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPicture.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPicture.Location = new System.Drawing.Point(562, 74);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(126, 23);
            this.btnPicture.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPicture.TabIndex = 20;
            this.btnPicture.Text = "Browse Picture";
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // opf
            // 
            this.opf.FileName = "openFileDialog1";
            // 
            // ttp
            // 
            this.ttp.IsBalloon = true;
            this.ttp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ttp.ToolTipTitle = "Error";
            // 
            // btnRemovePic
            // 
            this.btnRemovePic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRemovePic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemovePic.Location = new System.Drawing.Point(562, 104);
            this.btnRemovePic.Name = "btnRemovePic";
            this.btnRemovePic.Size = new System.Drawing.Size(126, 23);
            this.btnRemovePic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRemovePic.TabIndex = 23;
            this.btnRemovePic.Text = "Remove Picture";
            this.btnRemovePic.Click += new System.EventHandler(this.btnRemovePic_Click);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(25, 65);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(70, 23);
            this.labelX9.TabIndex = 37;
            this.labelX9.Text = "Adm No.";
            // 
            // dtDOB
            // 
            // 
            // 
            // 
            this.dtDOB.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtDOB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDOB.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtDOB.ButtonDropDown.Visible = true;
            this.dtDOB.IsPopupCalendarOpen = false;
            this.dtDOB.Location = new System.Drawing.Point(115, 150);
            // 
            // 
            // 
            this.dtDOB.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDOB.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtDOB.MonthCalendar.BackgroundStyle.Class = "";
            this.dtDOB.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDOB.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtDOB.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtDOB.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDOB.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtDOB.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtDOB.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtDOB.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtDOB.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtDOB.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDOB.MonthCalendar.DisplayMonth = new System.DateTime(2013, 10, 1, 0, 0, 0, 0);
            this.dtDOB.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtDOB.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDOB.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtDOB.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDOB.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtDOB.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtDOB.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDOB.MonthCalendar.TodayButtonVisible = true;
            this.dtDOB.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(266, 20);
            this.dtDOB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtDOB.TabIndex = 3;
            // 
            // cbxClass
            // 
            this.cbxClass.DisplayMember = "Text";
            this.cbxClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.ItemHeight = 14;
            this.cbxClass.Location = new System.Drawing.Point(116, 203);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(266, 20);
            this.cbxClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxClass.TabIndex = 5;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(25, 251);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(79, 23);
            this.labelX10.TabIndex = 41;
            this.labelX10.Text = "Prev. School";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(25, 320);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(79, 23);
            this.labelX11.TabIndex = 43;
            this.labelX11.Text = "Address";
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(421, 383);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(105, 23);
            this.labelX12.TabIndex = 59;
            this.labelX12.Text = "Work Phone";
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.Class = "";
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.Location = new System.Drawing.Point(421, 335);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(126, 23);
            this.labelX13.TabIndex = 57;
            this.labelX13.Text = "Father\'s/Guardian\'s";
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(421, 208);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(96, 23);
            this.labelX14.TabIndex = 53;
            this.labelX14.Text = "Father\'s Name";
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.Class = "";
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.Location = new System.Drawing.Point(421, 311);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(96, 23);
            this.labelX15.TabIndex = 51;
            this.labelX15.Text = "Guardian";
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX16.Location = new System.Drawing.Point(421, 411);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(96, 23);
            this.labelX16.TabIndex = 50;
            this.labelX16.Text = "Email";
            // 
            // labelX17
            // 
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.Class = "";
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX17.Location = new System.Drawing.Point(421, 234);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(96, 23);
            this.labelX17.TabIndex = 49;
            this.labelX17.Text = "Mobile";
            // 
            // labelX18
            // 
            this.labelX18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.Class = "";
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX18.Location = new System.Drawing.Point(421, 286);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(96, 23);
            this.labelX18.TabIndex = 47;
            this.labelX18.Text = "Mobile";
            // 
            // labelX19
            // 
            this.labelX19.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.Class = "";
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX19.Location = new System.Drawing.Point(421, 260);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(96, 23);
            this.labelX19.TabIndex = 48;
            this.labelX19.Text = "Mother\'s Name";
            // 
            // labelX20
            // 
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.Class = "";
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX20.Location = new System.Drawing.Point(421, 356);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(105, 17);
            this.labelX20.TabIndex = 60;
            this.labelX20.Text = "Working Address";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(25, 412);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(70, 23);
            this.labelX7.TabIndex = 64;
            this.labelX7.Text = "Scholarship";
            // 
            // dtAdmDate
            // 
            // 
            // 
            // 
            this.dtAdmDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtAdmDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAdmDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtAdmDate.ButtonDropDown.Visible = true;
            this.dtAdmDate.IsPopupCalendarOpen = false;
            this.dtAdmDate.Location = new System.Drawing.Point(115, 97);
            // 
            // 
            // 
            this.dtAdmDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtAdmDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtAdmDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtAdmDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAdmDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtAdmDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtAdmDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtAdmDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtAdmDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtAdmDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtAdmDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtAdmDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtAdmDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAdmDate.MonthCalendar.DisplayMonth = new System.DateTime(2013, 10, 1, 0, 0, 0, 0);
            this.dtAdmDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtAdmDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtAdmDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtAdmDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtAdmDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtAdmDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtAdmDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAdmDate.MonthCalendar.TodayButtonVisible = true;
            this.dtAdmDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtAdmDate.Name = "dtAdmDate";
            this.dtAdmDate.Size = new System.Drawing.Size(266, 20);
            this.dtAdmDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtAdmDate.TabIndex = 1;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(25, 95);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(70, 23);
            this.labelX5.TabIndex = 66;
            this.labelX5.Text = "Adm. Date";
            // 
            // labelX21
            // 
            this.labelX21.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.Class = "";
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX21.Location = new System.Drawing.Point(23, 471);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(70, 23);
            this.labelX21.TabIndex = 67;
            this.labelX21.Text = "Remarks.";
            // 
            // labelX22
            // 
            this.labelX22.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.Class = "";
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX22.Location = new System.Drawing.Point(22, 445);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(70, 23);
            this.labelX22.TabIndex = 68;
            this.labelX22.Text = "Adm. Status";
            // 
            // cbxSection
            // 
            this.cbxSection.DisplayMember = "Text";
            this.cbxSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSection.FormattingEnabled = true;
            this.cbxSection.ItemHeight = 14;
            this.cbxSection.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cbxSection.Location = new System.Drawing.Point(115, 229);
            this.cbxSection.Name = "cbxSection";
            this.cbxSection.Size = new System.Drawing.Size(266, 20);
            this.cbxSection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxSection.TabIndex = 69;
            // 
            // labelX23
            // 
            this.labelX23.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX23.BackgroundStyle.Class = "";
            this.labelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX23.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX23.Location = new System.Drawing.Point(22, 225);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(70, 23);
            this.labelX23.TabIndex = 70;
            this.labelX23.Text = "Section";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "R";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "G";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "B";
            // 
            // frmAEStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIS.Properties.Resources.classy_and_authoritative_backgrounds_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 550);
            this.Controls.Add(this.labelX23);
            this.Controls.Add(this.cbxSection);
            this.Controls.Add(this.txtAdmStatus);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.labelX22);
            this.Controls.Add(this.labelX21);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.dtAdmDate);
            this.Controls.Add(this.txtScholarship);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtGuardian);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.labelX20);
            this.Controls.Add(this.txtWPhone);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.txtFGWAddress);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.labelX15);
            this.Controls.Add(this.labelX16);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMMobile);
            this.Controls.Add(this.labelX17);
            this.Controls.Add(this.labelX18);
            this.Controls.Add(this.labelX19);
            this.Controls.Add(this.txtFMobile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.txtPrevSchool);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.cbxClass);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtAdmNo);
            this.Controls.Add(this.btnRemovePic);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.pbStudent);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtSName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAEStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAEExaminer";
            this.Load += new System.EventHandler(this.frmAEExaminer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAdmDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhoneNo;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNationality;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX btnPicture;
        private System.Windows.Forms.PictureBox pbStudent;
        private System.Windows.Forms.OpenFileDialog opf;
        private System.Windows.Forms.ToolTip ttp;
        private DevComponents.DotNetBar.ButtonX btnRemovePic;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxClass;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtDOB;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAdmNo;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWPhone;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFGWAddress;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFName;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMMobile;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrevSchool;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtScholarship;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGuardian;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMName;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtAdmDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAdmStatus;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.DotNetBar.LabelX labelX21;
        private DevComponents.DotNetBar.LabelX labelX23;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxSection;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
    }
}