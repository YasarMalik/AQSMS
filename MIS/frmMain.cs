using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;







using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
//using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Common;

namespace MIS
{
    public partial class frmMain : Form
    {
       public  int  curruserid;
       public string currusername;
       public string role;
       public string pwd;
       Form currentForm = null;


        public frmMain()
        {
            InitializeComponent();
            currentForm = this;
        }

        public void OpenForm(Form frm)
        {
            //currentForm
            if (currentForm.Name != frm.Name || (currentForm.IsDisposed || currentForm.Disposing))
            {
                if (currentForm.Name != "frmMain") currentForm.Close();
                currentForm = frm;
                if (currentForm.Name != "frmMain")
                {
                    frm.Show();
                    frm.MdiParent = this;
         
                }
            }
        }
        private void frmMain_Load(object sender, EventArgs e)

        {
            if (MISCurrentSettings.curruid != 1)
            {
                lblAdminTasks.Visible = false;
                lblReports.Location = new Point(4, 133);
                lblExit.Location = new Point(4, 167);
            }
            if (MISCurrentSettings.curruid ==3)
            {

                lblAdminTasks.Enabled = false;
                lblArrearsList.Enabled = false;
                lblBaseEnt.Enabled = false;
                lblReports.Enabled = false;
                lblMarking.Enabled = false;

                lblReports.Location = new Point(4, 133);
                lblExit.Location = new Point(4, 167);
            }
            try
            {

             Utility.FormsLocation = new Point(this.Location.X + 30, this.Location.Y + 10);
             Utility.HomeForm = this;
             epLogin.TitleText = currusername+ "  @  " + role;
                //LoadStats();
                //LoadSettings();
               
            }
            catch (Exception ex)
            {
                Utility.WriteToLog(ex, this);
            }
        }

        private void lbExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void lbAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pBaseEnt.Show();
            pBaseEnt.Location = new Point(3, 3);
            pGeneral.Hide();
            pnlAdminTasks.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pGeneral.Show();
            pGeneral.Location = new Point(2, 3);
            pBaseEnt.Hide();
        }

        private void lblCenters_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //frmCenters frm = new frmCenters();
                //OpenForm(frm);
            }
            catch (Exception ex)
            {
                Utility.WriteToLog(ex, this);
            }
            
        }

        private void lblCourses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //try
            //{
            //    frmClass frm = new frmClass();
            //    OpenForm(frm);
            //}
            //catch (Exception ex)
            //{
            //    Utility.WriteToLog(ex, this);
            //}
        }

        private void lblSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void lblUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlAdminTasks.Show();
            pnlAdminTasks.Location = new Point(3, 3);
            pGeneral.Hide();
        }

        private void lblExaminers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
             //   frmExaminers  frm = new frmExaminers();
              //  OpenForm(frm);
            }
            catch (Exception ex)
            {
                Utility.WriteToLog(ex, this);
            }
           
        }

        private void lbExit_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void lblChangePwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePwd frm = new frmChangePwd();
            frm.uname = this.currusername;
            frm.pwd = this.pwd;
            frm.role = this.role;
            frm.userid = this.curruserid;
            frm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pGeneral.Show();
            pGeneral.Location = new Point(2, 3);
            pBaseEnt.Hide();
            pnlAdminTasks.Hide();
        }

        private void lblUsers_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmUsers frm = new frmUsers();
                OpenForm(frm);
            }
            catch (Exception ex)
            {
                Utility.WriteToLog(ex, this);
            }
        }

        private void lblBundles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmStudent frm = new frmStudent();
                OpenForm(frm);
            }
            catch (Exception ex)
            {
                Utility.WriteToLog(ex, this);
            }
        }

        private void lblOrganization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmAEOrg frm = new frmAEOrg();
            //OpenForm(frm);
        }

        private void lblMarking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmFeeAdmission frm = new frmFeeAdmission();
              OpenForm(frm);
            }
            catch (Exception ex)
            {
                Utility.WriteToLog(ex, this);
            }
        }

        private void lblCentralizedMarking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //try
            //{

            //    frmAEFeeAdmission frm = new frmAEFeeAdmission();
            //    OpenForm(frm);
            //}
            //catch (Exception ex)
            //{
            //    Utility.WriteToLog(ex, this);
            //}
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
               frmReports frm = new frmReports();
             OpenForm(frm);
            }
            catch (Exception ex)
            {
                Utility.WriteToLog(ex, this);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblArrearsList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmArrearsList frm = new frmArrearsList();
                OpenForm(frm);
            }
            catch (Exception ex)
            {
                Utility.WriteToLog(ex, this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backup();
        }
        public DataSet backup()
        {
            DbAccess db = new DbAccess();
            return db.ExecuteSPDataSet("backupdata");

        }

       
    }
}
