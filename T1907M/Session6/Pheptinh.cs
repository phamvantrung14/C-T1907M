using System;

namespace T1907M.Session6
{
    public delegate int PhepTinh(int a, int b);
    public class Pheptinh
    {
        public static int Cong(int a, int b)
        {
            return a + b;
        }
        public static int Tru(int a, int b)
        {
            return a - b;
        }
        public static int Nhan(int a, int b)
        {
            return a * b;
        }
        public static int Chia(int a, int b)
        {
            return a / b;
        }
        public static int Default(int a, int b)
        {
            return 0;
        }
      
        public static PhepTinh GetPt(string pt)
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
                return Default;
            }

        }
    }
}