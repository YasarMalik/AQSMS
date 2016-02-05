using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using BL;


namespace MIS
{
    public partial class frmLogin : Form
    {
      
        public frmLogin()
        {
            InitializeComponent();
            
           
        }
        private void FillRoleCombo()
        {
            EUser c = new EUser();

            DataTable dt = c.GetRoles();

            cbxRole.DataSource = dt;
            cbxRole.DisplayMember = "RoleName";
            cbxRole.ValueMember = "RoleID";

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Creating circle path
            FillRoleCombo();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 400, 400);
            this.Region = new Region(path);
           
           
        }
        private void LoadList()
        {
            EUser  c = new EUser();
            DataSet ds = c.GetListSpecific(txtUserName.Text,txtPassword.Text,Convert.ToInt32(cbxRole.SelectedValue));
            if (ds.Tables[0].Rows.Count > 0)
            {
                
                

                frmMain frm = new frmMain();
                
                frm.curruserid = Convert.ToInt32(ds.Tables[0].Rows[0]["UID"]);
                
                frm.currusername = txtUserName.Text;
                frm.pwd = txtPassword.Text;
                frm.role = cbxRole.Text;
                MISCurrentSettings.curruid = Convert.ToInt32(ds.Tables[0].Rows[0]["UID"]);
                frm.Show();
                this.Hide();
               
            }
            else
            {
               SpeechSynthesizer  ss = new SpeechSynthesizer();
               // MessageBox.Show("Sorry Your Login Information not Valid, Try Again");
                ttp.Show("Sorry Your Login Information not Valid, Please Try Again", txtPassword, 3000);
                ss.SpeakAsync("Sorry Your Login Information not Valid, Please Try Again");
               
            }

            
        }
        private void checklogin()
        {
            LoadList();       

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                //frmMain frm = new frmMain();
                //frm.Show();
                //this.Hide();
           
            //string date=DateTime.Now.Date.ToString();
            //string closedate = "11/10/2013";
            // int c = string.Compare(date, closedate);
            //if (c==-1)
            //{
            //    MessageBox.Show("You can not use this Software any more. Access Denied.","From Yasar Malik",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            //    Application.Exit();
            //}

            checklogin();
         }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //frmBackup f = new frmBackup();
            //f.Show();

        }
    }
}
