using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    class Door
    {
        public Ruchka ruchka { get; set; }
        public int ves { get; set; }
        public Door(Ruchka ruchka1, int ves1)
        {
            ruchka = ruchka1;
            ves = ves1;
        }
        public void GetInfo()
        {
            Console.WriteLine($"vess: {ves}, ruchkaColor: {ruchka.color} ");
           
        }
        
    }
}
