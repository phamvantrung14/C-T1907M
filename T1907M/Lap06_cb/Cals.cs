using System;

namespace T1907M.Lap06_cb
{
    public delegate int MathNumber(int a, int b);
    public class Cals
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a + b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public static MathNumber FetFunction(int choose)
        {
            switch (choose)
            {
                case 1:
                    return Sum;
                case 2:
                    return Sub;
                case 3:
                    return Mul;
                case 4:
                    return Div;
                default: return null;
            }
        }
    }
}