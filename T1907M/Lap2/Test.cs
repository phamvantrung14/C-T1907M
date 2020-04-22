using System;

namespace T1907M.Lap2
{
    public class Test
    {
        public void Menu()
        {
            Console.WriteLine("*********Menu**************");
            Console.WriteLine("1. Them Product");
            Console.WriteLine("2. Danh sach Product");
            Console.WriteLine("3. Kiem tra product");
            Console.WriteLine("4. Them Anh Gallery");
            Console.WriteLine("5. Xoa anh Gallery");
            Console.WriteLine("6. Thoat");
            Console.WriteLine("Moi ban lua chon.");
        }
        static void Main(string[] args)
        {
            Product pd = new Product();
            Test test = new Test();
            int choose;
            do
            {
               
                test.Menu();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        
                        pd.AddData();
                        break;
                    case 2:
                        pd.GetData();
                        break;
                    case 3:
                        pd.CheckProduct();
                        break;
                    case 4:
                        pd.AddGallery();
                        break;
                    case 5:
                        pd.DeleteGallery();
                        break;
                    case 6:
                        Console.WriteLine("Thoat");
                        break;
                    default:
                        Console.WriteLine("Moi ban lua chon tu 1-> 6");
                        break;
                }
            } while (true);
        }

       
    }
}