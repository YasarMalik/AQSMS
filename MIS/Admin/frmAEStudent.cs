using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BL;

namespace MIS
{
    public partial class frmAEStudent : Form
    {
        DataRowView dataBoundItem;
        bool edit = false;
        bool newimage = false;
        bool IsClassesLoaded = false;

        public frmAEStudent()
        {
            InitializeComponent();
            Utility.ApplyNumericOnlyFormat(txtAdmNo);
            Utility.ApplyNumericOnlyFormat(txtScholarship);
         
        }
        public frmAEStudent(DataRowView dt)
        {
            InitializeComponent();
            dataBoundItem = dt;
        }

        private void FillClassCombo()
        {

            EClass c = new EClass();
            DataTable dt = c.GetClasses();
            cbxClass.DataSource = dt;
            cbxClass.DisplayMember = "CName";
            cbxClass.ValueMember = "ClassID";
            IsClassesLoaded = true;

        }
       


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pbStudent.ImageLocation = opf.FileName;
                newimage = true;
                if (pbStudent.Image != MIS.Properties.Resources.NoImage)
                {
                    btnRemovePic.Enabled = true;
                }
                
            }
        }

        public byte[] ImageToByteArray(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            EStudent d = new EStudent();
            if (!IsValid())
            {
                return;
            }
            try
            {

      
                d.AdmNo = Convert.ToInt32(txtAdmNo.Text);
                d.AdmDate = dtAdmDate.Value;
                d.SName = txtSName.Text;
                d.DOB = dtDOB.Value;
                d.Nationality = txtNationality.Text;
                d.ClassID = Convert.ToInt32(cbxClass.SelectedValue);
                d.Section = cbxSection.Text;
                d.PrevSchool = txtPrevSchool.Text;
                d.Address = txtAddress.Text;
                d.Phone = txtPhoneNo.Text;
                d.Scholarship =Convert.ToInt32( txtScholarship.Text);
                d.FName = txtFName.Text;
                d.FMobile = txtFMobile.Text;
                d.MName = txtMName.Text;
                d.MMobile = txtMMobile.Text;
                d.Guardian = txtGuardian.Text;
                d.FGAddress = txtFGWAddress.Text;
                d.WPhone = txtWPhone.Text;
                d.Email = txtEmail.Text;
                d.AdmStatus = txtAdmStatus.Text;
                d.Remarks = txtRemarks.Text;
                

                if (newimage == true)
                {
                    FileStream FS = new FileStream(@opf.FileName, FileMode.Open, FileAccess.ReadWrite); //create a file stream object associate to user selected file 
                    byte[] img = new byte[FS.Length]; //create a byte array with size of user select file stream length
                    FS.Read(img, 0, Convert.ToInt32(FS.Length));
                    d.PIC = img;
                }
               
                else
                {
                    byte[] byteImg = ImageToByteArray(pbStudent.Image);
                    d.PIC = byteImg;

                }
                                                    
                
                if (dataBoundItem != null)
                {

                    d.SID = Convert.ToInt32(dataBoundItem["SID"]);
                   d.Update();
                }
                else
                {
                    d.Insert();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Utility.WriteToLog(ex, this);
            }
        }
        private bool IsValid()
        {
            if (txtAdmNo.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Admission Number", txtAdmNo, 2000);
                return false;
            }
            if (EStudent.AdmNoExists(Convert.ToInt32(txtAdmNo.Text)) && edit == false) //for duplicates
            {
                ttp.Show("Admission Number already allocted to another student", txtAdmNo, 2000);
                return false;
            }
            if (txtSName.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Name", txtSName, 2000);
                return false;
            }

            
            if (cbxClass.Text.Trim().Length == 0)
            {
                ttp.Show("Please Select Class", cbxClass, 2000);
                return false;
            }
            if (dtAdmDate.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Admission Date", dtAdmDate, 2000);
                return false;
            }
            if (dtDOB.Text.Trim().Length == 0)
            {
                ttp.Show("Please enter Date of Birth", dtDOB, 2000);
                return false;
            }
            //if (txtPhoneNo.Text.Trim().Length == 0)
            //{
            //    ttp.Show("Please enter Mobile", txtPhoneNo, 2000);
            //    return false;
            //}

           

            return true;
        }
        private void frmAEExaminer_Load(object sender, EventArgs e)

        {
            FillClassCombo();

            if(pbStudent.Image==MIS.Properties.Resources.NoImage)
            {
                btnRemovePic.Enabled = false;
            }
            if (dataBoundItem != null)
            {
                txtAdmNo.Text = dataBoundItem["AdmNo"].ToString();
                dtAdmDate.Value =Convert.ToDateTime(dataBoundItem["AdmDate"]);
                txtSName.Text = dataBoundItem["SName"].ToString();
                dtDOB.Value = Convert.ToDateTime(dataBoundItem["DOB"]);
                txtNationality.Text = dataBoundItem["Nationality"].ToString();
                cbxClass.Text = dataBoundItem["CName"].ToString();
                cbxSection.Text = dataBoundItem["Section"].ToString();
                txtPrevSchool.Text = dataBoundItem["PreviousSchool"].ToString();
                txtAddress.Text = dataBoundItem["Address"].ToString();
                txtPhoneNo.Text = dataBoundItem["Phone"].ToString();
                txtFName.Text = dataBoundItem["FName"].ToString();
                txtFMobile.Text = dataBoundItem["FMobile"].ToString();
                txtMName.Text = dataBoundItem["MName"].ToString();
                txtMMobile.Text = dataBoundItem["MMobile"].ToString();
                txtGuardian.Text = dataBoundItem["Guardian"].ToString();
                txtFGWAddress.Text = dataBoundItem["FGAdress"].ToString();
                txtWPhone.Text = dataBoundItem["WPhone"].ToString();
                txtEmail.Text = dataBoundItem["Email"].ToString();
                txtScholarship.Text = dataBoundItem["Scholarship"].ToString();
                txtAdmStatus.Text = dataBoundItem["AdmStatus"].ToString();
                txtRemarks.Text = dataBoundItem["Remarks"].ToString();

               MemoryStream ms = new MemoryStream((byte[])dataBoundItem["Pic"]);//create memory stream by passing byte array of the image
               Image returnImage = Image.FromStream(ms);
               
              pbStudent.Image = returnImage;

             edit = true;
            }
        }

        private void btnRemovePic_Click(object sender, EventArgs e)
        {
            pbStudent.Image = MIS.Properties.Resources.NoImage;
            btnRemovePic.Enabled = false;
        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
