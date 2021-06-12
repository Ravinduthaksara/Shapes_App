using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_App
{ 
    class Pyramid
    {
        // member variable decleration
        private int lenght;
        private int height;
        private double slantHeight;

        //Pyramid Constructor
        public Pyramid()
        {
            lenght = 0;
            height = 0;
            slantHeight = 0;
        }

        //property procediure for height
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
        //property procediure for  Slant height
        public double SlantHeight
        {
            get
            {
                return slantHeight;
            }

            set
            {
                slantHeight = value;
            }
        }
        //Property procediure for lenght  
        public int Lenght
        {
            get
            {
                return lenght;
            }

            set
            {
                lenght = value;
            }
        }
     
        //other methods

        public double volumeOfPyramid()
        {
            double volume;
            volume = ((lenght * lenght) *height) *1/3;
            return volume;
        }

        public double areaOfPyramid()
        {
            double area;
            slantHeight = Math.Sqrt((height*height)+(lenght*0.5));
            area = (lenght * lenght) + (0.5*(4* lenght) *slantHeight);
            return area;
        }
    }
}
