using System;

namespace QlStudents
{
     class Test
    {
        public int Menu()
        {
            Console.WriteLine("*************MENU***************");
            Console.WriteLine("1.them mot student");
            Console.WriteLine("2.xoa mot student");
            Console.WriteLine("3.danh sach toan bo Student");
            Console.WriteLine("4.Sap xep theo average score");
            Console.WriteLine("5.Tim kiem theo ten");
            Console.WriteLine("6.Thoat");
            Console.WriteLine("Moi ban lua chon");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            ManagementStudent MgSt = new ManagementStudent();
            Test test = new Test();
            int chooce;
            do
            {
                chooce=test.Menu();
                switch (chooce)
                {
                    case 1:
                        MgSt.AddData();
                        break;
                    case 2:
                        MgSt.RemoveData();
                        break;
                    case 3:
                        MgSt.ShowData();
                        break;
                    case 4:
                       
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("thoat.");
                        break;
                }
            } while (true);
        }
    }
}