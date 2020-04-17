using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace T1907M.Session2
{
    public static class Social//trong static class chỉ có static function và static vảrrible
    {
        //tạo ra các chức năng tĩnh để gọi ra dùng không cần tao ra đối tượng 
        public static int FirstWeekOfYear;
        public static void Hello()
        {
            
        }
        //không thể tao object từ static class
        //vì static class đã có sẵn ô nhớ
    }
}