using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_App
{
    class Sphere
    {
        //members - declaration
        private int radius;

        //property procedure - Declare a Radius property of type int
        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        //other methods
        public float SphereArea()
        {
            return 4 * (22 / 7) * radius * radius;
        }

        public float SphereVolume()
        {
            return (4 / 3) * (22 / 7) * radius * radius * radius;
        }
    }
}
