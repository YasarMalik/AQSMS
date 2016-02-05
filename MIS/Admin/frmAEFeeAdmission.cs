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
    public partial class frmAEFeeAdmission : Form
    {
        DataRowView dataBoundItem;
        bool edit = false;
        string ANo;
        string rforprint; //receipt number for printing
       
       
        public frmAEFeeAdmission()
        {
            InitializeComponent();
            Utility.ApplyNumericOnlyFormat(txtAdmNo);
            Utility.ApplyNumericOnlyFormat(txtRegFee);
            Utility.ApplyNumericOnlyFormat(txtScholarship);
            Utility.ApplyNumericOnlyFormat(txtSecurity);
            Utility.ApplyNumericOnlyFormat(txtTutionFee);
            Utility.ApplyNumericOnlyFormat(txtTransportFee);
            Utility.ApplyNumericOnlyFormat(txtFine);
            Utility.ApplyNumericOnlyFormat(txtCollegeFund);
            Utility.ApplyNumericOnlyFormat(txtCollegeFund);
            Utility.ApplyNumericOnlyFormat(txtPayed);
            Utility.ApplyNumericOnlyFormat(txtPrevArrears);
            Utility.ApplyNumericOnlyFormat(txtSportsFee);
            Utility.ApplyNumericOnlyFormat(txtExamFee);
            

        }
        public frmAEFeeAdmission(DataRowView dt)
        {
            InitializeComponent();
            dataBoundItem = dt;
        }
        public frmAEFeeAdmission(string admno)
        {
            InitializeComponent();
            ANo = admno;
        }

        private void frmAECenter_Load(object sender, EventArgs e)
        {
           // FillClassCombo();

            //if (pbStudent.Image == MIS.Properties.Resources.NoImage)
            //{
            //    btnRemovePic.Enabled = false;
            //}
            if (dataBoundItem == null)
            {
                txtAdmNo.Text = ANo.ToString();


                dtPayDate.Value = DateTime.Now;
            }

            int month = (Convert.ToInt32(DateTime.Now.Month) + 1);

            if (month > 12)
            {
                cbxMonth.Text = "1";
            }
            else
            {
                cbxMonth.Text = (Convert.ToInt32(DateTime.Now.Month) + 1).ToString();
            }
           // cbxMonth.Text =(Convert.ToInt32( DateTime.Now.Month)+1).ToString();


            if (Convert.ToInt32(DateTime.Now.Month) == 12)
            {
                cbxYear.Text = (Convert.ToInt32(DateTime.Now.Year) + 1).ToString();
            }

            else
            {
                cbxYear.Text = DateTime.Now.Year.ToString();
            }

            if (dataBoundItem != null)
            {
                txtAdmNo.Text = dataBoundItem["AdmNo"].ToString();
             //  dtAdmDate.Value = Convert.ToDateTime(dataBoundItem["AdmDate"]);
                lblSName.Text = dataBoundItem["SName"].ToString();
                txtRegFee.Text = dataBoundItem["RegFee"].ToString();
                txtAdmFee.Text = dataBoundItem["AdFee"].ToString();
                txtSecurity.Text = dataBoundItem["Security"].ToString();
                txtExamFee.Text = dataBoundItem["ExamsFee"].ToString();
                txtSportsFee.Text = dataBoundItem["SportsFee"].ToString();
                txtTutionFee.Text = dataBoundItem["TutionFee"].ToString();
                txtCollegeFund.Text = dataBoundItem["CollegeFund"].ToString();
                txtCompFee.Text = dataBoundItem["ComputerFund"].ToString();
                txtTransportFee.Text = dataBoundItem["TransportFee"].ToString();
                txtFine.Text = dataBoundItem["LateFee"].ToString();
                txtMisc.Text = dataBoundItem["Misc"].ToString();
                txtScholarship.Text = dataBoundItem["ScholarShip"].ToString();
                cbxMonth.Text = dataBoundItem["Month"].ToString();
                cbxYear.Text = dataBoundItem["Year"].ToString();
                txtArrears.Text = dataBoundItem["Arrears"].ToString();
                txtPayed.Text = dataBoundItem["Payed"].ToString();
                dtPayDate.Value =Convert.ToDateTime(dataBoundItem["PayDate"]);
               txtPrevArrears.Text = dataBoundItem["PrevArrears"].ToString();
                //txtPrevArrears.Text = "0";
                txtGT.Text = dataBoundItem["Total"].ToString();

                txtAdmNo.Visible = false;
                btnLoadFee.Visible = false;
                chkFeeType.Visible = false;


                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private bool IsValid()
        {

            if (txtAdmNo.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Admission Number", txtAdmNo, 2000);
                return false;
            }


            if (cbxMonth.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Month", cbxMonth, 2000);
                return false;
            }

            if (cbxYear.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Year", cbxYear, 2000);
                return false;
            }
            if (txtPayed.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Amount Paying", txtPayed, 2000);
                return false;
            }

            if (dtPayDate.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Enter Paying Date", dtPayDate, 2000);
                return false;
            }
            //else if (ECenter.CenterExists(txtAdmNo.Text) && edit == false) //for duplicates
            //{
            //    ttp.Show("Center Code Already Exists", txtAdmNo, 2000);
            //    return false;
            //}

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
          
            if (!IsValid())
            {
                return;
            }
            if (save() == true)
            {
                MessageBox.Show("Transaction Saved/Updated Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Problems in Saving Transaction", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

           
        }

        private bool save()
        {
           
            Fee d = new Fee();
            try
            {
                d.AdmNo = Convert.ToInt32(txtAdmNo.Text);
                d.Year = cbxYear.Text;
                d.Month = cbxMonth.Text;

                d.RegFee = Convert.ToInt32(txtRegFee.Text);
                d.AdmFee = Convert.ToInt32(txtAdmFee.Text);
                d.SecFee = Convert.ToInt32(txtSecurity.Text);
                d.ExamsFee = Convert.ToInt32(txtExamFee.Text);
                d.SportsFee = Convert.ToInt32(txtSportsFee.Text);
                d.TutionFee = Convert.ToInt32(txtTutionFee.Text);
                d.CollegeFund = Convert.ToInt32(txtCollegeFund.Text);
                d.CompFee = Convert.ToInt32(txtCompFee.Text);
                d.TransportFee = Convert.ToInt32(txtTransportFee.Text);
                d.LateFee = Convert.ToInt32(txtFine.Text);
                d.Misc = Convert.ToInt32(txtMisc.Text);
                d.Total = Convert.ToInt32(txtGT.Text);
                d.Payed = Convert.ToInt32(txtPayed.Text);
                d.PayDate = dtPayDate.Value;
                d.CurrArrears = Convert.ToInt32(txtArrears.Text);
                d.PrevArrears = Convert.ToInt32(txtPrevArrears.Text);


                if (dataBoundItem != null)
                {
                    d.RecptNo = dataBoundItem["ReceiptNo"].ToString();
                    d.SID = Convert.ToInt32(dataBoundItem["SID"]);
                    d.SFID = Convert.ToInt32(dataBoundItem["SFID"]);
                    d.ClassID = Convert.ToInt32(dataBoundItem["ClassID"]);
                    rforprint = dataBoundItem["ReceiptNo"].ToString();
                    d.Update();

                    
                }
                else
                {
                    //int Min = DateTime.Now.Minute;
                    //int Sec = DateTime.Now.Second;
                    string recepno;
                    string mno;
                    Fee f = new Fee();
                    DataTable dt = f.TotrecpNos(Convert.ToInt32(txtAdmNo.Text));
                    DataTable dt2 = f.GetMaxRecpNo(Convert.ToInt32(txtAdmNo.Text));


                    //  mno = Convert.ToInt32(dt.Rows[0]["MaxRNo"].ToString());

                    if (Convert.ToInt32(dt.Rows[0]["trecpno"]) == 0)
                    {
                        recepno = txtAdmNo.Text + "-" + "1";
                        rforprint = recepno;

                    }

                    else
                    {
                        mno = dt2.Rows[0]["RecptIndx"].ToString();
                        // string[] splitArray = mno.Split(new char[] { '-' });
                        //    recepno = txtAdmNo.Text + "-" + Convert.ToString(Convert.ToInt32(splitArray[1]) + 1);
                        recepno = txtAdmNo.Text + "-" + Convert.ToString(Convert.ToInt32(mno) + 1);
                        rforprint = recepno;

                    }

                    // MessageBox.Show(recepno.ToString());

                    d.RecptNo = recepno.ToString();

                    d.Insert();
                }
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Utility.WriteToLog(ex, this);
            }
            return true;
        }
        private void LoadFeeAdmission()
        {
            if (txtAdmNo.Text == "")
            {
            }
            else
            {

                Fee d = new Fee();
                DataSet ds;
                
                ///////////////////////////////////////////////////

                ds = d.LoadOldFee(Convert.ToInt32(txtAdmNo.Text)); // loads fee from studentfee table
                if (ds.Tables[0].Rows.Count == 0)
                {
                    ds = d.LoadFreshFee(Convert.ToInt32(txtAdmNo.Text)); // loads fee from feestructuer
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lblSName.Text = ds.Tables[0].Rows[0]["SName"].ToString();
                        lblClass.Text = ds.Tables[0].Rows[0]["CName"].ToString();
                        txtRegFee.Text = ds.Tables[0].Rows[0]["Amount"].ToString();
                        txtAdmFee.Text = ds.Tables[0].Rows[1]["Amount"].ToString();
                        txtSecurity.Text = ds.Tables[0].Rows[2]["Amount"].ToString();
                        txtExamFee.Text = ds.Tables[0].Rows[3]["Amount"].ToString();
                        txtSportsFee.Text = ds.Tables[0].Rows[4]["Amount"].ToString();
                        //    int tution = (Convert.ToInt32(ds.Tables[0].Rows[5]["Amount"]) - Convert.ToInt32(ds.Tables[0].Rows[7]["Scholarship"]));
                        //   txtTutionFee.Text = tution.ToString();

                        txtTutionFee.Text = ds.Tables[0].Rows[5]["Amount"].ToString();
                        txtCollegeFund.Text = ds.Tables[0].Rows[6]["Amount"].ToString();
                        txtCompFee.Text = ds.Tables[0].Rows[7]["Amount"].ToString();
                        txtScholarship.Text = ds.Tables[0].Rows[7]["Scholarship"].ToString();
                        txtPrevArrears.Text = ds.Tables[0].Rows[0]["Arrs"].ToString();
                        //  lblTution.Text = ds.Tables[0].Rows[5]["Amount"].ToString();

                        //lblScholarship.Text = ds.Tables[0].Rows[7]["Scholarship"].ToString();
                        lblAdmNo.Text = txtAdmNo.Text;
                        calfa();
                        calta();
                        calgt();
                    }
                    else
                    {
                        MessageBox.Show("Sorry Admission No. doest not exist");
                        txtAdmNo.Text = "";
                    }

                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        lblSName.Text = ds.Tables[0].Rows[0]["SName"].ToString();
                        lblClass.Text = ds.Tables[0].Rows[0]["CName"].ToString();
                        //txtRegFee.Text = ds.Tables[0].Rows[0]["RegFee"].ToString();
                        //txtRegFee.Text = ds.Tables[0].Rows[0]["RegFee"].ToString();
                        //txtAdmFee.Text = ds.Tables[0].Rows[0]["AdFee"].ToString();
                        //txtSecurity.Text = ds.Tables[0].Rows[0]["Security"].ToString();
                        //txtExamFee.Text = ds.Tables[0].Rows[0]["ExamsFee"].ToString();
                        //txtSportsFee.Text = ds.Tables[0].Rows[0]["SportsFee"].ToString();
                        txtRegFee.Text = "0";
                        txtRegFee.Text = "0";
                        txtAdmFee.Text = "0";
                        txtSecurity.Text = "0";
                        txtExamFee.Text = "0";
                        txtSportsFee.Text = "0";


                        //   int tution = (Convert.ToInt32(ds.Tables[0].Rows[5]["Amount"]) - Convert.ToInt32(ds.Tables[0].Rows[7]["Scholarship"]));
                        //  txtTutionFee.Text = tution.ToString();

                        txtTutionFee.Text = ds.Tables[0].Rows[0]["TutionFee"].ToString();
                        txtCollegeFund.Text = ds.Tables[0].Rows[0]["CollegeFund"].ToString();
                        txtCompFee.Text = ds.Tables[0].Rows[0]["ComputerFund"].ToString();
                        txtTransportFee.Text = ds.Tables[0].Rows[0]["TransportFee"].ToString();
                        txtScholarship.Text = ds.Tables[0].Rows[0]["Scholarship"].ToString();
                        txtPrevArrears.Text = ds.Tables[0].Rows[0]["Arrs"].ToString();

                        lblAdmNo.Text = txtAdmNo.Text;
                        calfa();
                        calta();
                        calgt();
                    }
                    else
                    {
                        MessageBox.Show("Sorry Admission No. doest not exist");
                        txtAdmNo.Text = "";
                    }

                }
                
                
            }
            
        }
        private void btnLoadFee_Click(object sender, EventArgs e)
        {
            if (txtAdmNo.Text == "")
            { MessageBox.Show("Please Enter Admission No.");
            }

            //else if (EStudent.AdmNoExists(Convert.ToInt32(txtAdmNo.Text)))
            //{
            //    LoadFeeAdmission();
            //}

            else
            {
               // MessageBox.Show("Invalid Admission Number", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFeeAdmission();
            }
        }

     void   calfa() // firsttime charges
    {
         
         int fatot=Convert.ToInt32(txtRegFee.Text) + Convert.ToInt32(txtAdmFee.Text) +  Convert.ToInt32(txtSecurity.Text) 
         +Convert.ToInt32(txtExamFee.Text) + Convert.ToInt32(txtSportsFee.Text);
         txtTA.Text = fatot.ToString() ;
        
    }

     void calta() //mothly charges
     {

         int fatot = Convert.ToInt32(txtTutionFee.Text) + Convert.ToInt32(txtCollegeFund.Text) + Convert.ToInt32(txtCompFee.Text) + Convert.ToInt32(txtTransportFee.Text)
         + Convert.ToInt32(txtFine.Text) + Convert.ToInt32(txtMisc.Text) ;
         txtTM.Text = fatot.ToString();

     }

     void calgt()
     {
         
         txtGT.Text =((Convert.ToInt32( txtTA.Text) +Convert.ToInt32(txtTM.Text)) - Convert.ToInt32(txtScholarship.Text)+ Convert.ToInt32(txtPrevArrears.Text)).ToString();
         txtPayed.Text = txtGT.Text;
         txtArrears.Text= (Convert.ToInt32(txtGT.Text) - Convert.ToInt32(txtPayed.Text) ).ToString();
   
     }

        private void btnCal_Click(object sender, EventArgs e)
        {
          //calfa();
          //calta();
          //calgt();  
        }

        private void txtTransportFee_Leave(object sender, EventArgs e)
        {
           calta(); // Calculate total Addmission Expenses
           calgt(); //Calculate Grand Total
        }

        private void txtTutionFee_Leave(object sender, EventArgs e)
        {
            calta();
            calgt();
        }

        private void txtCollegeFund_Leave(object sender, EventArgs e)
        {
            calta();
            calgt();
        }

        private void txtCompFee_Leave(object sender, EventArgs e)
        {
            calta();
            calgt();
        }

        private void txtFine_Leave(object sender, EventArgs e)
        {
            calta();
            calgt();
        }

        private void txtMisc_Leave(object sender, EventArgs e)
        {
            calta();
            calgt();
        }

        private void txtRegFee_Leave(object sender, EventArgs e)
        {
            calfa();
            calgt();
        }

        private void txtAdmFee_Leave(object sender, EventArgs e)
        {
            calfa();
            calgt();
        }

        private void txtSecurity_Leave(object sender, EventArgs e)
        {
            calfa();
            calgt();
        }

        private void txtExamFee_Leave(object sender, EventArgs e)
        {
            calfa();
            calgt();
        }

        private void txtSportsFee_Leave(object sender, EventArgs e)
        {
            calfa();
            calgt();
        }

        private void txtPayed_Leave(object sender, EventArgs e)
        {
            txtArrears.Text = (Convert.ToInt32(txtGT.Text) - Convert.ToInt32(txtPayed.Text)).ToString();
        }

        private void chkFeeType_CheckedChanged(object sender, EventArgs e)
        {
            checkchange();
        }

        private void checkchange()
        {
            if (chkFeeType.Checked == true)
            {
                LoadFeeAdmission();
                calfa();
                calta();
                calgt();
            }
            else if (chkFeeType.Checked == false)
            {
                txtRegFee.Text = "0";
                txtAdmFee.Text = "0";
                txtSecurity.Text = "0";
                txtExamFee.Text = "0";
                txtSportsFee.Text = "0";
                calfa();
                calta();
                calgt();
            }
            else
            {
            }
        }

        private void txtAdmNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                    LoadFeeAdmission();
            }

        }

        private void btnLoadFreshFee_Click(object sender, EventArgs e)
        {
           
        }

        private void lblLoadFreshFee_Click(object sender, EventArgs e)
        {
            Fee d = new Fee();
            DataSet ds;
            ds = d.LoadFreshFee(Convert.ToInt32(txtAdmNo.Text));
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblSName.Text = ds.Tables[0].Rows[0]["SName"].ToString();
                lblClass.Text = ds.Tables[0].Rows[0]["CName"].ToString();
                txtRegFee.Text = ds.Tables[0].Rows[0]["Amount"].ToString();
                txtAdmFee.Text = ds.Tables[0].Rows[1]["Amount"].ToString();
                txtSecurity.Text = ds.Tables[0].Rows[2]["Amount"].ToString();
                txtExamFee.Text = ds.Tables[0].Rows[3]["Amount"].ToString();
                txtSportsFee.Text = ds.Tables[0].Rows[4]["Amount"].ToString();
                txtTutionFee.Text = ds.Tables[0].Rows[5]["Amount"].ToString();
                txtCollegeFund.Text = ds.Tables[0].Rows[6]["Amount"].ToString();
                txtCompFee.Text = ds.Tables[0].Rows[7]["Amount"].ToString();
                txtScholarship.Text = ds.Tables[0].Rows[7]["Scholarship"].ToString();
                txtPrevArrears.Text = ds.Tables[0].Rows[0]["Arrs"].ToString();

                lblAdmNo.Text = txtAdmNo.Text;
                calfa();
                calta();
                calgt();
            }
            else
            {
                MessageBox.Show("Sorry Admission No. doest not exist");
                txtAdmNo.Text = "";
            }
        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }
            if (save())
            {
                MessageBox.Show("Transaction Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmReportViewer frm = new frmReportViewer();
                frm.receiptno = rforprint;
                //this.Close();
                frm.Location = new Point(this.Location.X - 110, this.Location.Y - 70);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Problems in Saving Transaction", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lblClass_Click(object sender, EventArgs e)
        {

        }
    }
}
