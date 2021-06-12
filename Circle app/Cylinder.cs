using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_App
{
    class Cylinder
    {
        //members - declaration
        private int radius;
        private int height;
        public Cylinder()
        {
            Console.WriteLine("Welcome To Cylinder Calculation section !!!");
        }
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

        //property procedure - Declare a Height property of type int
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        //other methods
        public float CylinderArea()
        {
            return (2 * (22 / 7) * radius * height) + (2 * (22 / 7) * radius * radius);
        }

        public float CylinderVolume()
        {
            return (22 / 7) * radius * radius * height;
        }
    }
}

    

 