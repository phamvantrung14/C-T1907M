using System;
using System.Collections.Generic;

namespace T1907M.Lab_2_3
{
    public class Test
    {
         public static void Main(string[] args)
        {
            Product p1 = new Product(1,"san pham1",2,"mabc","mo ta san pham1",144,new List<string>() );
            p1.AddGallery("anh2");
            Fashion f1 = new Fashion(2,"quan ao",1500,"abc.","mota",144,new List<string>(),"red",11);
            Diamon d1 = new Diamon(3,"kim cuong 18",0,"da","mota",1400,new List<string>(),11);
            Cart c1 = new Cart(1,"nguyen hoa",0,new List<Product>(),"HG","VN");
            c1.AddProduct(p1);
            c1.AddProduct(f1);
            c1.AddProduct(d1);
            Console.WriteLine("tjong tien "+c1.FinalTotal());

        }
    }
}