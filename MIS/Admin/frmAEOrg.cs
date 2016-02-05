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
    public partial class frmAEOrg : Form
    {
        public frmAEOrg()
        {
            InitializeComponent();
        }
        private void LoadList()
        {
            EOrganization d = new EOrganization();
            DataTable dt = d.GetList();
            if (dt != null)
            {

                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtController.Text = dt.Rows[0]["Controller"].ToString();
                txtDyController.Text = dt.Rows[0]["DyController"].ToString();
                txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
              
            }
            
        }
        private void frmAEOrg_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EOrganization d = new EOrganization();
            d.Update(txtName.Text, txtController.Text, txtDyController.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text);
            MessageBox.Show("Record Updated");
            this.Close();
        }

        private void lblEnable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtName.Enabled = true;
            txtController.Enabled = true;
            txtDyController.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtAddress.Enabled = true;
            btnSave.Enabled = true;
        }

        
    }
}
