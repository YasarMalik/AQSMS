namespace MIS
{
    partial class frmChangePwd
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
            this.txtOldPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtNewPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblLoginAs = new DevComponents.DotNetBar.LabelX();
            this.lblUserName = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtCNewPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::MIS.Properties.Resources.Exit__2_1;
            this.btnClose.Location = new System.Drawing.Point(448, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(367, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 3;
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
            this.labelX3.Location = new System.Drawing.Point(23, 24);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(219, 23);
            this.labelX3.TabIndex = 24;
            this.labelX3.Text = "Change Password . . .";
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
            this.labelX2.Location = new System.Drawing.Point(61, 77);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 23);
            this.labelX2.TabIndex = 25;
            this.labelX2.Text = "User Name";
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
            this.labelX1.Location = new System.Drawing.Point(127, 198);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(101, 23);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "Enter Old Pwd";
            // 
            // txtOldPwd
            // 
            // 
            // 
            // 
            this.txtOldPwd.Border.Class = "TextBoxBorder";
            this.txtOldPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOldPwd.FocusHighlightEnabled = true;
            this.txtOldPwd.Location = new System.Drawing.Point(248, 198);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(275, 20);
            this.txtOldPwd.TabIndex = 0;
            this.txtOldPwd.WatermarkText = "Enter Old Password";
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
            this.labelX4.Location = new System.Drawing.Point(61, 107);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(101, 23);
            this.labelX4.TabIndex = 29;
            this.labelX4.Text = "Loged As";
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
            this.labelX5.Location = new System.Drawing.Point(127, 232);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(101, 23);
            this.labelX5.TabIndex = 31;
            this.labelX5.Text = "Enter New Pwd";
            // 
            // txtNewPwd
            // 
            // 
            // 
            // 
            this.txtNewPwd.Border.Class = "TextBoxBorder";
            this.txtNewPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPwd.FocusHighlightEnabled = true;
            this.txtNewPwd.Location = new System.Drawing.Point(248, 232);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(275, 20);
            this.txtNewPwd.TabIndex = 1;
            this.txtNewPwd.WatermarkText = "Enter New Password";
            // 
            // lblLoginAs
            // 
            this.lblLoginAs.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblLoginAs.BackgroundStyle.Class = "";
            this.lblLoginAs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLoginAs.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAs.Location = new System.Drawing.Point(168, 106);
            this.lblLoginAs.Name = "lblLoginAs";
            this.lblLoginAs.Size = new System.Drawing.Size(355, 23);
            this.lblLoginAs.TabIndex = 32;
            this.lblLoginAs.Text = "LA";
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblUserName.BackgroundStyle.Class = "";
            this.lblUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUserName.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(168, 77);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(355, 23);
            this.lblUserName.TabIndex = 33;
            this.lblUserName.Text = "UN";
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
            this.labelX8.Location = new System.Drawing.Point(127, 263);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(115, 23);
            this.labelX8.TabIndex = 35;
            this.labelX8.Text = "Confirm New Pwd";
            // 
            // txtCNewPwd
            // 
            // 
            // 
            // 
            this.txtCNewPwd.Border.Class = "TextBoxBorder";
            this.txtCNewPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCNewPwd.FocusHighlightEnabled = true;
            this.txtCNewPwd.Location = new System.Drawing.Point(248, 263);
            this.txtCNewPwd.Name = "txtCNewPwd";
            this.txtCNewPwd.PasswordChar = '*';
            this.txtCNewPwd.Size = new System.Drawing.Size(275, 20);
            this.txtCNewPwd.TabIndex = 2;
            this.txtCNewPwd.WatermarkText = "Re Enter New Password";
            // 
            // ttp
            // 
            this.ttp.IsBalloon = true;
            this.ttp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ttp.ToolTipTitle = "Error";
            // 
            // frmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIS.Properties.Resources.classy_and_authoritative_backgrounds_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 403);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtCNewPwd);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblLoginAs);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtOldPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePwd";
            this.Load += new System.EventHandler(this.frmChangePwd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOldPwd;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPwd;
        private DevComponents.DotNetBar.LabelX lblLoginAs;
        private DevComponents.DotNetBar.LabelX lblUserName;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCNewPwd;
        private System.Windows.Forms.ToolTip ttp;
    }
}