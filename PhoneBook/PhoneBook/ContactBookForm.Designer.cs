namespace PhoneBook
{
    partial class ContactBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactBookForm));
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GboxContacts = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.GboxContactDetails = new System.Windows.Forms.GroupBox();
            this.GboxBusiness = new System.Windows.Forms.GroupBox();
            this.TxtFax = new System.Windows.Forms.TextBox();
            this.TxtBPhone = new System.Windows.Forms.TextBox();
            this.TxtCompany = new System.Windows.Forms.TextBox();
            this.LblFax = new System.Windows.Forms.Label();
            this.LblBPhone = new System.Windows.Forms.Label();
            this.LblCompany = new System.Windows.Forms.Label();
            this.GboxSocial = new System.Windows.Forms.GroupBox();
            this.TxtBirthdate = new System.Windows.Forms.TextBox();
            this.TxtFb = new System.Windows.Forms.TextBox();
            this.LblBirthdate = new System.Windows.Forms.Label();
            this.LblFaceBook = new System.Windows.Forms.Label();
            this.GboxNotes = new System.Windows.Forms.GroupBox();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.GboxBasic = new System.Windows.Forms.GroupBox();
            this.PhotoPreviewBox = new System.Windows.Forms.GroupBox();
            this.TxtPhotopath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.BtnAddContact = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.GboxContacts.SuspendLayout();
            this.GboxContactDetails.SuspendLayout();
            this.GboxBusiness.SuspendLayout();
            this.GboxSocial.SuspendLayout();
            this.GboxNotes.SuspendLayout();
            this.GboxBasic.SuspendLayout();
            this.PhotoPreviewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(837, 706);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(93, 42);
            this.BtnApply.TabIndex = 0;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(993, 706);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(93, 42);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(1158, 706);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(93, 42);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GboxContacts
            // 
            this.GboxContacts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GboxContacts.BackgroundImage")));
            this.GboxContacts.Controls.Add(this.listBox);
            this.GboxContacts.Location = new System.Drawing.Point(40, 79);
            this.GboxContacts.Name = "GboxContacts";
            this.GboxContacts.Size = new System.Drawing.Size(520, 554);
            this.GboxContacts.TabIndex = 3;
            this.GboxContacts.TabStop = false;
            this.GboxContacts.Text = "Contacts";
            this.GboxContacts.Enter += new System.EventHandler(this.GboxContacts_Enter);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(6, 22);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(504, 526);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.EnabledChanged += new System.EventHandler(this.listBox_EnabledChanged);
            this.listBox.VisibleChanged += new System.EventHandler(this.listBox_VisibleChanged);
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(673, 706);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(93, 42);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // GboxContactDetails
            // 
            this.GboxContactDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GboxContactDetails.BackgroundImage")));
            this.GboxContactDetails.Controls.Add(this.GboxBusiness);
            this.GboxContactDetails.Controls.Add(this.GboxSocial);
            this.GboxContactDetails.Controls.Add(this.GboxNotes);
            this.GboxContactDetails.Controls.Add(this.GboxBasic);
            this.GboxContactDetails.Location = new System.Drawing.Point(668, 21);
            this.GboxContactDetails.Name = "GboxContactDetails";
            this.GboxContactDetails.Size = new System.Drawing.Size(622, 679);
            this.GboxContactDetails.TabIndex = 5;
            this.GboxContactDetails.TabStop = false;
            this.GboxContactDetails.Text = "Contact Details";
            // 
            // GboxBusiness
            // 
            this.GboxBusiness.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GboxBusiness.BackgroundImage")));
            this.GboxBusiness.Controls.Add(this.TxtFax);
            this.GboxBusiness.Controls.Add(this.TxtBPhone);
            this.GboxBusiness.Controls.Add(this.TxtCompany);
            this.GboxBusiness.Controls.Add(this.LblFax);
            this.GboxBusiness.Controls.Add(this.LblBPhone);
            this.GboxBusiness.Controls.Add(this.LblCompany);
            this.GboxBusiness.Location = new System.Drawing.Point(21, 234);
            this.GboxBusiness.Name = "GboxBusiness";
            this.GboxBusiness.Size = new System.Drawing.Size(580, 199);
            this.GboxBusiness.TabIndex = 2;
            this.GboxBusiness.TabStop = false;
            this.GboxBusiness.Text = "Business";
            // 
            // TxtFax
            // 
            this.TxtFax.Location = new System.Drawing.Point(204, 135);
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(343, 24);
            this.TxtFax.TabIndex = 5;
            this.TxtFax.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // TxtBPhone
            // 
            this.TxtBPhone.Location = new System.Drawing.Point(204, 84);
            this.TxtBPhone.Name = "TxtBPhone";
            this.TxtBPhone.Size = new System.Drawing.Size(343, 24);
            this.TxtBPhone.TabIndex = 4;
            this.TxtBPhone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TxtCompany
            // 
            this.TxtCompany.Location = new System.Drawing.Point(204, 36);
            this.TxtCompany.Name = "TxtCompany";
            this.TxtCompany.Size = new System.Drawing.Size(343, 24);
            this.TxtCompany.TabIndex = 3;
            // 
            // LblFax
            // 
            this.LblFax.AutoSize = true;
            this.LblFax.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblFax.Location = new System.Drawing.Point(42, 141);
            this.LblFax.Name = "LblFax";
            this.LblFax.Size = new System.Drawing.Size(35, 18);
            this.LblFax.TabIndex = 2;
            this.LblFax.Text = "Fax";
            // 
            // LblBPhone
            // 
            this.LblBPhone.AutoSize = true;
            this.LblBPhone.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblBPhone.Image = ((System.Drawing.Image)(resources.GetObject("LblBPhone.Image")));
            this.LblBPhone.Location = new System.Drawing.Point(42, 88);
            this.LblBPhone.Name = "LblBPhone";
            this.LblBPhone.Size = new System.Drawing.Size(109, 18);
            this.LblBPhone.TabIndex = 1;
            this.LblBPhone.Text = "Business No.";
            // 
            // LblCompany
            // 
            this.LblCompany.AutoSize = true;
            this.LblCompany.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblCompany.Location = new System.Drawing.Point(42, 42);
            this.LblCompany.Name = "LblCompany";
            this.LblCompany.Size = new System.Drawing.Size(84, 18);
            this.LblCompany.TabIndex = 0;
            this.LblCompany.Text = "Company ";
            // 
            // GboxSocial
            // 
            this.GboxSocial.BackColor = System.Drawing.Color.NavajoWhite;
            this.GboxSocial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GboxSocial.BackgroundImage")));
            this.GboxSocial.Controls.Add(this.TxtBirthdate);
            this.GboxSocial.Controls.Add(this.TxtFb);
            this.GboxSocial.Controls.Add(this.LblBirthdate);
            this.GboxSocial.Controls.Add(this.LblFaceBook);
            this.GboxSocial.Location = new System.Drawing.Point(21, 234);
            this.GboxSocial.Name = "GboxSocial";
            this.GboxSocial.Size = new System.Drawing.Size(580, 199);
            this.GboxSocial.TabIndex = 1;
            this.GboxSocial.TabStop = false;
            this.GboxSocial.Text = "Social";
            this.GboxSocial.Enter += new System.EventHandler(this.GboxSocial_Enter);
            // 
            // TxtBirthdate
            // 
            this.TxtBirthdate.Location = new System.Drawing.Point(204, 119);
            this.TxtBirthdate.Name = "TxtBirthdate";
            this.TxtBirthdate.Size = new System.Drawing.Size(343, 24);
            this.TxtBirthdate.TabIndex = 3;
            // 
            // TxtFb
            // 
            this.TxtFb.Location = new System.Drawing.Point(204, 46);
            this.TxtFb.Name = "TxtFb";
            this.TxtFb.Size = new System.Drawing.Size(343, 24);
            this.TxtFb.TabIndex = 2;
            // 
            // LblBirthdate
            // 
            this.LblBirthdate.AutoSize = true;
            this.LblBirthdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblBirthdate.Location = new System.Drawing.Point(42, 125);
            this.LblBirthdate.Name = "LblBirthdate";
            this.LblBirthdate.Size = new System.Drawing.Size(78, 18);
            this.LblBirthdate.TabIndex = 1;
            this.LblBirthdate.Text = "BirthDate";
            // 
            // LblFaceBook
            // 
            this.LblFaceBook.AutoSize = true;
            this.LblFaceBook.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblFaceBook.Location = new System.Drawing.Point(42, 52);
            this.LblFaceBook.Name = "LblFaceBook";
            this.LblFaceBook.Size = new System.Drawing.Size(85, 18);
            this.LblFaceBook.TabIndex = 0;
            this.LblFaceBook.Text = "FaceBook";
            // 
            // GboxNotes
            // 
            this.GboxNotes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GboxNotes.BackgroundImage")));
            this.GboxNotes.Controls.Add(this.TxtNotes);
            this.GboxNotes.Location = new System.Drawing.Point(21, 439);
            this.GboxNotes.Name = "GboxNotes";
            this.GboxNotes.Size = new System.Drawing.Size(580, 147);
            this.GboxNotes.TabIndex = 2;
            this.GboxNotes.TabStop = false;
            this.GboxNotes.Text = "Additional Notes";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(6, 23);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(568, 118);
            this.TxtNotes.TabIndex = 0;
            // 
            // GboxBasic
            // 
            this.GboxBasic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GboxBasic.BackgroundImage")));
            this.GboxBasic.Controls.Add(this.PhotoPreviewBox);
            this.GboxBasic.Controls.Add(this.TxtPhone);
            this.GboxBasic.Controls.Add(this.TxtEmail);
            this.GboxBasic.Controls.Add(this.TxtLastName);
            this.GboxBasic.Controls.Add(this.TxtFirstName);
            this.GboxBasic.Controls.Add(this.LblPhone);
            this.GboxBasic.Controls.Add(this.LblEmail);
            this.GboxBasic.Controls.Add(this.LblLastName);
            this.GboxBasic.Controls.Add(this.LblFirstName);
            this.GboxBasic.Location = new System.Drawing.Point(21, 24);
            this.GboxBasic.Name = "GboxBasic";
            this.GboxBasic.Size = new System.Drawing.Size(580, 197);
            this.GboxBasic.TabIndex = 0;
            this.GboxBasic.TabStop = false;
            this.GboxBasic.Text = "Basic Information";
            this.GboxBasic.Enter += new System.EventHandler(this.GboxBasic_Enter);
            // 
            // PhotoPreviewBox
            // 
            this.PhotoPreviewBox.Controls.Add(this.TxtPhotopath);
            this.PhotoPreviewBox.Controls.Add(this.pictureBox1);
            this.PhotoPreviewBox.Location = new System.Drawing.Point(403, 28);
            this.PhotoPreviewBox.Name = "PhotoPreviewBox";
            this.PhotoPreviewBox.Size = new System.Drawing.Size(144, 110);
            this.PhotoPreviewBox.TabIndex = 9;
            this.PhotoPreviewBox.TabStop = false;
            this.PhotoPreviewBox.Text = "PhotoBox";
            // 
            // TxtPhotopath
            // 
            this.TxtPhotopath.Location = new System.Drawing.Point(6, 80);
            this.TxtPhotopath.Name = "TxtPhotopath";
            this.TxtPhotopath.Size = new System.Drawing.Size(132, 24);
            this.TxtPhotopath.TabIndex = 9;
            this.TxtPhotopath.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::PhoneBook.Properties.Resources.Contact_Photo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(204, 155);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(343, 24);
            this.TxtPhone.TabIndex = 7;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(204, 114);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(193, 24);
            this.TxtEmail.TabIndex = 6;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(204, 69);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(193, 24);
            this.TxtLastName.TabIndex = 5;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(204, 28);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(193, 24);
            this.TxtFirstName.TabIndex = 4;
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblPhone.Location = new System.Drawing.Point(36, 161);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(88, 18);
            this.LblPhone.TabIndex = 3;
            this.LblPhone.Text = "Phone No.";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblEmail.Location = new System.Drawing.Point(36, 119);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(50, 18);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Email";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblLastName.Location = new System.Drawing.Point(36, 72);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(89, 18);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Last Name";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblFirstName.Location = new System.Drawing.Point(36, 34);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(91, 18);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "First Name";
            // 
            // BtnAddContact
            // 
            this.BtnAddContact.Location = new System.Drawing.Point(175, 639);
            this.BtnAddContact.Name = "BtnAddContact";
            this.BtnAddContact.Size = new System.Drawing.Size(168, 79);
            this.BtnAddContact.TabIndex = 6;
            this.BtnAddContact.Text = "Add Contact";
            this.BtnAddContact.UseVisualStyleBackColor = true;
            this.BtnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(61, 42);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(323, 24);
            this.TxtSearch.TabIndex = 8;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblSearch.Location = new System.Drawing.Point(58, 21);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(61, 18);
            this.LblSearch.TabIndex = 7;
            this.LblSearch.Text = "Search";
            // 
            // ContactBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1327, 839);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.BtnAddContact);
            this.Controls.Add(this.GboxContactDetails);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.GboxContacts);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnApply);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ContactBookForm";
            this.Text = "Contacts Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.ContactBookForm_Load);
            this.Click += new System.EventHandler(this.ContactBookForm_Click);
            this.GboxContacts.ResumeLayout(false);
            this.GboxContactDetails.ResumeLayout(false);
            this.GboxBusiness.ResumeLayout(false);
            this.GboxBusiness.PerformLayout();
            this.GboxSocial.ResumeLayout(false);
            this.GboxSocial.PerformLayout();
            this.GboxNotes.ResumeLayout(false);
            this.GboxNotes.PerformLayout();
            this.GboxBasic.ResumeLayout(false);
            this.GboxBasic.PerformLayout();
            this.PhotoPreviewBox.ResumeLayout(false);
            this.PhotoPreviewBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GboxContacts;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.GroupBox GboxContactDetails;
        private System.Windows.Forms.GroupBox GboxBasic;
        private System.Windows.Forms.GroupBox GboxBusiness;
        private System.Windows.Forms.GroupBox GboxSocial;
        private System.Windows.Forms.TextBox TxtFax;
        private System.Windows.Forms.TextBox TxtBPhone;
        private System.Windows.Forms.TextBox TxtCompany;
        private System.Windows.Forms.Label LblFax;
        private System.Windows.Forms.Label LblBPhone;
        private System.Windows.Forms.Label LblCompany;
        private System.Windows.Forms.TextBox TxtBirthdate;
        private System.Windows.Forms.TextBox TxtFb;
        private System.Windows.Forms.Label LblBirthdate;
        private System.Windows.Forms.Label LblFaceBook;
        private System.Windows.Forms.Button BtnAddContact;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblFirstName;
        public System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.GroupBox GboxNotes;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox PhotoPreviewBox;
        private System.Windows.Forms.TextBox TxtPhotopath;
        private System.Windows.Forms.Label LblSearch;
    }
}

