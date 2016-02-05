using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using MIS.Reports;
using BL;

namespace MIS
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

        }

        private void btnCourseRpt_Click(object sender, EventArgs e)
        {
           


            //ECourse d = new ECourse();
            //DataSet ds = d.GetList();
            //rptCourses rpt = new rptCourses();
         
            //rpt.SetDataSource(ds.Tables[0]);
            //frmReportViewer frm = new frmReportViewer(rpt);
            //frm.Location = new Point(this.Location.X + 103, this.Location.Y + 65);
            //frm.ShowDialog();
        }

        private void btnViewCenter_Click(object sender, EventArgs e)
        {
            frmReportViewer frm = new frmReportViewer();
            frm.Location = new Point(this.Location.X + 170, this.Location.Y + 65);
            frm.ShowDialog();


            //ECenter d = new ECenter();
            //DataSet ds = d.GetList();
            //rptCenters rpt = new rptCenters();
            
            //rpt.SetDataSource(ds.Tables[0]);
            //frmReportViewer frm = new frmReportViewer(rpt);
            //frm.Location = new Point(this.Location.X + 103, this.Location.Y + 65);
            //frm.ShowDialog();
        }

        private void btnViewExaminer_Click(object sender, EventArgs e)
        {
            //EExaminer d = new EExaminer();
            //DataSet ds = d.GetList();
            //rptExaminers rpt = new rptExaminers();
           
            //rpt.SetDataSource(ds.Tables[0]);
            //frmReportViewer frm = new frmReportViewer(rpt);
            //frm.Location = new Point(this.Location.X + 103, this.Location.Y + 65);
            //frm.ShowDialog();
        }

      

       private void btnViewAllBundles_Click(object sender, EventArgs e)
        {
            //EBundle d = new EBundle();
            //DataSet ds = d.GetList();
            //rptBundlesByAllCenters rpt = new rptBundlesByAllCenters();

            //rpt.SetDataSource(ds.Tables[0]);
            //frmReportViewer frm = new frmReportViewer(rpt);
            //frm.Location = new Point(this.Location.X + 103, this.Location.Y + 65);
            //frm.ShowDialog();
        }

        private void btnDeptMrk_Click(object sender, EventArgs e)
        {
            //frmReportViewerReminder frm = new frmReportViewerReminder();
           // frm.Location = new Point(this.Location.X + 170, this.Location.Y + 65);
          //  frm.ShowDialog();

           // frmReportViewer frm = new frmReportViewer();
           // frm.Location = new Point(this.Location.X + 103, this.Location.Y + 65);
           //// frm.Location = new Point(this.Location.X - 255, this.Location.Y - 165);
           // frm.txtLetterNo.Visible = true;
           // frm.lblLetterNo.Visible = true;
           // frm.btnShow.Visible = true;
           // frm.rbtDeptMrk.Visible = true;
           // frm.rbtCentMrk.Visible = true;
           // frm.ShowDialog();
        }

      

        private void btnBCE_Click(object sender, EventArgs e)
        {
            //frmViewerCourseOrCenterWise frm = new frmViewerCourseOrCenterWise();
            //frm.Location = new Point(this.Location.X + 103, this.Location.Y + 65);
            //frm.ShowDialog();

        }

      

      
    }
}
