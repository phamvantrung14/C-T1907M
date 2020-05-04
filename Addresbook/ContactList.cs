using System.Collections.Generic;

namespace Addresbook
{
    public class ContactList:Contact
    {
        public ContactList()
        {
        }

        public ContactList(string name, string company, string email, string phoneNumber) : base(name, company, email, phoneNumber)
        {
        }
        private List<Contact> contactList = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contactList.Add(contact);
        }

        public void FindByName(string name)
        {
            foreach (var VARIABLE in contactList)
            {
                if ( VARIABLE.Name.Equals(name))
                {
                    VARIABLE.Display();
                }

               
            }
        }

        public void ShowInfo()
        {
            foreach (var VARIABLE in contactList)
            {
                VARIABLE.Display();
            }
        }
    }
}