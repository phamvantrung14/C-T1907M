using System;
using System.Collections;
using System.Collections.Generic;

namespace Lap02
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Test test = new Test();
            
           Product pd = new Product(1,"day chuyen",14,"abc.png","mo ta san pham",14,new List<string>());
           pd.addGallery("ogb");
           Product pd2 = new Product(2,"ao so mi",14,"abc.png","mo ta san pham",14,new List<string>());
           pd2.addGallery("bcc");
           Fashion fs1=new Fashion(2,"day chuyen bac",11,"adc.png","mo ta san pham",15,new List<string>(),"mau do","M" );
           fs1.CheckSize("L");
           fs1.GetInfo();
           pd.GetInfo();
           
           pd2.GetInfo();
           Cart ct1 = new Cart(1,"anh hoa",0,new List<Product>(),"bb","HN" );
           ct1.AddProduct(fs1);
           ct1.AddProduct(pd2);
           ct1.TotalMoney();
           Console.WriteLine("tong tien: "+ct1.TotalMoney());


        }
    }
}