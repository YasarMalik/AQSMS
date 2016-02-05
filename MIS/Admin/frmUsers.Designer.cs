namespace MIS
{
    partial class frmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.grdList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navigationBar1 = new DevComponents.DotNetBar.NavigationBar();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnSearch = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).BeginInit();
            this.navigationBar1.SuspendLayout();
            this.SuspendLayout();
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
            this.labelX1.Location = new System.Drawing.Point(3, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(242, 26);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "List of Users";
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.BackgroundColor = System.Drawing.Color.White;
            this.grdList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.RoleID,
            this.RoleName,
            this.Section,
            this.Designation,
            this.CNIC,
            this.Password});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdList.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdList.Location = new System.Drawing.Point(0, 25);
            this.grdList.MultiSelect = false;
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdList.RowHeadersWidth = 70;
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(1090, 617);
            this.grdList.TabIndex = 11;
            this.grdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdList_CellContentClick);
            this.grdList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdList_DataBindingComplete);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Visible = false;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.HeaderText = "Role ID";
            this.RoleID.Name = "RoleID";
            this.RoleID.ReadOnly = true;
            this.RoleID.Visible = false;
            this.RoleID.Width = 400;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "RoleName";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Width = 200;
            // 
            // Section
            // 
            this.Section.DataPropertyName = "Section";
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            this.Section.Width = 150;
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "Designation";
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            this.Designation.Width = 150;
            // 
            // CNIC
            // 
            this.CNIC.DataPropertyName = "CNIC";
            this.CNIC.HeaderText = "CNIC";
            this.CNIC.Name = "CNIC";
            this.CNIC.ReadOnly = true;
            this.CNIC.Width = 150;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            this.Password.Width = 150;
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
            this.navigationBar1.Controls.Add(this.labelX1);
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar1.ItemPaddingBottom = 2;
            this.navigationBar1.ItemPaddingTop = 2;
            this.navigationBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddNew,
            this.btnEdit,
            this.btnSearch,
            this.btnDelete,
            this.btnPrint,
            this.buttonItem2,
            this.buttonItem3,
            this.btnClose});
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(1090, 26);
            this.navigationBar1.TabIndex = 12;
            this.navigationBar1.Text = "navigationBar1";
            this.navigationBar1.Click += new System.EventHandler(this.navigationBar1_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = global::MIS.Properties.Resources.Add;
            this.btnAddNew.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.OptionGroup = "navBar";
            this.btnAddNew.Text = "Add New User";
            this.btnAddNew.Tooltip = "Add New User";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Checked = true;
            this.btnEdit.Image = global::MIS.Properties.Resources.edit;
            this.btnEdit.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OptionGroup = "navBar";
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.Tooltip = "Edit Selected";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::MIS.Properties.Resources.Preview;
            this.btnSearch.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OptionGroup = "navBar";
            this.btnSearch.Text = "Search";
            this.btnSearch.Tooltip = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::MIS.Properties.Resources.RecycleBin;
            this.btnDelete.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OptionGroup = "navBar";
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::MIS.Properties.Resources.Print;
            this.btnPrint.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OptionGroup = "navBar";
            this.btnPrint.Text = "Print";
            this.btnPrint.Tooltip = "Print";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.OptionGroup = "navBar";
            this.buttonItem2.Text = "buttonItem2";
            // 
            // buttonItem3
            // 
            this.buttonItem3.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem3.Image")));
            this.buttonItem3.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.OptionGroup = "navBar";
            this.buttonItem3.Text = "buttonItem3";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.OptionGroup = "navBar";
            this.btnClose.Text = "Close Form";
            this.btnClose.Tooltip = "Close Form";
            this.btnClose.Click += new System.EventHandler(this.buttonItem5_Click_1);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1090, 642);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.grdList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).EndInit();
            this.navigationBar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdList;
        private DevComponents.DotNetBar.NavigationBar navigationBar1;
        private DevComponents.DotNetBar.ButtonItem btnAddNew;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnSearch;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private DevComponents.DotNetBar.ButtonItem btnPrint;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem btnClose;


    }
}