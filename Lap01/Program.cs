using System;
using System.Collections;

namespace Lap01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            foreach (int value in Fibonacci())
            {
                Console.Write(value +" ");
                if (value >= n)
                {
                    break;
                }
            }
        }

        private static IEnumerable Fibonacci()
        {
            int current = 0;
            int next = 1;
            while (true)
            {
                
                int oldCurrent = current;
                current = next;
                next = next + oldCurrent;
                yield return current;
            }
        }
    }
}