namespace T1907M.Assiment5
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhoneBook p = new PhoneBook();
            p.insertPhone("trung","123456789");
            p.insertPhone("hai","0123456888");
            p.insertPhone("tu","0123456");
            p.insertPhone("tu ga","0123456");
            p.insertPhone("tran h","0123456");
            p.insertPhone("tran h","0000666");
            p.updatePhone("trung","0000236");
            p.removePhone("tu");
            
            
        }
    }
}