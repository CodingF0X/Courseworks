using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
   public  class ContactList_Itrerator
    {

        private int _Current = 0;
        public ContactList data;


        public ContactList_Itrerator()
        {
            data = ContactList.GetInstance();
            _Current = 0;
                
        }

        public void  First()
        {
            _Current = 0;

        }

        public void next()
        {
            _Current++;
        }

        public void get_all_Contacts()
        {
             data.GetAllContacts_();
        }


        public void _add(Contact p)
        {
            data.Add_(p);
        }

        public  Contact Get_Current_Contact()
        {
            if (Check_())
                return null;

            return data.Get_Person(_Current);
        }

        public int Get_Index()
        {
            return _Current;
        }

        public  bool Check_()
        {
            if (_Current >= data.Count()) //checking if the current item is bigger than the size of the list
                return true;
            else
                return false;
        }

       
    }
}
