using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    class Program
    {
        static void Main(string[] args)
        {
            Ruchka ruchka = new Ruchka();
            ruchka.color = "black";

            Door door = new Door(ruchka, 30);
            door.GetInfo();
            Console.ReadLine();

        }
    }
}
