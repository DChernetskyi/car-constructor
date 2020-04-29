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
        public motor motor;
        

        

        public car( int vozrast, int ves, motor name) { age = vozrast; weight = ves; motor = name; }
        
        public void GetInfo()
        {
            Console.WriteLine($" vozrast: {age} ves: {weight}");
        }
    }
}
