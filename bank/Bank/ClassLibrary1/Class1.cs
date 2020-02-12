using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using static System.Console;

namespace bankomat
{
    class Account
    {
        private Client client;
        public Account(uint pin, decimal balanse, int bancomat_nom)
        {
            this.pin = pin;
            this.balanse = balanse;
            this.bancomat_nom = bancomat_nom;
        }
        public uint pin { get; private set; } = 0;
        public decimal balanse { get; set; } = 0;
        public int bancomat_nom { get; set; }

        public void add_acc(string name, string fname, string pname)
        {
            client = new Client(name, fname, pname);
        }

        public void credit(int money)
        {
            balanse += money;
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Ваш счёт пополнен ");
        }
        public void debit(int money)
        {
            if (money < balanse)
            {
                ForegroundColor = ConsoleColor.Red;
                string a = "Не получится снять деньги с счёта \n Так как эта сумма превышает сумму вашего баланса:";

                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i]);

                    Thread.Sleep(20);

                }
            }
            else if (money > balanse)
            {
                balanse -= money;
                ForegroundColor = ConsoleColor.Red;
                string b = "С вашего счёта были сняты деньги ";
                for (int i = 0; i < b.Length; i++)
                {
                    Console.Write(b[i]);

                    Thread.Sleep(20);

                }
            }

        }
        public void show_balance()
        {
            WriteLine($" На вашем счету{balanse}.00 $ ");
        }

    }
}