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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
            Utility.ApplyNumericOnlyFormat(txtAdmNo);
        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAEStudent frm = new frmAEStudent();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadList();
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

            EStudent d = new EStudent();
            DataSet ds = d.GetList();

            if (ds.Tables[0].Rows.Count > 0)
            {
                grdList.AutoGenerateColumns = false;
                grdList.DataSource = ds.Tables[0];
                btnEdit.Enabled = true;
                pnlSearch.Visible = false;
            }
        }
        private void LoadListbyAdmNo(int admno)
        {
          
            EStudent d = new EStudent();
            DataSet ds = d.GetListAdmNo(admno);

            if (ds.Tables[0].Rows.Count > 0)
            {
                grdList.AutoGenerateColumns = false;
                grdList.DataSource = ds.Tables[0];
                btnEdit.Enabled = true;
                pnlSearch.Visible = false;
            }
            else
            {
                MessageBox.Show("Sorry No Record Found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEdit.Enabled = false;
                grdList.DataSource = null;
            }
        }
        private void LoadListbyClass(int clsid)
        {
      
            EStudent d = new EStudent();
            DataSet ds = d.LoadListClass(clsid);
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdList.AutoGenerateColumns = false;
                grdList.DataSource = ds.Tables[0];
                btnEdit.Enabled = true;
                pnlSearch.Visible = false;
            }
            else
            {
                MessageBox.Show("Sorry No Record Found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEdit.Enabled = false;
                grdList.DataSource = null;
            }
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
                frmAEStudent frm = new frmAEStudent((DataRowView)grdList.Rows[e.RowIndex].DataBoundItem);
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPanelExit_Click(object sender, EventArgs e)
        {
            pnlSearch.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillClassCombo();
            pnlSearch.Show();
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
                frmAEStudent frm = new frmAEStudent((DataRowView)grdList.Rows[rowindex].DataBoundItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                   
                    LoadList();
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
          //  IsClassesLoaded = true;

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
