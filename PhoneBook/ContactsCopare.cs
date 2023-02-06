using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class ContactComparer :IComparer<Contact>
    {

        public int Compare(Contact x, Contact y)
        {
            string name1 = x.First_Name;
            string name2 = y.First_Name;
            return name1.CompareTo(name2);
        }
    }
}
