using System;
using System.Runtime.CompilerServices;

namespace GeometryExample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double radius;
            double height;
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Console.WriteLine("Radius: "); 
            radius = double.Parse( Console.ReadLine());
            Console.WriteLine("Height: ");
            height = double.Parse(Console.ReadLine());
            
            Cylinder c = new Cylinder(radius,height);
            c.Process();
            c.Result();
        }
        
        
    }
}