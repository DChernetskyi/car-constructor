using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone
{
    class camera
    {
        private int mpx;
        public int Mpx
        {
            get
            {
                return mpx;
            }
            set
            {
                if (mpx < 5)
                    Console.WriteLine("Плохая камера");
                else
                    mpx = value;
            }
        }
    }
}
