using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;

namespace MIS
{
    public partial class frmAEArrears : Form
    {
        DataRowView dataBoundItem;
        //bool edit = false;
        public frmAEArrears()
        {
            InitializeComponent();
           
        }

        public frmAEArrears(DataRowView dt)
        {
            InitializeComponent();
            dataBoundItem = dt;
            Utility.ApplyNumericOnlyFormat(txtArrears);
        }
        private bool IsValid()
        {
            
            if ( txtArrears.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Arrears", txtArrears, 2000);
                return false;
            }

            return true;
        }
        //private void FillRoleCombo()
        //{
            
        //    EUser c = new EUser();
        //    DataTable dt = c.GetRole();
        //  //  cbxRole.DataSource = dt;
        //  //  cbxRole.DisplayMember = "RoleName";
        //  //  cbxRole.ValueMember = "RoleID";
            

        //}
        private void frmAEUser_Load(object sender, EventArgs e)
        {
           // FillRoleCombo();
            if (dataBoundItem != null)
            {

                txtArrears.Text = dataBoundItem["Arrs"].ToString();
                
                lblAdmNo.Text= dataBoundItem["AdmNo"].ToString();
                lblName.Text = dataBoundItem["SName"].ToString();
                lblClass.Text = dataBoundItem["CName"].ToString();
                lblSection.Text= dataBoundItem["Section"].ToString();
            

                //edit = true;
            }
        }

       private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Fee d = new Fee();
            try
            {
                if (!IsValid())
                {
                    return;
                }
                d.AdmNo =Convert.ToInt32(lblAdmNo.Text);
                d.CurrArrears = Convert.ToInt32(txtArrears.Text);

              
                if (dataBoundItem != null)
                {

                    
                    d.UpdateArrears();
                }
                //else
                //{
                //    d.InsertArrears();
                //}

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Utility.WriteToLog(ex, this);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
