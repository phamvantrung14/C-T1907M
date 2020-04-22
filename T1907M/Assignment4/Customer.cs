using System;

namespace T1907M.Assignment4
{
    public class Customer
    {
        protected string customerCode;
        protected string name;
        protected int billOutDate;
        

        public Customer()
        {
        }

        public Customer(string customerCode, string name, int billOutDate)
        {
            this.customerCode = customerCode;
            this.name = name;
            this.billOutDate = billOutDate;
        }

        public string CustomerCode
        {
            get => customerCode;
            set => customerCode = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int BillOutDate
        {
            get => billOutDate;
            set => billOutDate = value;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap ma khach hang: ");
            customerCode = Console.ReadLine();
            Console.WriteLine("Nhap ten khach hang: ");
            name = Console.ReadLine();
            Console.WriteLine("nhap ngay xuat hoa don: ");
            billOutDate = Int32.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("-Customer code: "+this.customerCode+" -Name: "+this.name+" -Bill Out Date: "+this.billOutDate);
            
        }
    }
}