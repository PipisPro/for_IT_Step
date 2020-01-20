using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public abstract class Storage
        {
            private string type;
            private string model;

            public Storage() { }

            public Storage(string type, string model)
            {
                this.type = type;
                this.model = model;
            }

            public string TYPE { get; set; }

            public string MODEL { get; set; }

            public abstract int GetVolume();

            public abstract void CopyData();

            public abstract int EmptyData();

            public abstract string GetInfo();

        }

        public class Flash
        {
            int speed = 600;

        }

    }
}
