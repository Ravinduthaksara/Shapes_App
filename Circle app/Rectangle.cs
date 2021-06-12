using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_App
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            Console.WriteLine("Welcome To Rectangle Calculation section !!!");
        }
        public Rectangle(int a, int b)
        {
            length = a;
            width = b;
        }

        public float CalculateCircumference()
        {
            float rc = 2*(length + width);
            return rc;
        }
        public float CalculateArea()
        {
            float area = length * width;
            return area;
        }

        public void Setvalues(int a, int b)
        {
            length = a;
            width = b;
        }
        public int Getlength()
        {
            return length;
            
        }
        public int Getwidth()
        {
            return width;
        }
    }
}
