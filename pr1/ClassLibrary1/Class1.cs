using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        private string FName;
        private string LName;
        private string Email;
        private string Username;
        private string Password;

        public User(string f, string l, string e, string u, string p)
        {
            FName = f;
            LName = l;
            Email = e;
            Username = u;
            Password = p;
        }
        public void set_FName(string s)
        {
            FName = s;
        }
        public void set_LName(string s)
        {
            LName = s;
        }
        public void set_Email(string s)
        {
            Email = s;
        }
        public void set_Username(string s)
        {
            Username = s;
        }
        public void set_Password(string s)
        {
            Password = s;
        }

        public void set_Master(string f, string l, string e, string u, string p)
        {
            set_FName(f);
            set_LName(l);
            set_Email(e);
            set_Username(u);
            set_Password(p);
        }
    }
}
