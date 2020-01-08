using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любой символ: ");
            char c = Console.ReadKey().KeyChar;
            
            int b = c;

            var z = c;

            var p = new { Position = "Manager", Salary = 2500 };
            var u = new { Name = "Thomas", Surname = "McDowell", Age = 23, Job = p };

            if (c >= 97 && c <= 122)
            {
                Console.WriteLine("\nКод символа {0} - {1}", c, b);
                Console.WriteLine("Код прописной {1} {0}", (char)(c - 32), c - 32);
            }
            if (c >= 65 && c <= 90)
            {
                Console.WriteLine("\nКод символа {0} - {1}", c, b);
                Console.WriteLine("Код прописной {0} - {1}", (char)(c + 32), b + 32);
            }

            Console.ReadKey();
        }
    }
}
