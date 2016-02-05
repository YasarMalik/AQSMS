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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //frmAEStudent frm = new frmAEStudent();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadList();
            //}
        }
        private void LoadList()
        {

            EClass d = new EClass();
            DataTable dt = d.GetClasses();

            grdList.AutoGenerateColumns = false;
            grdList.DataSource = dt;
        }
        private void frmExaminers_Load(object sender, EventArgs e)
        {
            LoadList();
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
            if (e.RowIndex >= 0)
            {
                frmAEClass frm = new frmAEClass((DataRowView)grdList.Rows[e.RowIndex].DataBoundItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadList();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //EExaminer d = new EExaminer();
            //DataSet ds = d.GetList();
            //rptExaminers rpt = new rptExaminers();
            ////ds.Tables[0].TableName = "Sale_Reprot";
            //rpt.SetDataSource(ds.Tables[0]);
            //frmReportViewer frm = new frmReportViewer(rpt);
            //frm.Location = new Point(this.Location.X + 103, this.Location.Y + 65);
            //frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (grdList.SelectedRows.Count > 0)
            //{
            //    //string desName = dataGridView1.SelectedRows[0].Cells["Title"].Value.ToString();
            //    int id = Convert.ToInt32(grdList.SelectedRows[0].Cells["EID"].Value);
            //    if (MessageBox.Show("Delete Selected Record Permanently?", "Delete???", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        //EExaminer d = new EExaminer();
            //        //d.Delete(id);
            //        //LoadList();
            //    }
            //}
        }

        //private void FillClassCombo()
        //{

        //    EClass c = new EClass();
        //    DataTable dt = c.GetClasses();
        //    cbxClass.DataSource = dt;
        //    cbxClass.DisplayMember = "CName";
        //    cbxClass.ValueMember = "ClassID";
        //    //  IsClassesLoaded = true;

        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
          //  FillClassCombo(); 
           // pnlSearch.Show();
            //txtSearch.Text = "";
        }

        private void navigationBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowindex = grdList.SelectedRows[0].Index;
            if (rowindex < 0)
            {
                MessageBox.Show("Please Select a Record", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmAEClass frm = new frmAEClass((DataRowView)grdList.Rows[rowindex].DataBoundItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    LoadList();
                }
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (rbAdmNo.Checked == true)
            {
                if (txtAdmNo.Text == "")
                {
                    MessageBox.Show("Please Enter Admission Number", "Admission Number?", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    LoadListbyAdmNo(Convert.ToInt16(txtAdmNo.Text));
                    pnlSearch.Visible = false;
                }
            }
            else if (rbClass.Checked == true)
            {
                LoadListbyClass(Convert.ToInt32(cbxClass.SelectedValue));
               pnlSearch.Visible = false;
            }
            else
                MessageBox.Show("Please select criteria", "No Criteria", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void LoadListbyAdmNo(int admno)
        {

            EStudent d = new EStudent();
            DataSet ds = d.GetArrearsAdmNo(admno);

            if (ds.Tables[0].Rows.Count > 0)
            {
                grdList.AutoGenerateColumns = false;
                grdList.DataSource = ds.Tables[0];
            }
            else
            { MessageBox.Show("Sorry No Record Found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grdList.DataSource = null;
            }

        }
        private void LoadListbyClass(int clsid)
        {

            EStudent d = new EStudent();
            DataSet ds = d.LoadArrearsClass(clsid);
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdList.AutoGenerateColumns = false;
                grdList.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Sorry No Record Found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdList.DataSource = null;
            }
        }

        private void btnPanelExit_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
