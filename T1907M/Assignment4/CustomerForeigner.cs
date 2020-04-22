using System;

namespace T1907M.Assignment4
{
    public class CustomerForeigner:Customer
    {
        private string nationality;
        private int qty;
        private int unitPrice;
        private double intoMoney;

        public CustomerForeigner()
        {
        }

        public CustomerForeigner(string customerCode, string name, int billOutDate, string nationality, int qty, int unitPrice) : base(customerCode, name, billOutDate)
        {
            this.nationality = nationality;
            this.qty = qty;
            this.unitPrice = unitPrice;
        }

        public string Nationality
        {
            get => nationality;
            set => nationality = value;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public int UnitPrice
        {
            get => unitPrice;
            set => unitPrice = value;
        }

        public string CustomerCode1
        {
            get => customerCode;
            set => customerCode = value;
        }

        public string Name1
        {
            get => name;
            set => name = value;
        }

        public int BillOutDate1
        {
            get => billOutDate;
            set => billOutDate = value;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Quoc tich: ");
            this.nationality = Console.ReadLine();
            Console.WriteLine("So KW tieu thu: ");
            this.qty = Int32.Parse(Console.ReadLine());
            this.unitPrice = 2000;
            Console.WriteLine("Dinh muc: "+unitPrice);
            
        }
        public double IntoMoney(int qty,int unitPrice)
        {
            
            intoMoney = qty * unitPrice;
            return intoMoney;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Quoc tich: "+this.nationality
                                           +", KW tieu thu: "+this.qty
                                           +", Dinh muc: "+this.unitPrice
                                           +", Thanh tien: "+this.intoMoney+" VND");
            
        }
    }
}