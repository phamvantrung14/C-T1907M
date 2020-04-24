using System;
using System.Collections.Generic;

namespace T1907M.Assiment5
{
    public class PhoneBook:Phone
    {
        
        private string name;
        private string phone;
        private string newphone;
        List<PhoneBook> listBook = new List<PhoneBook>();
        public PhoneBook()
        {
        }
        
        public PhoneBook(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

     
        public override void insertPhone(string name, string phone)
        {
            for (int i = 0; i < listBook.Count; i++)
            {
                if (listBook[i].name.Equals(name))
                {
                    if (listBook[i].Equals(phone))
                    {
                        return;
                    }

                    listBook[i].phone = listBook[i].phone + ":" + phone;
                    return;
                }
            }
            listBook.Add(new PhoneBook(name,phone));
        }

        public override void removePhone(string name)
        {
            for (int i = 0; i < listBook.Count; i++)
            {
                if (listBook[i].name.Equals(name))
                {
                    listBook.RemoveAt(i);
                }
                listBook[i].Display();
            }
        }

        public override void updatePhone(string name, string newphone)
        {
            for (int i = 0; i < listBook.Count; i++)
            {
                if (listBook[i].name.Equals(name))
                {
                    listBook[i].phone = newphone;
                }
            }
        }

        public override void searchPhone(string name)
        {
            for (int i = 0; i < listBook.Count; i++)
            {
                if (listBook[i].name.Equals(name))
                {
                    listBook[i].Display();
                }
            }

            
        }

        public void Display()
        {
            Console.WriteLine("name: "+this.name+" -phone: "+this.phone);
        }
    }
}