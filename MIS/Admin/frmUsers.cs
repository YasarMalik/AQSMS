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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
            //this.Location = Utility.FormsLocation;
        }
        private void LoadList()
        {
            EUser d = new EUser();
            DataSet ds = d.GetList();
            //DataView dv = ds.Tables[0].DefaultView;
            //dv.Sort = "Cour";
            grdList.AutoGenerateColumns = false;
            grdList.DataSource = ds.Tables[0];
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void buttonItem5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAEUser frm = new frmAEUser();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grdList.SelectedRows.Count > 0)
            {
                int ind = grdList.SelectedRows[0].Index;
                if (ind >= 0)
                {
                    frmAEUser frm = new frmAEUser((DataRowView)grdList.Rows[ind].DataBoundItem);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Edit", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void navigationBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
