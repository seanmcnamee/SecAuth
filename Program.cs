using System;
using Query;
namespace SecAuth
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Authentication.Login("username", "");
            //Authentication.sendAuthenticationEmail("sean4mc5@gmail.com", "NYIT", "Sean", "McNamee", "ABCABC123");

/*             String[] schools = {"NYIT", "NYU"};
            User u = new User("BillyBob", User.UserType.HighSchooler, "true", "sean4mc5@gmail.com", schools);
            u.messages.Add("Mod >> Fuck off ya cheeky cunt");
            u.messages.Add("You >> Aren't you supposed to moderate chat?");
            u.messages.Add("*You have been kicked from the channel*");
            u.sendMessageHistory(); */


            Queries conn = new Queries();
            conn.insertUser();
            conn.closeConenction();
            
            Console.WriteLine("Hello World!");
        }
    }
}
