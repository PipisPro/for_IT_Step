using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Person
    {
        public string FNAME { get; set; }
        public string LNAME { get; set; }
        public string PNAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }

        public override string ToString()
        {
            return FNAME+PNAME+LNAME;
        }
    }

    public class Z_2
    {
        public const double currency = 13.37;

        public const string str = "1XBET!";
    }
}
