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
    public partial class frmAEUser : Form
    {
        DataRowView dataBoundItem;
        //bool edit = false;
        public frmAEUser()
        {
            InitializeComponent();
        }

        public frmAEUser(DataRowView dt)
        {
            InitializeComponent();
            dataBoundItem = dt;
        }
        private bool IsValid()
        {
            
            if ( txtUserName.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter User Name", txtUserName, 2000);
                return false;
            }
            
            if (txtPassword.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Password", txtPassword, 2000);
                return false;
            }
                if (cbxRole.Text.Trim().Length == 0)
            {
                ttp.Show("Please Select User Role", cbxRole, 2000);
                return false;
            }
            if (txtDept.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Dept. or Section", txtDept, 2000);
                return false;
            }
            if (txtDesig.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Designation", txtDesig, 2000);
                return false;
            }

          

            return true;
        }
        private void FillRoleCombo()
        {
            
            EUser c = new EUser();
            DataTable dt = c.GetRole();
            cbxRole.DataSource = dt;
            cbxRole.DisplayMember = "RoleName";
            cbxRole.ValueMember = "RoleID";
            

        }
        private void frmAEUser_Load(object sender, EventArgs e)
        {
            FillRoleCombo();
            if (dataBoundItem != null)
            {

                txtUserName.Text = dataBoundItem["UserName"].ToString();
                txtPassword.Text = dataBoundItem["Password"].ToString();
                cbxRole.Text = dataBoundItem["RoleName"].ToString();
                txtDept.Text = dataBoundItem["Section"].ToString();
                txtDesig.Text = dataBoundItem["Designation"].ToString();
                txtCNIC.Text = dataBoundItem["CNIC"].ToString();

                //edit = true;
            }
        }

       private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EUser d = new EUser();
            try
            {
                if (!IsValid())
                {
                    return;
                }
                d.UserName = txtUserName.Text;
                d.Password = txtPassword.Text;
                d.RoleID = Convert.ToInt32(cbxRole.SelectedValue);
                d.Department = txtDept.Text;
                d.Designation = txtDesig.Text;
                d.CNIC = txtCNIC.Text;

               
                if (dataBoundItem != null)
                {

                    d.UserID = Convert.ToInt32(dataBoundItem["UID"]);
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
    }
}
