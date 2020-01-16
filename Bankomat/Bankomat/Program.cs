using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLib;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Person g = new Person {FNAME = "Gabe", PNAME = "FAT", LNAME = "Newell" };

            Console.WriteLine($"His name is {g.FNAME} {g.PNAME} {g.LNAME}!!!\n");

            Console.WriteLine($"Number: {Z_2.currency}. String: {Z_2.str}");

            Console.ReadKey();
        }
    }
}
