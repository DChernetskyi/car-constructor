using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone
{
    class Display
    {
        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (type == "fool")
                    Console.WriteLine("error");
                else
                    type = value;
            }
        }
    }
}
