using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_App
{
    class Cuboid
    {
        //declare variables making their access specifire private for encapsulate
        private int Cuboidlength, CuboidWidth, CuboidHeight,Total,cuboidvolume;

        //building constructors
        public Cuboid()
        {
            Console.WriteLine("Welcome To Cuboid Calculation section !!!");

        }
        public Cuboid(int a, int b, int c)
        {
            Cuboidlength = a;
            CuboidWidth = b;
            CuboidHeight = c;

        }

        //making property procedures
        public int cuboidlength
        {
            get
            {
                return Cuboidlength;
            }
            set
            {
                Cuboidlength = value;
            }
        }

        public int cuboidwidth
        {
            get
            {
                return CuboidWidth;
            }
            set
            {
                CuboidWidth = value;
            }
        }

        public int cuboidheight
        {
            get
            {
                return CuboidHeight;
            }
            set
            {
                CuboidHeight = value;
            }
        }


        //building methods
        public int Calculatecuboidsurface()
        {
            Total = 2*(Cuboidlength * CuboidWidth + CuboidWidth*CuboidHeight+ CuboidHeight*Cuboidlength);
            return Total;
        }

        public int Calculatecuboidvolume()
        {
            cuboidvolume = Cuboidlength * CuboidWidth * CuboidHeight;
            return cuboidvolume;

        }

        //Using Getters and setters
        //public void Setcuboidvalue(int a, int b, int c)
        //{
        //    Cuboidlength = a;
        //    CuboidWidth = b;
        //    CuboidHeight = c;

        //}

        //public int Getcuboidlength()
        //{
        //    return Cuboidlength;
        //}
        //public int Getcuboidwidth()
        //{
        //    return CuboidWidth;
        //}
        //public int Getcuboidheight()
        //{
        //    return CuboidHeight;
        //}

    }
}
