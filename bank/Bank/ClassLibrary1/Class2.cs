using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace bankomat
{
    public class Client
    {

        public Client(string Name, string FName, string PName)
        {
            this.Name = Name;
            this.FName = FName;
            this.PName = PName;
        }

        public string Name { get; private set; }
        public string FName { get; private set; }
        public string PName { get; private set; }

        ////public void data_name()
        ////{
        ////    WriteLine("Введите ваше имя");
        ////}
        ////public void data_fname()
        ////{
        ////    WriteLine("Введите ваше фамилию ");
        ////}
        ////public void data_pname()
        ////{
        ////    WriteLine("Введите ваше очество ");
        ////}

    }
}