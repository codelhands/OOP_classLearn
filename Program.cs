

using charp.models;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           user User = new user();
           User.username="elif";
           User.password = "123";
           string loginDate = DateTime.Now.ToString();
           User.Login(loginDate);


           Console.WriteLine($"ismi : {User.username}: sifre{User.password}");
        }
    }
}