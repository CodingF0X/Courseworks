using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{

    public  class Social_Contact:Contact
    {
        private string faceBook;
        private string birth_Date;


        public string FaceBook
        {
            get { return faceBook; }
            set { faceBook = value; }
        }
        public string Birth_Date
        {
            get { return birth_Date; }
            set { birth_Date = value; }
        }

        public Social_Contact(string firstName,string lastName, string email,string phoneNo,string type,string additionalNotes ) : base(firstName, lastName, email, phoneNo, type,additionalNotes) { }

        public Social_Contact()
        {
            First_Name = null;
            Last_Name = null;
            Email = null;
            PhoneNumber = null;
            Type = "Social";
            AdditionalNotes = null;
            Photo_path = null;
            FaceBook = null;
            Birth_Date = null;
        }



    }
}
