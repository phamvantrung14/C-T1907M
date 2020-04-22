using System;
using System.Collections.Generic;

namespace T1907M.Assignment4
{
    public class Progams
    {
        List<CustomerVn> customerVnList = new List<CustomerVn>();
        List<CustomerForeigner> customerForeignerList = new List<CustomerForeigner>();
        public static void Main(string[] args)
        {
            int choose;
            Progams progams = new Progams();
            do
            {
                progams.Menu();
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        progams.InputDataCustomerVN();
                        break;
                    case 2:
                        progams.InputDataCustomerNG();
                        break;
                    case 3:
                        progams.InfoCustomer();
                        break;
                    case 4:
                        progams.TotalQtyKW();
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine("Thoat");
                        break;
                }
            } while (choose != 7);
        }

        //menu program
        public void Menu()
        {
            Console.WriteLine("**********Menu**********");
            Console.WriteLine("1. Nhap danh sach khach hang viet nam.");
            Console.WriteLine("2. Nhap danh sach khach hang nuoc ngoai.");
            Console.WriteLine("3. Xuat hoa don cho khach hang.");
            Console.WriteLine("4. So luong KW tieu thu cua tung loai Kh.");
            Console.WriteLine("5. Tinh trung binh thanh tien KH nguoi nuoc ngoai.");
            Console.WriteLine("6. Xuat ra hoa don trong thang.");
            Console.WriteLine("7. thoat");
            Console.WriteLine("Moi ban lua chon: ");
        }

        //input data
        public void InputDataCustomerVN()
        {
            Console.WriteLine("Nhap DS KH nguoi VN, So KH muon nhap: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("**Khach hang VN thu "+(i+1)+" :");
                CustomerVn customerVn = new CustomerVn();
                customerVn.Input();
                customerVnList.Add(customerVn);
            }
        }

        public void InputDataCustomerNG()
        {
            Console.WriteLine("Nhap DS KH nguoi NG, So KH muon nhap: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Khach hang NG thu "+(i+1)+" :");
                CustomerForeigner customerForeigner = new CustomerForeigner();
                customerForeigner.Input();
                customerForeignerList.Add(customerForeigner);
            }
        }
        
        //show Data
        public int ShowInfo()
        {
            Console.WriteLine("Lua chon danh sach: ");
            Console.WriteLine("1. DS KH nguoi Viet Nam.");
            Console.WriteLine("2. DS KH nguoi nuoc ngoai.");
            return Int32.Parse(Console.ReadLine());
        }

        public void InfoCustomer()
        {
            int choose =0;
            choose = ShowInfo();
            if (choose == 1)
            {
                //ShowInfoCustomerVN();
                ShowInfoDetailCustomerVN();
            }else if (choose ==2)
            {
                ShowInfoDetailCustomerNG();
                //ShowInfoCustomerNG();
            }
            else
            {
                Console.WriteLine("lua chon khong dung! Xin chon lai.");
            }

            {}
        }
        
        //show all custormer of customerVN
        /*public void ShowInfoCustomerVN()
        {
            Console.WriteLine("Danh sach khach hang nguoi VN: ");
            for (int i = 0; i < customerVnList.Count; i++)
            {
                Console.WriteLine("KH thu "+(i+1)+" :");
                customerVnList[i].CheckNorms(customerVnList[i].Qty);
                customerVnList[i].CheckUnitPrice(customerVnList[i].Norms);
                customerVnList[i].IntoMoney(customerVnList[i].Qty, customerVnList[i].UnitPrice);
                customerVnList[i].Display();
            }
        }*/
        public void ShowInfoDetailCustomerVN()
        {
            Console.WriteLine("Nhap ten KH Viet Nam ");
            string nameCustomer = Console.ReadLine();
            for (int i = 0; i < customerVnList.Count; i++)
            {
                if (customerVnList[i].Name.Equals(nameCustomer))
                {
                    customerVnList[i].CheckNorms(customerVnList[i].Qty);
                    customerVnList[i].CheckUnitPrice(customerVnList[i].Norms);
                    customerVnList[i].IntoMoney(customerVnList[i].Qty, customerVnList[i].UnitPrice);
                    customerVnList[i].Display();
                }
                
                
            }
        }
        //show all customers of customerNG
        /*public void ShowInfoCustomerNG()
        {
            Console.WriteLine("Danh sach khach hang nguoi NG: ");
            for (int i = 0; i < customerForeignerList.Count; i++)
            {
                Console.WriteLine("KH thu "+(i+1)+" :");
                customerForeignerList[i].Display();
            }
        }*/
        public void ShowInfoDetailCustomerNG()
        {
            Console.WriteLine("Nhap ten KH nguoi nuoc ngoai");
            string nameCustomer = Console.ReadLine();
            for (int i = 0; i < customerForeignerList.Count; i++)
            {
                Console.WriteLine("KH thu "+(i+1)+" :");
                if (customerForeignerList[i].Name.Equals(nameCustomer))
                {
                    customerForeignerList[i].IntoMoney(customerForeignerList[i].Qty, customerForeignerList[i].UnitPrice);
                    customerForeignerList[i].Display();
                }
                
                
            }
        }
        
        //total quantity KW
        public void TotalQtyKW()
        {
           Console.WriteLine("So kw tieu thu VN: "+TotalKwVn()); 
           Console.WriteLine("So kw tieu thu cua nguoi nuoc ngoai: "+TotalKwNG()); ;
        }

        public double TotalKwVn()
        {
            double qtyKwVN = 0;
            for (int i = 0; i < customerVnList.Count; i++)
            {
                qtyKwVN += customerVnList[i].Qty;
                
            }

            return qtyKwVN;
        }

        public double TotalKwNG()
        {
            double qtyKwNG = 0;
            for (int i = 0; i < customerForeignerList.Count; i++)
            {
                qtyKwNG += customerForeignerList[i].Qty;
                
            }

            return qtyKwNG;
        }
    }
}