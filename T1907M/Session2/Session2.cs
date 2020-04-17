using System;

namespace T1907M.Session2
{
    public class Session2
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();//s1 là một đối tương được tạo ra từ lớp
            s1.ShowInfo();
            s1.ShowName();
            
            Social.Hello();//className.MethodName()
            Console.WriteLine(Social.FirstWeekOfYear+10);//className.varName
        }
    }
}