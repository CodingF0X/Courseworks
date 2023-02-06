using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace PhoneBook
{

    public   class ContactList
    {

        private int size = 0;
    
        public List<Contact> list;

        public static ContactList listInstance = null;



        public ContactList()
        {
            list = new List<Contact>();
        }

        public void Add_(Contact p)
        {
            list.Add(p);
            size++;
        }

        public void Remove_(int index)
        {
            list.RemoveAt(index);
            size--;
        }

        public void editContact(Contact new_Contact, Contact old_Contact)
        {
            int old_position = list.IndexOf(old_Contact);
            list.Remove(old_Contact);
            list.Insert(old_position, new_Contact);

        }

        public List<Contact> GetAllContacts_()
        {
            return list;
        }

        public int Count()
        {
            return size;
        }

        public Contact Get_Person(int index)  // to get item at a specific index 
        {
            return list.ElementAt(index);
        }

        public ContactList_Itrerator CreateIterator()
        {
            ContactList_Itrerator iterator_ = new ContactList_Itrerator();
            return iterator_;
        }

        public static ContactList GetInstance()
        {
            if (listInstance == null)
            {
                listInstance = new ContactList();
            }
            return listInstance;
        }
    }
}
