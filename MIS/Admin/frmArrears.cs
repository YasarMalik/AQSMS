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
    public partial class frmArrears : Form
    {
        DataRowView dataBoundItem;
        //bool edit = false;
        public frmArrears()
        {
            InitializeComponent();
        }

        public frmArrears(DataRowView dt)
        {
            InitializeComponent();
            dataBoundItem = dt;
        }
        
        
        private void frmAEUser_Load(object sender, EventArgs e)
        {
           
        }

       private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
