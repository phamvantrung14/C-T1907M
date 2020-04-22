using System;
using T1907M.Lap2;

namespace T1907M.Assignment4
{
    public class CustomerVn:Customer
    {
        private int customerObject;
        private int qty;
        private int unitPrice;
        private int norms;
        private double intoMoney;
        private string customerOb;

        public CustomerVn()
        {
        }

        public CustomerVn(string customerCode, string name, int billOutDate, int customerObject, int qty, int unitPrice, int norms) : base(customerCode, name, billOutDate)
        {
            this.customerObject = customerObject;
            this.qty = qty;
            this.unitPrice = unitPrice;
            this.norms = norms;
        }

        public int CustomerObject
        {
            get => customerObject;
            set => customerObject = value;
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

        public int Norms
        {
            get => norms;
            set => norms = value;
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

        public void CustomerOb()
        {
            Console.WriteLine("1. Sinh hoat.");
            Console.WriteLine("2. Kinh doanh.");
            Console.WriteLine("3. San Xuat.");
        }

        public double CheckNorms(int qty)
        {
            if (qty<50)
            {
                return norms = 1;
            }else if (qty > 50 && qty < 100)
            {
                return norms = 2;
            }else if (qty>100 && qty<200)
            {
                return norms = 3;
            }
            else
            {
                return norms = 4;
            }

            return norms;
        }
        public double CheckUnitPrice(int norms)
        {
             
            if (norms==1)
            {
                return unitPrice = 1000;
                
            }else if (norms==2 )
            {
                return unitPrice = 1200;
            }else if (norms==3)
            {
                return unitPrice = 1500;
            }else if (norms==4)
            {
                return unitPrice = 2000;
            }

            return unitPrice;
        }
        public double IntoMoney(int qty,int unitPrice)
        {
            
            intoMoney = qty * unitPrice;
            return intoMoney;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap doi tuong khach hang: ");
            CustomerOb();
            this.customerObject = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so KW tieu thu: ");
            this.qty = Int32.Parse(Console.ReadLine());
            
           
            
        }

        public void CheckCustomerOb()
        {
            if (this.customerObject ==1)
            {
                customerOb = "Sinh hoat";
            }else if (this.customerObject ==2)
            {
                customerOb = "San xuat";
            }else if (customerObject ==3)
            {
                customerOb = "Kinh doanh";
            }
        }
       
        public override void Display()
        {
            base.Display();
            CheckCustomerOb();
            Console.WriteLine(" CustomerObject: "+this.customerOb
                                                 +", KW tieu thu: "+this.qty
                                                 +", Don Gia: "+this.unitPrice
                                                 +", Dinh muc: "+this.norms
                                                 +", Thanh tien: "+this.intoMoney+" VND");
        }
    }
}