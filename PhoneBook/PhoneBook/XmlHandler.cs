using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace PhoneBook
{
 
    public class XmlHandler
    {
        
      
        public XmlHandler()
        {
        }

        ContactList list = ContactList.GetInstance();
        ContactList_Itrerator iterator_ = new ContactList_Itrerator();

        public void Save_XML()
        {


            ///////////////////////////////////////////////////////////////////////////
            XmlDocument doc = new XmlDocument();
            doc.Load("Contacts.xml");
            XmlNode xNode = doc.SelectSingleNode("Contacts");
            xNode.RemoveAll();
            //for(int i = 0; i < _list.count();i++)
            for (iterator_.First(); !iterator_.Check_(); iterator_.next())
            {
                string type_Contact;
                type_Contact = iterator_.Get_Current_Contact().Type;

                XmlNode xTop = doc.CreateElement("Contact");
                XmlNode xType = doc.CreateElement("Type");
                XmlNode xName = doc.CreateElement("FirstName");
                XmlNode xLastName = doc.CreateElement("LastName");
                XmlNode xEmail = doc.CreateElement("Email");
                XmlNode xPhone = doc.CreateElement("PhoneNumber");
                              XmlNode xNotes = doc.CreateElement("AdditionalNotes");
                XmlNode xPhoto_path = doc.CreateElement("Photo_path");


                xName.InnerText = iterator_.Get_Current_Contact().First_Name;
                xLastName.InnerText = iterator_.Get_Current_Contact().Last_Name;
                xEmail.InnerText = iterator_.Get_Current_Contact().Email;
                xPhone.InnerText = iterator_.Get_Current_Contact().PhoneNumber;
                xType.InnerText = iterator_.Get_Current_Contact().Type;
                xNotes.InnerText = iterator_.Get_Current_Contact().AdditionalNotes;
                xPhoto_path.InnerText = iterator_.Get_Current_Contact().Photo_path;

           

                xTop.AppendChild(xName);
                xTop.AppendChild(xLastName);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xPhone);
                xTop.AppendChild(xType);
                xTop.AppendChild(xNotes);
                xTop.AppendChild(xPhoto_path);



                if (type_Contact == "Social")
                {
                    XmlNode xFb = doc.CreateElement("FaceBook");
                    XmlNode xBirthday_date = doc.CreateElement("Birthday_date");

                    Social_Contact sc = (Social_Contact)list.Get_Person(iterator_.Get_Index()); // to get the properity of FaceBook from that class at this particular index. (
                    xFb.InnerText = sc.FaceBook;
                    xBirthday_date.InnerText = sc.Birth_Date;
                    xTop.AppendChild(xFb);
                    xTop.AppendChild(xBirthday_date);
                }

                else if (type_Contact == "Business")
                {
                    XmlNode xCompany = doc.CreateElement("Company");
                    XmlNode xFax = doc.CreateElement("Fax");
                    XmlNode xB_phone = doc.CreateElement("BusinessNo");

                    Business_Contact bc = (Business_Contact)list.Get_Person(iterator_.Get_Index());
                    xCompany.InnerText = bc.CompanyName;
                    xFax.InnerText = bc.Fax;
                    xB_phone.InnerText = bc.BusinessPhone;



                    xTop.AppendChild(xCompany);
                    xTop.AppendChild(xB_phone);
                    xTop.AppendChild(xFax);

                }
       
                doc.DocumentElement.AppendChild(xTop);
            }

            doc.Save("Contacts.xml");
        }


        public void Sort_(ContactList cList)
        {
            ContactComparer comp = new ContactComparer();
            cList.list.Sort(comp);

        }


       
    }
}

  
       
    

