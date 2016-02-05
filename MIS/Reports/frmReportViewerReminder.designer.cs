namespace MIS
{
    partial class frmReportViewerReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewerReminder));
            this.rptv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.navigationBar1 = new DevComponents.DotNetBar.NavigationBar();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.txtAdmNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAdmNo = new DevComponents.DotNetBar.LabelX();
            this.btnShow = new DevComponents.DotNetBar.ButtonX();
            this.chkMonthlyFee = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkOutstandingFee = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkFeeDefault = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // rptv
            // 
            this.rptv.ActiveViewIndex = -1;
            this.rptv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptv.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptv.Location = new System.Drawing.Point(0, 24);
            this.rptv.Name = "rptv";
            this.rptv.ShowCloseButton = false;
            this.rptv.ShowGotoPageButton = false;
            this.rptv.ShowGroupTreeButton = false;
            this.rptv.ShowPageNavigateButtons = false;
            this.rptv.Size = new System.Drawing.Size(1090, 618);
            this.rptv.TabIndex = 0;
            this.rptv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
         //   this.rptv.Load += new System.EventHandler(this.rptv_Load);
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
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar1.ItemPaddingBottom = 2;
            this.navigationBar1.ItemPaddingTop = 2;
            this.navigationBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClose});
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(1090, 26);
            this.navigationBar1.TabIndex = 5;
            this.navigationBar1.Text = "navigationBar1";
            // 
            // btnClose
            // 
            this.btnClose.Checked = true;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.OptionGroup = "navBar";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.btnClose.Text = "Close";
            this.btnClose.Tooltip = "Close Form";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // txtAdmNo
            // 
            // 
            // 
            // 
            this.txtAdmNo.Border.Class = "TextBoxBorder";
            this.txtAdmNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAdmNo.Location = new System.Drawing.Point(908, 28);
            this.txtAdmNo.Name = "txtAdmNo";
            this.txtAdmNo.Size = new System.Drawing.Size(94, 20);
            this.txtAdmNo.TabIndex = 3;
            this.txtAdmNo.TextChanged += new System.EventHandler(this.txtAdmNo_TextChanged);
            this.txtAdmNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceiptNo_KeyPress);
            // 
            // lblAdmNo
            // 
            this.lblAdmNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblAdmNo.BackgroundStyle.Class = "";
            this.lblAdmNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAdmNo.Location = new System.Drawing.Point(756, 27);
            this.lblAdmNo.Name = "lblAdmNo";
            this.lblAdmNo.SingleLineColor = System.Drawing.Color.Transparent;
            this.lblAdmNo.Size = new System.Drawing.Size(151, 28);
            this.lblAdmNo.TabIndex = 2;
            this.lblAdmNo.Text = "Enter Admission Number";
            // 
            // btnShow
            // 
            this.btnShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShow.Location = new System.Drawing.Point(1014, 27);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(57, 23);
            this.btnShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // chkMonthlyFee
            // 
            // 
            // 
            // 
            this.chkMonthlyFee.BackgroundStyle.Class = "";
            this.chkMonthlyFee.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkMonthlyFee.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkMonthlyFee.Location = new System.Drawing.Point(223, 27);
            this.chkMonthlyFee.Name = "chkMonthlyFee";
            this.chkMonthlyFee.Size = new System.Drawing.Size(202, 28);
            this.chkMonthlyFee.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkMonthlyFee.TabIndex = 6;
            this.chkMonthlyFee.Text = "Monthly Payment of Fee";
            // 
            // chkOutstandingFee
            // 
            // 
            // 
            // 
            this.chkOutstandingFee.BackgroundStyle.Class = "";
            this.chkOutstandingFee.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkOutstandingFee.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkOutstandingFee.Location = new System.Drawing.Point(564, 26);
            this.chkOutstandingFee.Name = "chkOutstandingFee";
            this.chkOutstandingFee.Size = new System.Drawing.Size(192, 28);
            this.chkOutstandingFee.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkOutstandingFee.TabIndex = 7;
            this.chkOutstandingFee.Text = "Outstanding Fee";
            // 
            // chkFeeDefault
            // 
            // 
            // 
            // 
            this.chkFeeDefault.BackgroundStyle.Class = "";
            this.chkFeeDefault.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFeeDefault.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkFeeDefault.Location = new System.Drawing.Point(425, 26);
            this.chkFeeDefault.Name = "chkFeeDefault";
            this.chkFeeDefault.Size = new System.Drawing.Size(142, 28);
            this.chkFeeDefault.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFeeDefault.TabIndex = 8;
            this.chkFeeDefault.Text = "Fee Default";
            // 
            // frmReportViewerReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 642);
            this.Controls.Add(this.chkFeeDefault);
            this.Controls.Add(this.chkOutstandingFee);
            this.Controls.Add(this.chkMonthlyFee);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblAdmNo);
            this.Controls.Add(this.txtAdmNo);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.rptv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportViewerReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmReportViewer";
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptv;
        private DevComponents.DotNetBar.NavigationBar navigationBar1;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        public DevComponents.DotNetBar.Controls.TextBoxX txtAdmNo;
        public DevComponents.DotNetBar.LabelX lblAdmNo;
        public DevComponents.DotNetBar.ButtonX btnShow;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkMonthlyFee;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkOutstandingFee;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFeeDefault;
    }
}