using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using BL;
//using MIS.Reports;
using MIS.Reports;

namespace MIS
{
    public partial class frmReportViewerReminder : Form
    {
       // public  string receiptno = "";
        //public frmReportViewerReminder(ReportClass rptClass)
        //{
        //    InitializeComponent();
        //    this.rptv.ReportSource = rptClass;
        //}
        public frmReportViewerReminder()
        {
            InitializeComponent();
            
        }
       private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       private void btnShow_Click(object sender, EventArgs e)

       {
           if (chkMonthlyFee.Checked == true)
           {
               if (txtAdmNo.Text == "")
               {
                   MessageBox.Show("Enter Admission Number", "Admission Number?", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }

               Fee d = new Fee();
               DataSet ds = d.MonthlyFeeRem(Convert.ToInt32(txtAdmNo.Text));
               if (ds.Tables[0].Rows.Count == 0)
               {
                   MessageBox.Show("Sorry No Report Exists", "No Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                   rptMonthlyFeeRem rpt = new rptMonthlyFeeRem();
                   rpt.SetDataSource(ds.Tables[0]);
                   this.rptv.ReportSource = rpt;

               }
           }
           else if (chkFeeDefault.Checked == true)
           {
               if (txtAdmNo.Text == "")
               {
                   MessageBox.Show("Enter Admission Number", "Admission Number?", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }

               Fee d = new Fee();
               DataSet ds = d.MonthlyFeeRem(Convert.ToInt32(txtAdmNo.Text));
               if (ds.Tables[0].Rows.Count == 0)
               {
                   MessageBox.Show("Sorry No Report Exists", "No Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                   rptFeeDefault rpt = new rptFeeDefault();
                   rpt.SetDataSource(ds.Tables[0]);
                   this.rptv.ReportSource = rpt;

               }
           }
           else if (chkOutstandingFee.Checked == true)
           {
               if (txtAdmNo.Text == "")
               {
                   MessageBox.Show("Enter Admission Number", "Admission Number?", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }

               Fee d = new Fee();
               DataSet ds = d.MonthlyFeeRem(Convert.ToInt32(txtAdmNo.Text));
               if (ds.Tables[0].Rows.Count == 0)
               {
                   MessageBox.Show("Sorry No Report Exists", "No Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                   rptOutstandingFee rpt = new rptOutstandingFee();
                   rpt.SetDataSource(ds.Tables[0]);
                   this.rptv.ReportSource = rpt;

               }
           }
           else
           {
               MessageBox.Show("Select Criteria", "Criteria", MessageBoxButtons.OK, MessageBoxIcon.Stop);
           }
           
       }

 

       private void txtReceiptNo_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (e.KeyChar == 13)
           {
               if (chkMonthlyFee.Checked == true)
               {
                   if (txtAdmNo.Text == "")
                   {
                       MessageBox.Show("Enter Admission Number", "Admission Number?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }

                   Fee d = new Fee();
                   DataSet ds = d.MonthlyFeeRem(Convert.ToInt32(txtAdmNo.Text));
                   if (ds.Tables[0].Rows.Count == 0)
                   {
                       MessageBox.Show("Sorry No Report Exists", "No Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                   else
                   {
                       rptMonthlyFeeRem rpt = new rptMonthlyFeeRem();
                       rpt.SetDataSource(ds.Tables[0]);
                       this.rptv.ReportSource = rpt;

                   }
               }
               else if (chkFeeDefault.Checked == true)
               {
                   if (txtAdmNo.Text == "")
                   {
                       MessageBox.Show("Enter Admission Number", "Admission Number?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }

                   Fee d = new Fee();
                   DataSet ds = d.MonthlyFeeRem(Convert.ToInt32(txtAdmNo.Text));
                   if (ds.Tables[0].Rows.Count == 0)
                   {
                       MessageBox.Show("Sorry No Report Exists", "No Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                   else
                   {
                       rptFeeDefault rpt = new rptFeeDefault();
                       rpt.SetDataSource(ds.Tables[0]);
                       this.rptv.ReportSource = rpt;

                   }
               }
               else if (chkOutstandingFee.Checked == true)
               {
                   if (txtAdmNo.Text == "")
                   {
                       MessageBox.Show("Enter Admission Number", "Admission Number?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }

                   Fee d = new Fee();
                   DataSet ds = d.MonthlyFeeRem(Convert.ToInt32(txtAdmNo.Text));
                   if (ds.Tables[0].Rows.Count == 0)
                   {
                       MessageBox.Show("Sorry No Report Exists", "No Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                   else
                   {
                       rptOutstandingFee rpt = new rptOutstandingFee();
                       rpt.SetDataSource(ds.Tables[0]);
                       this.rptv.ReportSource = rpt;

                   }
               }
               else
               {
                   MessageBox.Show("Select Criteria", "Criteria", MessageBoxButtons.OK, MessageBoxIcon.Stop);
               }

           }
       }

       private void frmReportViewer_Load(object sender, EventArgs e)
       {
        //   txtReceiptNo.Text=receiptno.ToString();
           //if ( txtAdmNo.Text!="")
           //{
           //    Fee d = new Fee();
           //    DataSet ds = d.LoadStudentFeeByReceipt(receiptno.ToString());
           //    if (ds.Tables[0].Rows.Count == 0)
           //    {
           //        MessageBox.Show("Sorry No Report Exists");
           //    }
           //    else
           //    {
           //        rptFeeReceipt rpt = new rptFeeReceipt();

           //        rpt.SetDataSource(ds.Tables[0]);
           //        this.rptv.ReportSource = rpt;

           //    }
           //}
       }

       private void txtAdmNo_TextChanged(object sender, EventArgs e)
       {

       }
   
    }
}
