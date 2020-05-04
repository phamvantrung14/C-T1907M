using System;

namespace Addresbook
{
    public class Contact
    {
        protected string name;
        protected string company;
        protected string email;
        protected string phoneNumber;

        public Contact()
        {
        }

        public Contact(string name, string company, string email, string phoneNumber)
        {
            this.name = name;
            this.company = company;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Company
        {
            get => company;
            set => company = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public void Display()
        {
            Console.WriteLine("Name: "+this.name+", Company: "+this.company+", Email: "+this.email+", Phone number: "+this.phoneNumber);
        }
    }
}