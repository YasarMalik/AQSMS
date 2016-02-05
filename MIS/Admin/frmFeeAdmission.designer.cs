namespace MIS
{
    partial class frmFeeAdmission
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigationBar1 = new DevComponents.DotNetBar.NavigationBar();
            this.btnLoadByClass = new DevComponents.DotNetBar.ButtonX();
            this.cbxClass = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtAdmNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnSearch = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.btnPayed = new DevComponents.DotNetBar.ButtonItem();
            this.btnNotPayed = new DevComponents.DotNetBar.ButtonItem();
            this.btnCancelSlp = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.grdList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.SFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scholarship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Security = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamsFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SportsFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutionFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegeFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Misc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrevArrears = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrears = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new DevComponents.DotNetBar.PanelEx();
            this.rbDesignation = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnPanelExit = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnGo = new DevComponents.DotNetBar.ButtonX();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rbName = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).BeginInit();
            this.navigationBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationBar1
            // 
            this.navigationBar1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.navigationBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigationBar1.BackgroundStyle.BackColor1.Alpha = ((byte)(0));
            this.navigationBar1.BackgroundStyle.BackColor1.Color = System.Drawing.Color.White;
            this.navigationBar1.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationBar1.BackgroundStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationBar1.BackgroundStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.navigationBar1.BackgroundStyle.BorderWidth = 0;
            this.navigationBar1.ConfigureShowHideVisible = false;
            this.navigationBar1.Controls.Add(this.btnLoadByClass);
            this.navigationBar1.Controls.Add(this.cbxClass);
            this.navigationBar1.Controls.Add(this.buttonX1);
            this.navigationBar1.Controls.Add(this.txtAdmNo);
            this.navigationBar1.Controls.Add(this.labelX1);
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar1.ItemPaddingBottom = 2;
            this.navigationBar1.ItemPaddingTop = 2;
            this.navigationBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnSearch,
            this.btnDelete,
            this.btnPrint,
            this.btnPayed,
            this.btnNotPayed,
            this.btnCancelSlp,
            this.btnClose});
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(1090, 26);
            this.navigationBar1.TabIndex = 1;
            this.navigationBar1.Text = "navigationBar1";
            // 
            // btnLoadByClass
            // 
            this.btnLoadByClass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoadByClass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoadByClass.Image = global::MIS.Properties.Resources.arrow_down;
            this.btnLoadByClass.Location = new System.Drawing.Point(704, 3);
            this.btnLoadByClass.Name = "btnLoadByClass";
            this.btnLoadByClass.Size = new System.Drawing.Size(75, 20);
            this.btnLoadByClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoadByClass.TabIndex = 4;
            this.btnLoadByClass.Text = "Load";
            this.btnLoadByClass.Click += new System.EventHandler(this.btnLoadByClass_Click);
            // 
            // cbxClass
            // 
            this.cbxClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxClass.DisplayMember = "Text";
            this.cbxClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.ItemHeight = 14;
            this.cbxClass.Location = new System.Drawing.Point(577, 3);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(121, 20);
            this.cbxClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxClass.TabIndex = 3;
            this.cbxClass.WatermarkText = "Select Class";
            this.cbxClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxClass_KeyPress);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::MIS.Properties.Resources.arrow_down;
            this.buttonX1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonX1.Location = new System.Drawing.Point(327, 3);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 20);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "Load";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtAdmNo
            // 
            this.txtAdmNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtAdmNo.Border.Class = "TextBoxBorder";
            this.txtAdmNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAdmNo.Location = new System.Drawing.Point(196, 3);
            this.txtAdmNo.Name = "txtAdmNo";
            this.txtAdmNo.Size = new System.Drawing.Size(125, 20);
            this.txtAdmNo.TabIndex = 1;
            this.txtAdmNo.WatermarkText = "Enter Admission No.";
            this.txtAdmNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdmNo_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(3, -1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(230, 26);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Students Fee";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::MIS.Properties.Resources.Add;
            this.btnAdd.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OptionGroup = "navBar";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnAdd.Text = "Add New";
            this.btnAdd.Tooltip = "Add New";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = global::MIS.Properties.Resources.edit;
            this.btnEdit.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OptionGroup = "navBar";
            this.btnEdit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.Tooltip = "Edit Selected";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::MIS.Properties.Resources.Preview;
            this.btnSearch.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OptionGroup = "navBar";
            this.btnSearch.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSearch.Text = "Search";
            this.btnSearch.Tooltip = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::MIS.Properties.Resources.RecycleBin;
            this.btnDelete.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OptionGroup = "navBar";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Tooltip = "Delete Selected";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::MIS.Properties.Resources.Print;
            this.btnPrint.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OptionGroup = "navBar";
            this.btnPrint.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP);
            this.btnPrint.Text = "Print";
            this.btnPrint.Tooltip = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPayed
            // 
            this.btnPayed.Checked = true;
            this.btnPayed.Image = global::MIS.Properties.Resources.money_add;
            this.btnPayed.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnPayed.Name = "btnPayed";
            this.btnPayed.OptionGroup = "navBar";
            this.btnPayed.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlUp);
            this.btnPayed.Text = "Set Payed";
            this.btnPayed.Tooltip = "Set Payed";
            this.btnPayed.Click += new System.EventHandler(this.btnPayed_Click_1);
            // 
            // btnNotPayed
            // 
            this.btnNotPayed.Image = global::MIS.Properties.Resources.money_delete;
            this.btnNotPayed.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnNotPayed.Name = "btnNotPayed";
            this.btnNotPayed.OptionGroup = "navBar";
            this.btnNotPayed.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDown);
            this.btnNotPayed.Text = "Set UnPayed";
            this.btnNotPayed.Click += new System.EventHandler(this.buttonItem3_Click);
            // 
            // btnCancelSlp
            // 
            this.btnCancelSlp.Image = global::MIS.Properties.Resources.Stop;
            this.btnCancelSlp.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnCancelSlp.Name = "btnCancelSlp";
            this.btnCancelSlp.OptionGroup = "navBar";
            this.btnCancelSlp.Text = "Cancel Slip";
            this.btnCancelSlp.Tooltip = "Cancel Slip";
            this.btnCancelSlp.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::MIS.Properties.Resources.Exit__2_1;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.OptionGroup = "navBar";
            this.btnClose.Text = "buttonItem1";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grdList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdList.BackgroundColor = System.Drawing.Color.White;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SFID,
            this.Status,
            this.SID,
            this.ReceiptNo,
            this.AdmNo,
            this.SName,
            this.CName,
            this.Scholarship,
            this.Year,
            this.Month,
            this.RegFee,
            this.AdFee,
            this.Security,
            this.ExamsFee,
            this.SportsFee,
            this.TutionFee,
            this.CollegeFund,
            this.ComputerFund,
            this.TransportFee,
            this.LateFee,
            this.Misc,
            this.PrevArrears,
            this.Total,
            this.Payed,
            this.PayDate,
            this.Arrears,
            this.Arrs,
            this.ClassID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdList.Location = new System.Drawing.Point(0, 26);
            this.grdList.MultiSelect = false;
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowHeadersWidth = 70;
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(1090, 616);
            this.grdList.TabIndex = 14;
            this.ttp.SetToolTip(this.grdList, "Cancel Slip");
            this.grdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdList_CellContentClick);
            this.grdList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdList_CellDoubleClick);
            this.grdList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdList_DataBindingComplete);
            // 
            // SFID
            // 
            this.SFID.DataPropertyName = "SFID";
            this.SFID.HeaderText = "FeeID";
            this.SFID.Name = "SFID";
            this.SFID.ReadOnly = true;
            this.SFID.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // SID
            // 
            this.SID.DataPropertyName = "SFID";
            this.SID.HeaderText = "SID";
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            this.SID.Visible = false;
            // 
            // ReceiptNo
            // 
            this.ReceiptNo.DataPropertyName = "ReceiptNo";
            this.ReceiptNo.HeaderText = "ReceiptNo";
            this.ReceiptNo.Name = "ReceiptNo";
            this.ReceiptNo.ReadOnly = true;
            this.ReceiptNo.Width = 60;
            // 
            // AdmNo
            // 
            this.AdmNo.DataPropertyName = "AdmNo";
            this.AdmNo.HeaderText = "Adm No";
            this.AdmNo.Name = "AdmNo";
            this.AdmNo.ReadOnly = true;
            this.AdmNo.Width = 60;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "Name";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "Class";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 50;
            // 
            // Scholarship
            // 
            this.Scholarship.DataPropertyName = "Scholarship";
            this.Scholarship.HeaderText = "Scholarship";
            this.Scholarship.Name = "Scholarship";
            this.Scholarship.ReadOnly = true;
            this.Scholarship.Width = 60;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 60;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Width = 50;
            // 
            // RegFee
            // 
            this.RegFee.DataPropertyName = "RegFee";
            this.RegFee.HeaderText = "Reg Fee";
            this.RegFee.Name = "RegFee";
            this.RegFee.ReadOnly = true;
            this.RegFee.Visible = false;
            this.RegFee.Width = 50;
            // 
            // AdFee
            // 
            this.AdFee.DataPropertyName = "AdFee";
            this.AdFee.HeaderText = "Adm Fee";
            this.AdFee.Name = "AdFee";
            this.AdFee.ReadOnly = true;
            this.AdFee.Visible = false;
            this.AdFee.Width = 50;
            // 
            // Security
            // 
            this.Security.DataPropertyName = "Security";
            this.Security.HeaderText = "Security";
            this.Security.Name = "Security";
            this.Security.ReadOnly = true;
            this.Security.Visible = false;
            this.Security.Width = 50;
            // 
            // ExamsFee
            // 
            this.ExamsFee.DataPropertyName = "ExamsFee";
            this.ExamsFee.HeaderText = "Exams Fee";
            this.ExamsFee.Name = "ExamsFee";
            this.ExamsFee.ReadOnly = true;
            this.ExamsFee.Visible = false;
            this.ExamsFee.Width = 50;
            // 
            // SportsFee
            // 
            this.SportsFee.DataPropertyName = "SportsFee";
            this.SportsFee.HeaderText = "Sports";
            this.SportsFee.Name = "SportsFee";
            this.SportsFee.ReadOnly = true;
            this.SportsFee.Visible = false;
            this.SportsFee.Width = 50;
            // 
            // TutionFee
            // 
            this.TutionFee.DataPropertyName = "TutionFee";
            this.TutionFee.HeaderText = "Tution";
            this.TutionFee.Name = "TutionFee";
            this.TutionFee.ReadOnly = true;
            this.TutionFee.Width = 50;
            // 
            // CollegeFund
            // 
            this.CollegeFund.DataPropertyName = "CollegeFund";
            this.CollegeFund.HeaderText = "Col. Fund";
            this.CollegeFund.Name = "CollegeFund";
            this.CollegeFund.ReadOnly = true;
            this.CollegeFund.Width = 50;
            // 
            // ComputerFund
            // 
            this.ComputerFund.DataPropertyName = "ComputerFund";
            this.ComputerFund.HeaderText = "Comp. Fee";
            this.ComputerFund.Name = "ComputerFund";
            this.ComputerFund.ReadOnly = true;
            this.ComputerFund.ToolTipText = "Admission Numbers";
            this.ComputerFund.Width = 50;
            // 
            // TransportFee
            // 
            this.TransportFee.DataPropertyName = "TransportFee";
            this.TransportFee.HeaderText = "Trans. Fee";
            this.TransportFee.Name = "TransportFee";
            this.TransportFee.ReadOnly = true;
            this.TransportFee.Width = 50;
            // 
            // LateFee
            // 
            this.LateFee.DataPropertyName = "LateFee";
            this.LateFee.HeaderText = "Late Fee";
            this.LateFee.Name = "LateFee";
            this.LateFee.ReadOnly = true;
            this.LateFee.Width = 50;
            // 
            // Misc
            // 
            this.Misc.DataPropertyName = "Misc";
            this.Misc.HeaderText = "Misc";
            this.Misc.Name = "Misc";
            this.Misc.ReadOnly = true;
            this.Misc.Width = 50;
            // 
            // PrevArrears
            // 
            this.PrevArrears.DataPropertyName = "PrevArrears";
            this.PrevArrears.HeaderText = "Prev. Arrears";
            this.PrevArrears.Name = "PrevArrears";
            this.PrevArrears.ReadOnly = true;
            this.PrevArrears.Width = 50;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 60;
            // 
            // Payed
            // 
            this.Payed.DataPropertyName = "Payed";
            this.Payed.HeaderText = "Paid";
            this.Payed.Name = "Payed";
            this.Payed.ReadOnly = true;
            this.Payed.Width = 60;
            // 
            // PayDate
            // 
            this.PayDate.DataPropertyName = "PayDate";
            this.PayDate.HeaderText = "Pay Date";
            this.PayDate.Name = "PayDate";
            this.PayDate.ReadOnly = true;
            this.PayDate.Width = 70;
            // 
            // Arrears
            // 
            this.Arrears.DataPropertyName = "Arrears";
            this.Arrears.HeaderText = "Cur. Arrears";
            this.Arrears.Name = "Arrears";
            this.Arrears.ReadOnly = true;
            this.Arrears.Width = 50;
            // 
            // Arrs
            // 
            this.Arrs.DataPropertyName = "Arrs";
            this.Arrs.HeaderText = "Tot. Arrears";
            this.Arrs.Name = "Arrs";
            this.Arrs.ReadOnly = true;
            this.Arrs.Visible = false;
            this.Arrs.Width = 60;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "Class ID";
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Visible = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSearch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlSearch.Controls.Add(this.rbDesignation);
            this.pnlSearch.Controls.Add(this.btnPanelExit);
            this.pnlSearch.Controls.Add(this.labelX3);
            this.pnlSearch.Controls.Add(this.labelX2);
            this.pnlSearch.Controls.Add(this.btnGo);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.rbName);
            this.pnlSearch.Location = new System.Drawing.Point(348, 221);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(394, 201);
            this.pnlSearch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlSearch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlSearch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlSearch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlSearch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlSearch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlSearch.Style.GradientAngle = 90;
            this.pnlSearch.TabIndex = 16;
            this.pnlSearch.Visible = false;
            // 
            // rbDesignation
            // 
            // 
            // 
            // 
            this.rbDesignation.BackgroundStyle.Class = "";
            this.rbDesignation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbDesignation.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rbDesignation.Location = new System.Drawing.Point(17, 81);
            this.rbDesignation.Name = "rbDesignation";
            this.rbDesignation.Size = new System.Drawing.Size(111, 23);
            this.rbDesignation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbDesignation.TabIndex = 2;
            this.rbDesignation.Text = "Designation";
            // 
            // btnPanelExit
            // 
            this.btnPanelExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPanelExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPanelExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPanelExit.Image = global::MIS.Properties.Resources.Exit__2_1;
            this.btnPanelExit.Location = new System.Drawing.Point(367, 0);
            this.btnPanelExit.Name = "btnPanelExit";
            this.btnPanelExit.Size = new System.Drawing.Size(27, 27);
            this.btnPanelExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPanelExit.TabIndex = 5;
            this.btnPanelExit.Click += new System.EventHandler(this.btnPanelExit_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(2, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(392, 26);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "  Search . . .";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(17, 129);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(111, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Enter Search Value";
            // 
            // btnGo
            // 
            this.btnGo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGo.Location = new System.Drawing.Point(345, 155);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(29, 23);
            this.btnGo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "GO";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Location = new System.Drawing.Point(17, 158);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(322, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // rbName
            // 
            // 
            // 
            // 
            this.rbName.BackgroundStyle.Class = "";
            this.rbName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbName.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rbName.Location = new System.Drawing.Point(17, 52);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(129, 23);
            this.rbName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbName.TabIndex = 1;
            this.rbName.Text = "Examiner Name";
            // 
            // ttp
            // 
            this.ttp.IsBalloon = true;
            this.ttp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ttp.ToolTipTitle = "Error";
            // 
            // frmFeeAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 642);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.grdList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFeeAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExaminers";
            this.Load += new System.EventHandler(this.frmFeeAdmission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).EndInit();
            this.navigationBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationBar navigationBar1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnSearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdList;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnPrint;
        private DevComponents.DotNetBar.PanelEx pnlSearch;
        private DevComponents.DotNetBar.Controls.CheckBoxX rbDesignation;
        private DevComponents.DotNetBar.ButtonX btnPanelExit;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnGo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.Controls.CheckBoxX rbName;
        private System.Windows.Forms.ToolTip ttp;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAdmNo;
        private DevComponents.DotNetBar.ButtonX btnLoadByClass;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn SFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scholarship;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Security;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamsFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportsFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutionFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegeFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn LateFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Misc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrevArrears;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payed;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrears;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private DevComponents.DotNetBar.ButtonItem btnPayed;
        private DevComponents.DotNetBar.ButtonItem btnNotPayed;
        private DevComponents.DotNetBar.ButtonItem btnCancelSlp;
        private DevComponents.DotNetBar.ButtonItem btnClose;
    }
}