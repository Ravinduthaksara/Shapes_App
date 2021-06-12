using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_App
{
    class Cube
    {
        //Member variable dicleration.
        private int lenght;
        

        //cube constructor
        public Cube()
        {
            lenght = 0;
            
        }

        //Property procediure for lenght  
        public int Lenght
        {
            get {
                return lenght;
            }

            set {
                lenght = value;
            }
        }
        

        //other methods
        public double AreaofCube()
        {
            double area;
            area = 6 * (lenght*lenght);
            return area;
        }

        public double volumeOfCube()
        {
            double volume;
            volume = lenght * lenght * lenght;
            return volume;
        }
    }
}
