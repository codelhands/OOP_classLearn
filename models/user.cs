using System.Text;
using System.Threading.Tasks;


namespace charp.models
{
    public class user
    {
        public string username { get; set; }
        public string password { get; set; }
        public int age { get; set; }

        public void Login(string loginDate)
        {
            Console.WriteLine($"{loginDate} tarihinde");
        }


    }
}