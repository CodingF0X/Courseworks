using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
  
   public  class Business_Contact : Contact
    {

        private string companyName;
        private string fax;
        private string businessPhone;


        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        public string BusinessPhone
        {
            get { return businessPhone; }
            set { businessPhone = value; }
        }



        public Business_Contact(string firstname,string lastname,string email, string phone ,string type,string additionalNotes) : base(firstname, lastname, email, phone, type,additionalNotes) { }

        public Business_Contact()
        {
            First_Name = null;
            Last_Name = null;
            Email = null;
            PhoneNumber = null;
            Type = "Business";
            Photo_path = null;
           CompanyName= null;
            Fax = null;
            BusinessPhone = null;
        }
    }
}
