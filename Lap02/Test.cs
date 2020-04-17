using System.Collections;
using System.Collections.Generic;

namespace Lap02
{
    public class Test
    {
        public void ShowInfo(List<Product> listPd)
        {
            foreach (var VAR in listPd)
            {
                VAR.GetInfo();
            }
        }

      //  public void CheckQty(List<Product> listPd)
       // {
          //  Product pd = new Product();
           // for (int i = 0; i < listPd.Count; i++)
           // {
             // pd.QtyInfo(listPd);
            //}
       // }
        public static void Main(string[] args)
        {
            Test test = new Test();
            List<Product> listPd = new List<Product>();
            Product pd = new Product();
            listPd.Add(new Product(11,"Phạm văn A",11,"abc77.png","hang tot"));
            listPd.Add(new Product(12,"Trần văn B",111,"abc64.png","hang tot"));
            listPd.Add(new Product(13,"Nguyễn thị C",0,"abc1.png","hang tot"));
            listPd.Add(new Product(14,"Trần văn D",8,"abc44.png","hang tot"));
            test.ShowInfo(listPd);
            //test.CheckQty(listPd);
        }
    }
}