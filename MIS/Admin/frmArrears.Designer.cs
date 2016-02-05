namespace MIS
{
    partial class frmArrears
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
            this.btnCheckArrs = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblArrears = new DevComponents.DotNetBar.LabelX();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblArrTitle = new DevComponents.DotNetBar.LabelX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::MIS.Properties.Resources.Exit__2_1;
            this.btnClose.Location = new System.Drawing.Point(362, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Tooltip = "Click To Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnCheckArrs
            // 
            this.btnCheckArrs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckArrs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckArrs.Location = new System.Drawing.Point(269, 226);
            this.btnCheckArrs.Name = "btnCheckArrs";
            this.btnCheckArrs.Size = new System.Drawing.Size(87, 23);
            this.btnCheckArrs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckArrs.TabIndex = 6;
            this.btnCheckArrs.Text = "Check Arrears";
            this.btnCheckArrs.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnCheckArrs.Tooltip = "Check Arrears";
            this.btnCheckArrs.Click += new System.EventHandler(this.btnSave_Click);
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
            this.labelX3.Location = new System.Drawing.Point(12, 18);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(163, 23);
            this.labelX3.TabIndex = 15;
            this.labelX3.Text = "Arrears of a Student";
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
            this.labelX2.Location = new System.Drawing.Point(86, 78);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(158, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Enter Admission Number";
            // 
            // lblArrears
            // 
            this.lblArrears.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblArrears.BackgroundStyle.Class = "";
            this.lblArrears.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblArrears.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrears.ForeColor = System.Drawing.Color.Red;
            this.lblArrears.Location = new System.Drawing.Point(250, 158);
            this.lblArrears.Name = "lblArrears";
            this.lblArrears.Size = new System.Drawing.Size(191, 34);
            this.lblArrears.TabIndex = 14;
            this.lblArrears.Text = "Arrears";
            this.lblArrears.Visible = false;
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtUserName, true);
            this.txtUserName.Location = new System.Drawing.Point(250, 81);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(191, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.WatermarkText = "Enter Admission Number";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblArrTitle
            // 
            this.lblArrTitle.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblArrTitle.BackgroundStyle.Class = "";
            this.lblArrTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblArrTitle.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrTitle.Location = new System.Drawing.Point(86, 164);
            this.lblArrTitle.Name = "lblArrTitle";
            this.lblArrTitle.Size = new System.Drawing.Size(70, 23);
            this.lblArrTitle.TabIndex = 14;
            this.lblArrTitle.Text = "Arrears";
            this.lblArrTitle.Visible = false;
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // ttp
            // 
            this.ttp.IsBalloon = true;
            this.ttp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ttp.ToolTipTitle = "Error";
            // 
            // frmArrears
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIS.Properties.Resources.classy_and_authoritative_backgrounds_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 308);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCheckArrs);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.lblArrTitle);
            this.Controls.Add(this.lblArrears);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArrears";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAEUser";
            this.Load += new System.EventHandler(this.frmAEUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnCheckArrs;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblArrears;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        private DevComponents.DotNetBar.LabelX lblArrTitle;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private System.Windows.Forms.ToolTip ttp;
    }
}