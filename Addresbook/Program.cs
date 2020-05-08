using System;

namespace Addresbook
{
    class Program
    {
        private string name;
        private string company;
        private string email;
        private string phoneNumber;
        ContactList contact = new ContactList();
        
        static void Main(string[] args)
        {
            Program p = new Program();
            
            int choose;
            do
            {
                choose=p.Menu();
                switch (choose)
                {
                    case 1:
                        p.Input();
                       
                        break;
                    case 2:
                        p.FindByName();
                        break;
                    case 3:
                        p.ShowData();
                        break;
                    case 4:
                        Console.WriteLine("Exit.");
                        break;
                }

            } while (choose!=5);

        }

        public int Menu()
        {
            Console.WriteLine("**********Menu**********");
            Console.WriteLine("1. Add new contact.");
            Console.WriteLine("2. Find a contact by name.");
            Console.WriteLine("3. Display contact.");
            Console.WriteLine("4. Exit.");
            Console.WriteLine("hay lua chon: ");
            return Int32.Parse(Console.ReadLine());
        }

        public void Input()
        {
            Console.WriteLine("Enter name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter company:");
            this.company = Console.ReadLine();
            Console.WriteLine("Enter email:");
            this.email = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            this.phoneNumber = Console.ReadLine();
           contact.AddContact(new Contact(name,company,email,phoneNumber));
        }

        public void ShowData()
        {
            Console.WriteLine("List contact: ");
            contact.ShowInfo();
        }

        public void FindByName()
        {
            Console.WriteLine("Enter name to find: ");
            string namesearch = Console.ReadLine();
            contact.FindByName(namesearch);
        }
        
    }
}