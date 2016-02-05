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
    public partial class frmChangePwd : Form
    {
       public int userid;
       public string uname;
       public string pwd;
       public string role;

        
        public frmChangePwd()
        {
            InitializeComponent();
        }

        private void frmChangePwd_Load(object sender, EventArgs e)
        {
            lblUserName.Text  = uname;
            lblLoginAs.Text  = role;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsValid()
        {

            if (txtOldPwd.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Old Password", txtOldPwd, 2000);
                return false;
            }
            if (txtOldPwd.Text != this.pwd)
            {
                ttp.Show(" Old Password is invalid", txtOldPwd, 2000);
                return false;
            }
            if (txtNewPwd.Text != txtCNewPwd.Text )
            {
                ttp.Show("Your New Password Does not Match.", txtCNewPwd, 2000);
                return false;
            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }
            frmMain frmmain = new frmMain();
            frmmain.pwd = this.txtNewPwd.Text;
            frmmain.Close();
           
            EUser d = new EUser();
            d.ChangePwd(userid, txtNewPwd.Text);
            MessageBox.Show("Password Changed");
                    
            this.Close();
            
        }
    }
}
