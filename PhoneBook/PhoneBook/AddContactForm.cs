using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class AddContactForm : Form
    {
        ContactBookForm cbf;
        ContactList list;

        public AddContactForm(ContactBookForm form)
        {
            InitializeComponent();
            GBoxSocial.Visible = false;
            GboxBusiness.Visible = false;
            RBtnBusiness.Checked = true;

            cbf = form;

            list = ContactList.GetInstance();
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {

        }
        private void UpdatePhotoBox(String file_path)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(file_path);
            }
            catch
            {
                MessageBox.Show("Wrong file selected.", "Error", MessageBoxButtons.OK);
            }
        }


        private void RBtnSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnSocial.Checked == true)
            {
                GboxBusiness.Visible = false;
                RBtnBusiness.Checked = false;
                GBoxSocial.Visible = true;
            }
        }

        private void RBtnBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnBusiness.Checked == true)
            {
                GBoxSocial.Visible = false;
                RBtnSocial.Checked = false;
                GboxBusiness.Visible = true;
            }
        }


       


        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (RBtnSocial.Checked)
            {
                Social_Contact p;
                p = new Social_Contact(TxtFirstName.Text, TxtLastName.Text, TxtEmail.Text, TxtPhoneNumber.Text, "Social", txtAdditionalNotes.Text);
                p .Photo_path = txtPath.Text;
                p.FaceBook = TxtFaceBook.Text;
                p.Birth_Date = Convert.ToString(BirthdayPicker.Text);

                list.Add_(p);
                //cbf.listBox.Items.Add(p.First_Name + " " + p.Last_Name);
                cbf.X.Sort_(list);
                if (p is Social_Contact)
                    cbf.tbl.Rows.Add((p.First_Name + " " + p.Last_Name));

            }

            else if (RBtnBusiness.Checked)
            {
                Business_Contact p;
                p = new Business_Contact(TxtFirstName.Text, TxtLastName.Text, TxtEmail.Text, TxtPhoneNumber.Text, "Business", txtAdditionalNotes.Text);
                p.Photo_path = txtPath.Text;
                p.CompanyName = TxtCompany.Text;
                p.BusinessPhone = TxtBPhone.Text;
                p.Fax = TxtFax.Text;

                list.Add_(p);
                //cbf.listBox.Items.Add(p.First_Name + " " + p.Last_Name);
                cbf.X.Sort_(list);
                if (p is Business_Contact)
                    cbf.tbl.Rows.Add((p.First_Name + " " + p.Last_Name));




            }


            this.Hide();
           
            cbf.Show();

        }

        private void GboxAdditionalInfo_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
                UpdatePhotoBox(ofd.FileName);
            }
        }


    }

 }

