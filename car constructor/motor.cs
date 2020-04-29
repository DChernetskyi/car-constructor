using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_constructor
{
    class motor
    {
        public string name;
        public motor(string motorName) { name = motorName; }
        
        public void Zavesty()
        {
            Console.WriteLine($"zaveden {name}");
        }
    }
}
