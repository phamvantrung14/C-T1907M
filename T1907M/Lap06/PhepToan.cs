using System;

namespace T1907M.Lap06
{
    public delegate float KetQua(int a, int b);
    public class PhepToan
    {
        public static float Cong(int a, int b)
        {
            return a + b;
        }
        public static float Tru(int a, int b)
        {
            return a - b;
        }
        public static float Nhan(int a, int b)
        {
            return a * b;
        }
        public static float Chia(int a, int b)
        {
            return a / b;
        }
        public static float Default(int a, int b)
        {
            return 0;
        }
        
        public static KetQua GetPt(string pt)
        {
            if (pt=="+")
            {
                return Cong;
            }else if (pt == "-")
            {
                return Tru;
            }else if (pt == "*")
            {
                return Nhan;
            }else if (pt=="/")
            {
                return Chia;
            }
            else
            {
                Console.WriteLine("phep tinh ko dung");
                return Default;
            }

        }
    }
}