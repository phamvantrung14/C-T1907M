using System;
using System.Collections;
using System.Collections.Generic;

namespace Lap02
{
    public class Test
    {
        public void ShowInfo(List<Fashion> listPd)
        {
            foreach (var VAR in listPd)
            {
                VAR.GetInfo();
                Console.WriteLine("**********");
            }
        }

        public void CheckQty(List<Fashion> listPd)
        {
            //Product pd = new Product();
            foreach (var VAR in listPd)
            {
                VAR.QtyInfo();
            }
            Console.WriteLine("-ok-");
        }
        public void ShowInfo(List<Diamon> listPd)
        {
            foreach (var VAR in listPd)
            {
                VAR.GetInfo();
                Console.WriteLine("**********");
            }
        }

        public void CheckQty(List<Diamon> listPd)
        {
            //Product pd = new Product();
            foreach (var VAR in listPd)
            {
                VAR.QtyInfo();
                //VAR.Check();
                Console.WriteLine("-----------");
            }
            Console.WriteLine("-ok-");
        }
        
        public static void Main(string[] args)
        {
            Test test = new Test();
            List<Fashion> listPd = new List<Fashion>();
            //Product pd = new Product(11,"Phạm văn A",11,"abc77.png","hang tot");
            listPd.Add(new Fashion(11,"Phạm văn A",11,"abc77.png","hang tot","do","L"));
            listPd.Add(new Fashion(12,"Trần văn B",111,"abc64.png","hang tot","hong","xs"));
            listPd.Add(new Fashion(13,"Nguyễn thị C",0,"abc1.png","hang tot","xanh la cay","m"));
            listPd.Add(new Fashion(14,"Trần văn D",8,"abc44.png","hang tot","trang","m"));
            test.ShowInfo(listPd);
            test.CheckQty(listPd);
            Console.WriteLine("**************");
            List<Diamon> listDm = new List<Diamon>();
            listDm.Add(new Diamon(15,"day chuyen 14",0,"abc.png","hang moi",16));
            listDm.Add(new Diamon(16,"nhan",15,"abc.png","hang moi",27));

            listDm.Add(new Diamon(15,"day chuyen mk",99,"abc.png","hang moi",0));

            listDm.Add(new Diamon(15,"lac",15,"abc.png","hang moi",16));
            test.ShowInfo(listDm);
            test.CheckQty(listDm);

        }
    }
}