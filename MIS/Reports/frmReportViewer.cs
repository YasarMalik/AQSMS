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
    public partial class frmReportViewer : Form
    {
        public  string receiptno = "";
        public frmReportViewer(ReportClass rptClass)
        {
            InitializeComponent();
            this.rptv.ReportSource = rptClass;
        }
        public frmReportViewer()
        {
            InitializeComponent();
            
        }
       private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       private void btnShow_Click(object sender, EventArgs e)

       {
           if (txtReceiptNo .Text == "")
           {
               MessageBox.Show("Enter Letter No.");
           }

               Fee d = new Fee();
               DataSet ds = d.LoadStudentFeeByReceipt(txtReceiptNo .Text);
               if (ds.Tables[0].Rows.Count == 0)
               {
                   MessageBox.Show("Sorry No Report Exists");
               }
               else
               {
                   rptFeeReceipt rpt = new rptFeeReceipt();
                   rpt.SetDataSource(ds.Tables[0]);
                   this.rptv.ReportSource = rpt;

               }
       }

       private void rptv_Load(object sender, EventArgs e)
       {

       }

       private void txtReceiptNo_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (e.KeyChar == 13)
           {
               Fee d = new Fee();
               DataSet ds = d.LoadStudentFeeByReceipt(txtReceiptNo.Text);
               if (ds.Tables[0].Rows.Count == 0)
               {
                   MessageBox.Show("Sorry No Report Exists");
               }
               else
               {
                   rptFeeReceipt rpt = new rptFeeReceipt();
                   rpt.SetDataSource(ds.Tables[0]);
                   this.rptv.ReportSource = rpt;

               }
           }
       }

       private void frmReportViewer_Load(object sender, EventArgs e)
       {
           txtReceiptNo.Text=receiptno.ToString();
           if ( txtReceiptNo.Text!="")
           {
               Fee d = new Fee();
               DataSet ds = d.LoadStudentFeeByReceipt(receiptno.ToString());
               if (ds.Tables[0].Rows.Count == 0)
               {
                   MessageBox.Show("Sorry No Report Exists");
               }
               else
               {
                   rptFeeReceipt rpt = new rptFeeReceipt();

                   rpt.SetDataSource(ds.Tables[0]);
                   this.rptv.ReportSource = rpt;

               }
           }
       }
   
    }
}
