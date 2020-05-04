using System;

namespace T1907M.Session6
{
    //khai bao 1 delegate tra ve int va co 2 tham so
    public delegate int IntegerToInteger(int a, int b);
    
    //delegate dai dien cho ham, ko quan tam den ham gi chi quan tam dang gi
    //nap them tham chieu den o nho cua ham
    
    public class Programs
    {
        public static void Main(string[] args)
        {
            IntegerToInteger ii = new IntegerToInteger(Caculator.Add);
            ii += Caculator.Subtract;
            ii+= new Caculator().Division;
            ii(2, 5);


            TaxMoney tm = TaxCaic.GetTax("US");// tm la 1  delegate
            float tax = tm(100000000);
            Console.WriteLine("thue phai nop "+tax);
            
            
            //tao 1 ham an danh bang delegate
            TaxMoney tm2 = delegate(float salary)
            {
                return salary * 40 / 100;
            };
            float frTax = tm2(10000);
            Console.WriteLine("thue tai phap "+frTax);

            
            
            
            PhepTinh pt = Pheptinh.GetPt("-");
            int c= pt(2, 3);
            Console.WriteLine("ket qua "+c);


        }

    
    }
}