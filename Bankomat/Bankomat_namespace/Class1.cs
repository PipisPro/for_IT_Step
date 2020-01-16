using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace Bankomat_namespace
{
    public class Bank
    {
    }

    public class Account
    {
        public string acc_number;
        public decimal balance;

        public Account()
        {
            this.acc_number = "0000 1111 2222 3333";
            this.balance = 1337;
        }

        public Account(string acc_number, decimal balance)
        {
            this.acc_number = acc_number;
            this.balance = balance;
        }

        public string ACC_NUM
        {
            get
            {
                return this.acc_number;
            }
        }

        public decimal BALANCE
        {
            get
            {
                return this.balance;
            }
        }
    }
}
