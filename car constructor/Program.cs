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
            int x = Vvod();
            int y = Vvod();
            string q = VvodMotor();
            motor motor = new motor(q);
            car Car = new car(x, y, motor);
            Car.motor.Zavesty();
            Car.GetInfo();
            Console.ReadLine();
        }
       
        static int Vvod()
        {
            int a = int.Parse(Console.ReadLine());
            return a;

        }
        static string VvodMotor()
        {
            string t = Console.ReadLine();
            return t;
        }
    }
}
