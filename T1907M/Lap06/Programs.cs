using System;
using T1907M.Session6;

namespace T1907M.Lap06
{
    public class Programs
    {
        private int a;
        private int b;
        public void Menu()
        {
            Console.WriteLine("*******Menu********");
            Console.WriteLine("1. Cong");
            Console.WriteLine("2. Tru");
            Console.WriteLine("3. Nhan");
            Console.WriteLine("4. Chia");
            Console.WriteLine(" Moi ban lua chon.");
        }

        public void Input()
        {
            Console.WriteLine("Moi nhap a");
            this.a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap b");
            this.b= Int32.Parse(Console.ReadLine());
        }

        public void PhepCong()
        {
            KetQua kq = PhepToan.GetPt("+");
            Input();
            int d = (int) kq(a, b);
            Console.WriteLine("Ket qua: "+d);
        }
        public void PhepTru()
        {
            KetQua kq = PhepToan.GetPt("-");
            Input();
            int d = (int) kq(a, b);
            Console.WriteLine("Ket qua: "+d);
        }
        public void PhepNhan()
        {
            KetQua kq = PhepToan.GetPt("*");
            Input();
            int d = (int) kq(a, b);
            Console.WriteLine("Ket qua: "+d);
        }
        public void PhepChia()
        {
            KetQua kq = PhepToan.GetPt("/");
            Input();
            
            int d = (int) kq(a, b);
            Console.WriteLine("Ket qua: "+d);
        }
        public static void Main(string[] args)
        {
            Programs p = new Programs();
            int choose;
            do
            {
                p.Menu();
                choose=Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        p.PhepCong();
                        break;
                    case 2:
                        p.PhepTru();
                        break;
                    case 3:
                        p.PhepNhan();
                        break;
                    case 4:
                        p.PhepChia();
                        break;
                    case 5:
                        Console.WriteLine("thoat");
                        break;
                }
            } while (true);
        }
    }
}