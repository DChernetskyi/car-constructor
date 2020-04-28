using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_constructor
{
    class car
    {
        public string name;
        public string model;
        public int age;
        public int weight;

        public car(string n, string m, int a, int w) { name = n; model = m; age = a; weight = w; }
        public void GetInfo()
        {
            Console.WriteLine($"marka: {name} model: {model} vozrast: {age} ves: {weight}");
        }
    }
}
