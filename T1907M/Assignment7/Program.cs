using System;

namespace T1907M.Assignment7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int choose = 0;
            Program p = new Program();
            StudentManager st = new StudentManager();
            
            do
            {
                p.Menu();
               
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        st.AddStudent();
                        break;
                    case 2:
                        st.EditStudent();
                        break;
                    case 3:
                        st.DeleteStudent();
                        break;
                    case 4:
                        st.SortStudentByGpa();
                        break;
                    case 5:
                        st.SortStudentByName();
                        break;
                    case 6:
                        st.ShowSt();
                        break;
                    case 0:
                        Console.WriteLine("Thoat");
                        break;
                    default:
                        Console.WriteLine("Nhap tu 0 -> 1");
                        break;
                   
                }
            } while (choose<7);
        }

        public void Menu()
        {
            Console.WriteLine("*********MENU*************");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Edit student by id");
            Console.WriteLine("3. Delete student by id");
            Console.WriteLine("4. Sort student by gpa");
            Console.WriteLine("5. Sort student by name");
            Console.WriteLine("6. Show student");
            Console.WriteLine("0.Exit");
            Console.WriteLine("Moi ban lua chon.");
        }
    }
}