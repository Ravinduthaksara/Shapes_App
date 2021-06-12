using System;
using System.Collections.Generic;
using System.Text;


namespace Shapes_App
{
    class cone
    {
        //declare variables making their access specifire private for encapsulate
        private double Height, Radius,Result,Slantheight,ConeVolume;

        //building constructors
        public cone()
        {
            Console.WriteLine("Welcome To Cone Calculation section !!!");
        }

        public cone(int a, int b)
        {
            Height = a;
            Radius = b;
        }

        //making property procedures
        public double height
        {
            get
            {
                return Height;
            }
            set
            {
                Height = value;
            }
        }

        public double radius
        {
            get
            {
                return Radius;
            }
            set
            {
                Radius = value;
            }
        }

        //building methods
        public double Calculatesurface()
        {
            
            Slantheight = Math.Sqrt((Height * Height) + (Radius * Radius));
            Result = 3.14 * Radius * (Radius + Slantheight);
            return Result;
        }

        public double Calculatevolume()
        {
            ConeVolume = 3.14 * Radius * Radius * (Height / 3);
            return ConeVolume;
        }

        //using getters and setters
        //public void Setvalueheight(double x)
        //{
        //    Height = x;
        //}

        //public void Setvalueradius(double y)
        //{
        //    Radius = y;
        //}

        //public double getvalueheight()
        //{
        //    return Height;
        //}

        //public double getvalueslantheight()
        //{
        //    return Radius;
        //}



    }
}
