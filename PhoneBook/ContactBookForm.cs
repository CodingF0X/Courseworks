using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;


namespace PhoneBook
{
    public partial class ContactBookForm : Form
    {

        public int index;

        ContactList list;// all the contact here?
        ContactList_Itrerator iterator_ = new ContactList_Itrerator();
       public XmlHandler X;

        //where is the addin process yh


        public DataTable tbl;


        public ContactBookForm()
        {
            InitializeComponent();
            list = ContactList.GetInstance();
            X = new XmlHandler();
            GboxContactDetails.Enabled = false;
            GboxBasic.Visible = false;
            GboxBusiness.Visible = false;
            GboxSocial.Visible = false;
            BtnApply.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnExit.Enabled = true;
            BtnAddContact.Enabled = true;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void GboxSocial_Enter(object sender, EventArgs e)
        {

        }

        private void ContactBookForm_Load(object sender, EventArgs e)
        {

            if (!File.Exists("Contacts.xml"))
            {
                XmlTextWriter xw = new XmlTextWriter("Contacts.xml", Encoding.UTF8);
                xw.WriteStartElement("Contacts");
                xw.WriteEndElement();
                xw.Close();

            }
            Load_Data();


        }


      

        private void Load_Data()
        {
            var getRow = iterator_.Get_Current_Contact();
            tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            //tbl.Rows.Add(listBox.SelectedIndex);


            XmlDocument doc = new XmlDocument();
            doc.Load("Contacts.xml");

            string contact_Type;
            foreach (XmlNode xNode in doc.SelectNodes("Contacts/Contact"))
            {
                contact_Type = xNode.SelectSingleNode("Type").InnerText;

                if (contact_Type == "Social")
                {
                    Contact p = new Social_Contact();
                    p.First_Name = xNode.SelectSingleNode("FirstName").InnerText;
                    p.Last_Name = xNode.SelectSingleNode("LastName").InnerText;
                    p.Email = xNode.SelectSingleNode("Email").InnerText;
                    p.PhoneNumber = xNode.SelectSingleNode("PhoneNumber").InnerText;
                    p.AdditionalNotes = xNode.SelectSingleNode("AdditionalNotes").InnerText;
                    p.Photo_path = xNode.SelectSingleNode("Photo_path").InnerText;

                    (p as Social_Contact).FaceBook = xNode.SelectSingleNode("FaceBook").InnerText;
                    (p as Social_Contact).Birth_Date = xNode.SelectSingleNode("Birthday_date").InnerText;

                    list.Add_(p);
                    //listBox.Items.Add(p.First_Name + " " + p.Last_Name);

                    tbl.Rows.Add((p as Social_Contact).First_Name + " " + (p as Social_Contact).Last_Name);


                }

                if (contact_Type == "Business")
                {
                    Contact p = new Business_Contact();
                    p.First_Name = xNode.SelectSingleNode("FirstName").InnerText;
                    p.Last_Name = xNode.SelectSingleNode("LastName").InnerText;
                    p.Email = xNode.SelectSingleNode("Email").InnerText;
                    p.PhoneNumber = xNode.SelectSingleNode("PhoneNumber").InnerText;
                    p.AdditionalNotes = xNode.SelectSingleNode("AdditionalNotes").InnerText;
                    p.Photo_path = xNode.SelectSingleNode("Photo_path").InnerText;
                    (p as Business_Contact).CompanyName = xNode.SelectSingleNode("Company").InnerText;
                    (p as Business_Contact).BusinessPhone = xNode.SelectSingleNode("BusinessNo").InnerText;
                    (p as Business_Contact).Fax = xNode.SelectSingleNode("Fax").InnerText;

                    list.Add_(p);
                    tbl.Rows.Add((p as Business_Contact).First_Name + " " + (p as Business_Contact).Last_Name);

                }
            }
           X.Sort_(list);
            listBox.DataSource = tbl;
            listBox.DisplayMember = "Name";

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            X.Save_XML();
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm ac = new AddContactForm(this);
            ac.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count == 0)
                return;

            GboxBasic.Visible = true;
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;


            int selectedContact = listBox.SelectedIndex;


            while (selectedContact != iterator_.Get_Index())
            {
                iterator_.next();
                if (iterator_.Check_())
                    iterator_.First();

            }



            UpdatePhotoBox(iterator_.Get_Current_Contact().Photo_path);
            if (iterator_.Get_Current_Contact().Type == "Social")
            {
                GboxSocial.Visible = true;
                GboxBusiness.Visible = false;
                Social_Contact sc = (Social_Contact)list.Get_Person(iterator_.Get_Index());
                TxtFirstName.Text = iterator_.Get_Current_Contact().First_Name;
                TxtLastName.Text = iterator_.Get_Current_Contact().Last_Name;
                TxtEmail.Text = iterator_.Get_Current_Contact().Email;
                TxtPhone.Text = iterator_.Get_Current_Contact().PhoneNumber;
                TxtNotes.Text = iterator_.Get_Current_Contact().AdditionalNotes;
                TxtFb.Text = sc.FaceBook;
                TxtBirthdate.Text = sc.Birth_Date;
                TxtPhotopath.Text = sc.Photo_path;


            }

            else
            {
                
                GboxBusiness.Visible = true;
                GboxSocial.Visible = false;
                Business_Contact bc = (Business_Contact)list.Get_Person(iterator_.Get_Index());
                TxtFirstName.Text = iterator_.Get_Current_Contact().First_Name;
                TxtLastName.Text = iterator_.Get_Current_Contact().Last_Name;
                TxtEmail.Text = iterator_.Get_Current_Contact().Email;
                TxtPhone.Text = iterator_.Get_Current_Contact().PhoneNumber;
                TxtNotes.Text = iterator_.Get_Current_Contact().AdditionalNotes;
                TxtCompany.Text = bc.CompanyName;
                TxtFax.Text = bc.Fax;
                TxtBPhone.Text = bc.BusinessPhone;
                TxtPhotopath.Text = bc.Photo_path;

            }


        }

        private void Tbl_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateListViewItems()
        {
            tbl.Rows.Clear();

            Contact contact;
            for (iterator_.First(); !iterator_.Check_(); iterator_.next()) // !iteratot.IsDone() ... saying that the current item isnt bigger than the size of the list.
            {
                contact = iterator_.Get_Current_Contact();
                //listBox.Items.Add(contact.First_Name + " " + contact.Last_Name);
                tbl.Rows.Add(contact.First_Name + " " + contact.Last_Name);

            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            GboxContactDetails.Enabled = true;
            GboxBasic.Enabled = true;
            BtnApply.Enabled = true;
            if (iterator_.Get_Current_Contact().Type == "Business")
                GboxBusiness.Enabled = true;

            else
                GboxBusiness.Enabled = false;




        }

        private void BtnApply_Click(object sender, EventArgs e)
        {

            try
            {
                if (iterator_.Get_Current_Contact().Type == "Social")
                {
                    Contact sc = (Social_Contact)list.Get_Person(iterator_.Get_Index());
                    sc.First_Name = TxtFirstName.Text;
                    sc.Last_Name = TxtLastName.Text;
                    sc.Email = TxtEmail.Text;
                    sc.PhoneNumber = TxtPhone.Text;
                    sc.AdditionalNotes = TxtNotes.Text;
                    sc.Photo_path = TxtPhotopath.Text;
                    (sc as Social_Contact).FaceBook = TxtFb.Text;
                    (sc as Social_Contact).Birth_Date = TxtBirthdate.Text;
                    list.editContact(sc, iterator_.Get_Current_Contact());


                }

                if (iterator_.Get_Current_Contact().Type == "Business")
                {
                    Contact bc = (Business_Contact)list.Get_Person(iterator_.Get_Index());
                    bc.First_Name = TxtFirstName.Text;
                    bc.Last_Name = TxtLastName.Text;
                    bc.Email = TxtEmail.Text;
                    bc.PhoneNumber = TxtPhone.Text;
                    bc.AdditionalNotes = TxtNotes.Text;
                    bc.Photo_path = TxtPhotopath.Text;
                    (bc as Business_Contact).CompanyName = TxtCompany.Text;
                    (bc as Business_Contact).Fax = TxtFax.Text;
                    (bc as Business_Contact).BusinessPhone = TxtBPhone.Text;

                    list.editContact(bc, iterator_.Get_Current_Contact());
                }
            }
            catch
            {

            }
            UpdateListViewItems();

            GboxBasic.Enabled = false;
            GboxContactDetails.Enabled = false;
            GboxBusiness.Enabled = false;
            BtnApply.Enabled = false;
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = false;
            BtnExit.Enabled = true;
            BtnAddContact.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count == 0)
                return;

            _Remove_C();

        }

        public void _Remove_C()
        {
            try
            {
                list.Remove_(listBox.SelectedIndex);
                //listBox.Items.Remove(listBox.SelectedItem);
                tbl.Rows.RemoveAt(listBox.SelectedIndex);
            }

            catch { }
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {


            DataView dv = tbl.DefaultView;
            dv.RowFilter = "Name LIKE'%" + TxtSearch.Text + "%'";


            bool check = false;
            foreach (var item in list.list)
            {
                if (item.First_Name.ToLower().Contains(TxtSearch.Text.ToLower()) || item.Last_Name.ToLower().Contains(TxtSearch.Text.ToLower()))
                {
                    TxtFirstName.Text = item.First_Name;
                    TxtLastName.Text = item.Last_Name;
                    TxtEmail.Text = item.Email;
                    TxtPhone.Text = item.PhoneNumber;
                    TxtNotes.Text = item.AdditionalNotes;
                    if (item.Type == "Business")
                    {
                        GboxBusiness.Visible = true;
                        TxtCompany.Text = ((Business_Contact)item).CompanyName;
                        TxtBPhone.Text = ((Business_Contact)item).BusinessPhone;
                        TxtFax.Text = ((Business_Contact)item).Fax;
                    }
                    else if (item.Type == "Social")
                    {
                        GboxBusiness.Visible = false;
                        TxtFb.Text = ((Social_Contact)item).FaceBook;
                        TxtBirthdate.Text = ((Social_Contact)item).Birth_Date;
                    }
                    check = true;
                }
            }
            if (!check)
            {
                GboxBusiness.Visible = true;
                TxtFirstName.Text = "";
                TxtLastName.Text = "";
                TxtEmail.Text = "";
                TxtPhone.Text = "";
                TxtCompany.Text = "";
                TxtBPhone.Text = "";
                TxtFax.Text = "";
            }


        }

        

        private void listBox_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void ContactBookForm_Click(object sender, EventArgs e)
        {
            GboxBasic.Enabled = false;
            GboxContactDetails.Enabled = false;
            GboxBusiness.Enabled = false;
            BtnApply.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnExit.Enabled = true;
            BtnAddContact.Enabled = true;
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                GboxContactDetails.Enabled = true;
                GboxBasic.Enabled = true;
                BtnApply.Enabled = true;
                if (iterator_.Get_Current_Contact().Type == "Business")
                    GboxBusiness.Enabled = true;

                else
                    GboxBusiness.Enabled = false;
            }
            catch { }
        }

       


           



        private void listBox_VisibleChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtPhotopath.Text = ofd.FileName;
                UpdatePhotoBox(ofd.FileName);
            }

        }

        private void UpdatePhotoBox(String file_path)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(file_path);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.Contact_Photo;
                //ExceptionForm ep = new ExceptionForm();
                //ep.Show();
            }
        }

        private void GboxBasic_Enter(object sender, EventArgs e)
        {

        }

        private void GboxContacts_Enter(object sender, EventArgs e)
        {

        }

        
    }
}

