using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Lap02_1
{
    class Program
    {
        List<Product> listpd = new List<Product>();

        public void AddData()
        {

            Product pd = new Product();
            Console.WriteLine("So san pham muon them: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("San pham thu " + (i+1) + ": ");
                pd.InputData();
                
                listpd.Add(pd);
            }
        }

        public void ShowInfo()
        {
            foreach (var variable in listpd)
            {
                variable.ShowProduct();
            }
        }

        public int Menu()
        {
            Console.WriteLine("*********MENU***********");
            Console.WriteLine("1.them Product");
            Console.WriteLine("2.Hien thi tat ca san pham");
            Console.WriteLine("Moi ban lua chon:");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            int choice;
            do
            {
                choice = program.Menu();
                switch (choice)
                {
                    case 1:
                        program.AddData();
                        break;
                    case 2:
                        program.ShowInfo();
                        break;
                    case 3:
                        break;
                }
            } while (true);
            // ReSharper disable once FunctionNeverReturns
        }
    
    }
}