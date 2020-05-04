using System;

namespace T1907M.Session6
{
    public class Caculator
    {
        public static int Add(int a, int b)
        {
            Console.WriteLine(a+b);
            return a + b;
        }
        //ham static la co o nho luon
        public static int Subtract(int a, int b)
        {
            Console.WriteLine(a-b);
            return a - b;
        }

        public int Division(int a, int b)
        {
            Console.WriteLine(a/b);
            return a / b;
        }
    }
}