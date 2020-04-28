using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_constructor
{
    class car
    {


        public int age;
        public int weight;

        public car( int vozrast, int ves) { age = vozrast; weight = ves; }
        
        public void GetInfo()
        {
            Console.WriteLine($" vozrast: {age} ves: {weight}");
        }
    }
}
