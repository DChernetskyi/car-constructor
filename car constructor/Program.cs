using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            car Car = new car("Audi", "A8", 2, 2000);
            Car.GetInfo();
            Console.ReadLine();
        }
    }
}
