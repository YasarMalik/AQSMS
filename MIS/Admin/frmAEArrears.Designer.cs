namespace MIS
{
    partial class frmAEArrears
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtArrears = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.lblName = new DevComponents.DotNetBar.LabelX();
            this.lblSection = new DevComponents.DotNetBar.LabelX();
            this.lblClass = new DevComponents.DotNetBar.LabelX();
            this.lblAdmNo = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::MIS.Properties.Resources.Exit__2_1;
            this.btnClose.Location = new System.Drawing.Point(437, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Tooltip = "Click To Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::MIS.Properties.Resources.Save_b;
            this.btnSave.Location = new System.Drawing.Point(356, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSave.Tooltip = "Click To Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.labelX2.Location = new System.Drawing.Point(77, 162);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Arrears";
            // 
            // txtArrears
            // 
            // 
            // 
            // 
            this.txtArrears.Border.Class = "TextBoxBorder";
            this.txtArrears.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtArrears, true);
            this.txtArrears.Location = new System.Drawing.Point(162, 162);
            this.txtArrears.Name = "txtArrears";
            this.txtArrears.Size = new System.Drawing.Size(140, 20);
            this.txtArrears.TabIndex = 0;
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
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblName.BackgroundStyle.Class = "";
            this.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblName.Location = new System.Drawing.Point(251, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(284, 23);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblSection
            // 
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSection.BackgroundStyle.Class = "";
            this.lblSection.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSection.Location = new System.Drawing.Point(251, 101);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(138, 23);
            this.lblSection.TabIndex = 19;
            this.lblSection.Text = "Section";
            // 
            // lblClass
            // 
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblClass.BackgroundStyle.Class = "";
            this.lblClass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClass.Location = new System.Drawing.Point(77, 101);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(138, 23);
            this.lblClass.TabIndex = 20;
            this.lblClass.Text = "Class";
            // 
            // lblAdmNo
            // 
            this.lblAdmNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblAdmNo.BackgroundStyle.Class = "";
            this.lblAdmNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAdmNo.Location = new System.Drawing.Point(77, 70);
            this.lblAdmNo.Name = "lblAdmNo";
            this.lblAdmNo.Size = new System.Drawing.Size(138, 23);
            this.lblAdmNo.TabIndex = 21;
            this.lblAdmNo.Text = "AdmNo";
            // 
            // frmAEArrears
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIS.Properties.Resources.classy_and_authoritative_backgrounds_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 308);
            this.Controls.Add(this.lblAdmNo);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtArrears);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAEArrears";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAEUser";
            this.Load += new System.EventHandler(this.frmAEUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtArrears;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private System.Windows.Forms.ToolTip ttp;
        private DevComponents.DotNetBar.LabelX lblAdmNo;
        private DevComponents.DotNetBar.LabelX lblClass;
        private DevComponents.DotNetBar.LabelX lblSection;
        private DevComponents.DotNetBar.LabelX lblName;
    }
}