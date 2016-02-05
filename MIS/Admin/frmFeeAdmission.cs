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
    public partial class frmFeeAdmission : Form
       
    {
        private bool byclass = false;
        private bool byadmno = false;
        public frmFeeAdmission()
        {
            
            InitializeComponent();
            Utility.ApplyNumericOnlyFormat(txtAdmNo);
        }

         private void btnAdd_Click(object sender, EventArgs e)
        {

            string admno = txtAdmNo.Text;
            Fee f = new Fee();
            if (txtAdmNo.Text == "")
            {
                MessageBox.Show("Enter Admission Number", "Admission No.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                DataTable dt = f.TransactionStatus(Convert.ToInt16(txtAdmNo.Text));
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Status"].ToString() == "Fee Slip Issued")
                    {
                        MessageBox.Show("Sorry You Can't Make New Transaction, first Cancel or Pay last transaction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        frmAEFeeAdmission frm = new frmAEFeeAdmission(admno);

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            LoadList();
                        }
                    }
                }

                else
                {

                    frmAEFeeAdmission frm = new frmAEFeeAdmission(admno);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadList();
                    }
                }
            }

        }
        private void LoadList()
        {
            //if (this.btnSelForMrk.Enabled == true)
            //{
            //    btnAdd.Enabled = false;
            //    btnDelete.Enabled = false;
            //    btnEdit.Enabled = false;
            //    btnPrint.Enabled = false;
            //}
            if (txtAdmNo.Text == "")
            {
               // MessageBox.Show("Please Enter Admission No.");
            }
            else
            {

                Fee d = new Fee();
                DataSet ds = d.LoadStudentFee(Convert.ToInt32(txtAdmNo.Text));
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    grdList.AutoGenerateColumns = false;
                    grdList.DataSource = ds.Tables[0];
                 
                    btnPayed.Enabled = true;
                    btnNotPayed.Enabled = true;
                    btnCancelSlp.Enabled = true;
                    btnEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Fee Not Payed for this Student.","Fee Status",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    grdList.DataSource = null;

                    btnPayed.Enabled = false;
                    btnNotPayed.Enabled = false;
                    btnCancelSlp.Enabled = false;
                    btnEdit.Enabled = false;

                }
            }
        }

        private void FillClassCombo()
        {

            EClass c = new EClass();
            DataTable dt = c.GetClasses();
            cbxClass.DataSource = dt;
            cbxClass.DisplayMember = "CName";
            cbxClass.ValueMember = "ClassID";
           // IsClassesLoaded = true;

        }
       

        private void grdList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (null != grdList)
            {
                foreach (DataGridViewRow r in grdList.Rows)
                {
                    grdList.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
                }
            }
        }

        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int curSfid = Convert.ToInt32(grdList.SelectedRows[0].Cells["SFID"].Value);
            int curadmno = Convert.ToInt32(grdList.SelectedRows[0].Cells["AdmNo"].Value);

            Fee d = new Fee();
            DataTable dt = d.GetMaxSFID(curadmno);
            int maxsfid = Convert.ToInt32(dt.Rows[0]["maxsfid"]);


            if (curSfid == maxsfid && grdList.SelectedRows[0].Cells["Status"].Value.ToString() == "Fee Slip Issued")
           {

               if (e.RowIndex >= 0)
               {

                   frmAEFeeAdmission frm = new frmAEFeeAdmission((DataRowView)grdList.Rows[e.RowIndex].DataBoundItem);

                   if (frm.ShowDialog() == DialogResult.OK)
                   {
                       LoadList();
                   }
               }
           }
           else
           {
               MessageBox.Show("You cant not Edit old or payed or canceled Fee Records");
           }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelForMrk_Click(object sender, EventArgs e)
        {
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPanelExit_Click(object sender, EventArgs e)
        {
           // pnlSearch.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        //    pnlSearch.Show();
        //    txtSearch.Text = "";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtAdmNo.Text == "")
            {
                MessageBox.Show("Please enter admission number", "Admission number?", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int w = EStudent.AdmNoExists2(Convert.ToInt32(txtAdmNo.Text));
                if (txtAdmNo.Text == "")
                {
                    MessageBox.Show("Please enter admission number", "Admission number?", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (w == 0)
                {
                    MessageBox.Show("Invalid Admission Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    LoadList();
                    byadmno = true;
                    byclass = false;

                }
            }
            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

       

        private void btnNewStdFee_Click(object sender, EventArgs e)
        {
        }

        private void btnTFee_Click(object sender, EventArgs e)
        {
            

        }

        private void btnLoadByClass_Click(object sender, EventArgs e)
        {
           
            LoadListByClass();
            byclass = true;
            byadmno = false;
        }
        private void LoadListByClass()
        {
            Fee d = new Fee();

            int cid = Convert.ToInt32(cbxClass.SelectedValue);
            DataSet ds = d.LoadStudentFeeByClass(cid);
            if (ds.Tables[0].Rows.Count >= 1)
            {
                grdList.AutoGenerateColumns = false;
                grdList.DataSource = ds.Tables[0];


                btnPayed.Enabled = true;
                btnNotPayed.Enabled = true;
                btnCancelSlp.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                MessageBox.Show("No Fee Entry For Selected Class.", "Fee Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdList.DataSource = null;

                btnPayed.Enabled = false;
                btnNotPayed.Enabled = false;
                btnCancelSlp.Enabled = false;
                btnEdit.Enabled = false;

            }
        }

        private void txtAdmNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
         if (e.KeyChar == 13)
            {
                if (txtAdmNo.Text == "")
                {
                   
                    MessageBox.Show("Please Enter Admission Number", "Admission Number?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int w = EStudent.AdmNoExists2(Convert.ToInt32(txtAdmNo.Text));

                    if (w == 0)
                    {
                        MessageBox.Show("Invalid Admission Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        LoadList();
                        byadmno = true;
                        byclass = false;

                    }
                }
            
            }
            
        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPayed_Click(object sender, EventArgs e)
        {
          
        }
        
        private void cbxClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
            LoadListByClass();
            byclass = true;
            byadmno = false;
            }
        }

        private void frmFeeAdmission_Load(object sender, EventArgs e)
        {
            FillClassCombo();
           
            
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            int curSfid = Convert.ToInt32(grdList.SelectedRows[0].Cells["SFID"].Value);
            int curadmno = Convert.ToInt32(grdList.SelectedRows[0].Cells["AdmNo"].Value);

            Fee d = new Fee();
            DataTable dt = d.GetMaxSFID(curadmno);
            int maxsfid = Convert.ToInt32(dt.Rows[0]["maxsfid"]);



            if (grdList.SelectedRows[0].Cells["Status"].Value.ToString() == "Canceled")
            {
                MessageBox.Show("You Can not UNPAY Canceled Slips", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (grdList.SelectedRows[0].Cells["Status"].Value.ToString() == "Not Payed")
            {
                MessageBox.Show("Selected Transaction is Already NOT PAYED", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (grdList.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Record is Selected", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            else if (curSfid == maxsfid)
            {

                string di = MessageBox.Show(" Cancel Selected Transaction ?", "Cancel ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

                if (di == "Yes")
                {

                    Fee f = new Fee();

                    if (f.SetNotPayed(Convert.ToInt32(grdList.SelectedRows[0].Cells["SFID"].Value), Convert.ToInt32(grdList.SelectedRows[0].Cells["AdmNo"].Value), Convert.ToInt32(grdList.SelectedRows[0].Cells["Payed"].Value), Convert.ToInt32(grdList.SelectedRows[0].Cells["Total"].Value), grdList.SelectedRows[0].Cells["Status"].Value.ToString()) == true)
                    {
                        MessageBox.Show("Transaction Canceled Successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (byadmno == true && byclass == false)
                        {
                            LoadList();
                        }
                        else
                            LoadListByClass();


                    }
                    else
                    {
                        MessageBox.Show("Problem in Updating the transaction", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (byadmno == true && byclass == false)
                        {
                            LoadList();
                        }
                        else if (byadmno == false && byclass == true)
                            LoadListByClass();
                    }
                }

            }
            else
            {
                MessageBox.Show("You cant not Edit old Fee Records", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSetPayed_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            int curSfid = Convert.ToInt32(grdList.SelectedRows[0].Cells["SFID"].Value);
            int curadmno = Convert.ToInt32(grdList.SelectedRows[0].Cells["AdmNo"].Value);

            Fee d = new Fee();
            DataTable dt = d.GetMaxSFID(curadmno);
            int maxsfid = Convert.ToInt32(dt.Rows[0]["maxsfid"]);



            if (grdList.SelectedRows[0].Cells["Status"].Value.ToString() == "Canceled")
            {
                MessageBox.Show("Selected Transaction is Already Canceled", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (grdList.SelectedRows[0].Cells["Status"].Value.ToString() == "Payed" || grdList.SelectedRows[0].Cells["Status"].Value.ToString() == "Not Payed")
            {
                MessageBox.Show("You Can Not Cancel Payed or UnPayed Slips", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (grdList.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Record is Selected", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            else if (curSfid == maxsfid)
            {

                string di = MessageBox.Show(" Cancel Selected Transaction ?", "Cancel ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

                if (di == "Yes")
                {

                    Fee f = new Fee();

                    if (f.SetCanceled(Convert.ToInt32(grdList.SelectedRows[0].Cells["SFID"].Value), Convert.ToInt32(grdList.SelectedRows[0].Cells["AdmNo"].Value), Convert.ToInt32(grdList.SelectedRows[0].Cells["Payed"].Value), Convert.ToInt32(grdList.SelectedRows[0].Cells["Total"].Value), grdList.SelectedRows[0].Cells["Status"].Value.ToString(), Convert.ToInt32(grdList.SelectedRows[0].Cells["PrevArrears"].Value)) == true)
                    {
                        MessageBox.Show("Transaction Canceled Successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (byadmno == true && byclass == false)
                        {
                            LoadList();
                        }
                        else
                            LoadListByClass();


                    }
                    else
                    {
                        MessageBox.Show("Problem in Updating the transaction", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (byadmno == true && byclass == false)
                        {
                            LoadList();
                        }
                        else if (byadmno == false && byclass == true)
                            LoadListByClass();
                    }
                }

            }
            else
            {
                MessageBox.Show("You cant not Edit old Fee Records", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayed_Click_1(object sender, EventArgs e)
        {
            int curSfid = Convert.ToInt32(grdList.SelectedRows[0].Cells["SFID"].Value);
            int curadmno = Convert.ToInt32(grdList.SelectedRows[0].Cells["AdmNo"].Value);

            Fee d = new Fee();
            DataTable dt = d.GetMaxSFID(curadmno);
            int maxsfid = Convert.ToInt32(dt.Rows[0]["maxsfid"]);



            if (grdList.SelectedRows[0].Cells["Status"].Value.ToString() == "Payed")
            {
                MessageBox.Show("Selected Transaction is Already Payed", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (grdList.SelectedRows[0].Cells["Status"].Value.ToString() == "Canceled")
            {
                MessageBox.Show("You Can Not Pay Canceled Slips", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (grdList.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Record is Selected", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            else if (curSfid == maxsfid)
            {

                string di = MessageBox.Show(" Pay Selected Transaction ?", "Pay ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

                if (di == "Yes")
                {

                    Fee f = new Fee();

                    if (f.SetPayed(Convert.ToInt32(grdList.SelectedRows[0].Cells["SFID"].Value), Convert.ToInt32(grdList.SelectedRows[0].Cells["AdmNo"].Value), Convert.ToInt32(grdList.SelectedRows[0].Cells["Total"].Value), Convert.ToInt32(grdList.SelectedRows[0].Cells["Payed"].Value), grdList.SelectedRows[0].Cells["Status"].Value.ToString()) == true)
                    {
                        MessageBox.Show("Status Updated to PAYED", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (byadmno == true && byclass == false)
                        {
                            LoadList();
                        }
                        else
                            LoadListByClass();


                    }
                    else
                    {
                        MessageBox.Show("Problem in Updating the transaction", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (byadmno == true && byclass == false)
                        {
                            LoadList();
                        }
                        else if (byadmno == false && byclass == true)
                            LoadListByClass();
                    }
                }

            }
            else
            {
                MessageBox.Show("You cant not Edit old Fee Records", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

       
       
    }
}
