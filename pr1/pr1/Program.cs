using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 35;
            string s = "Your sallary is: ";

            User wasser = new User("First", "Last", "Email", "Username", "Password");

        //  wasser.set_Master("First", "Last", "Email", "Username", "Password");
            
            Console.WriteLine(s += a + b);  // (s + a + b) - неявная типизация
            Console.ReadKey();
        }
    }
}
