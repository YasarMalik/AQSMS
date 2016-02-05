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
    public partial class frmAEClass : Form
    {
        DataRowView dataBoundItem;
        //bool edit = false;
        public frmAEClass()
        {
            InitializeComponent();
           
        }

        public frmAEClass(DataRowView dt)
        {
            InitializeComponent();
            dataBoundItem = dt;
           // Utility.ApplyNumericOnlyFormat(txtCName);
        }
        private bool IsValid()
        {
            
            if ( txtCName.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Class Name", txtCName, 2000);
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

                txtCName.Text = dataBoundItem["CName"].ToString();

                txtDesc.Text = dataBoundItem["Desc"].ToString();

                //edit = true;
            }
        }

       private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EClass d = new EClass();
            try
            {
                if (!IsValid())
                {
                    return;
                }

                d.CName = txtCName.Text;
                d.Desc = txtDesc.Text;

              
                if (dataBoundItem != null)
                {

                    d.CID =Convert.ToInt16( dataBoundItem["ClassID"].ToString());
                    d.Update();
                }
                else
                {
                    d.Insert();
                }

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

        private void txtArrears_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
