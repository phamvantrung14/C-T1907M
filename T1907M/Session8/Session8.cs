using System;
using System.Threading;

namespace T1907M.Session8
{
    public class Session8
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(Run3);
            /*t1.Start("Xin chao");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("main i ="+i);
                Thread.Sleep(100);
            }*/
            t1.Start();
        }

        public static void ThreadRun(object o)
        {
            string msg = (string) o;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(msg+"i ="+i);
                Thread.Sleep(100);
            }
        }

        public static void Run3()
        {
            for (int i = 9; i >=0; i--)
            {
                for (int j = 59; j >=0 ; j--)
                {
                    Console.WriteLine(i.ToString("D2")+":"+j.ToString("D2"));
                    Thread.Sleep(10);
                }
            }
        }
    }
}