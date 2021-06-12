using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_App
{
    class Circle
    {   //members declaration
        //to encapsulate make this private
        private int rad;

        public Circle()
        {
            Console.WriteLine("Welcome To Circle Calculation section !!!");
        }

        public float CalculateCircumference()
        {

            return 2 * 3.14f* rad;
        }

        public float CalculateArea()
        {
            return 22/7 * rad * rad;
        }

        public void Setradius(int a)
        {
            rad = a;
        }

        public int getradius()
        {
            return rad;
        }
    }
}
