using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
   
    public  class Contact
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string type;
        private string additionalNotes;


        public string First_Name
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Last_Name
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string AdditionalNotes
        {
            get { return additionalNotes; }
            set { additionalNotes = value; }
        }

        private string photo_path;
        public string Photo_path
        {
            get
            {
                return photo_path;
            }
            set
            {
                photo_path = value;
            }
        }


        public Contact()
        {

        }

        public Contact(string firstname, string lastname,string email,string phoneNo,string type,string additionalnotes)
        {
            this.First_Name = firstname;
            this.Last_Name = lastname;
            this.Email = email;
            this.PhoneNumber = phoneNo;
            this.Type = type;
            this.AdditionalNotes = additionalnotes;

        }
    }
}
