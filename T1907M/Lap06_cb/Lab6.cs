using System;

namespace T1907M.Lap06_cb
{
    public class Lab6
    {
        public static void Main(string[] args)
        {
            int choose;
            do
            {
                ShowMenu();
                choose = ReadNumber();
                if (choose>=0 && choose<=5)
                {
                    Console.WriteLine("nhap so thu nhat: ");
                    int no1 = ReadNumber();
                    Console.WriteLine("nhap so thu hai: ");
                    int no2 = ReadNumber();
                    MathNumber mn = Cals.FetFunction(choose);
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("Tong 2 so: "+mn(no1,no2));
                            break;
                        case 2:
                            Console.WriteLine("Hieu 2 so: "+mn(no1,no2));
                            break;
                        case 3:
                            Console.WriteLine("Tich 2 so: "+mn(no1,no2));
                            break;
                        case 4:
                            Console.WriteLine("Thuong 2 so: "+mn(no1,no2));
                            break;
                    }
                }
                
                
            } while (choose !=0);
           
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Lua chon chuc nang:");
            Console.WriteLine("1. cong");
            Console.WriteLine("2. tru");
            Console.WriteLine("3. nhan");
            Console.WriteLine("4. chia");
            Console.WriteLine("5. thoat");
            
        }

        public static int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}