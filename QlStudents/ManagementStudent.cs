using System;
using System.Collections.Generic;

namespace QlStudents
{
    public class ManagementStudent
    {
        List<Student> listSt = new List<Student>();

        public void AddData()
        {
            
            Console.WriteLine("So Student can nhap: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student st = new Student();
                st.inputData();
                listSt.Add(st);
            }
        }

        public void RemoveData()
        {
            Console.WriteLine("Nhạp thu tu can xoa:");
            int keyword = Convert.ToInt32(Console.ReadLine());
            listSt.RemoveAt(keyword);
           
        }

        public void ShowData()
        {
            //Student st = new Student();
            Console.WriteLine("Danh sach Student: ");
            foreach (var VARIABLE in listSt)
            {
                VARIABLE.display();
                Console.WriteLine("---------------");
            }
        }

        public void SearchingByName()
        {
            Console.WriteLine("nhap tu can tim kiem");
            String seaching = Console.ReadLine();
           
            for (int i = 0; i < listSt.Count; i++)
            {
                if (listSt[i].GetType().Equals(seaching))
                {
                    
                }
            }
        }
        
    }
}