using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone
{
    class Phone
    {
        camera camera;
        Battery battery;
        Display display;
        void NewPhone()
        {
            this.camera = new camera();
            this.battery = new Battery(3500);
            this.display = new Display();

        }
        public Phone(int camera, int battery, string display)
        {
            camera = mpx;
            
        }
    }
}
