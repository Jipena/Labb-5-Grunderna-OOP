using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_5___Grunderna_OOP
{
    public class Circle //Class
    {
        public float pi = 3.141f;
        public int Radius = 0;

        public Circle(int radius) //Constructor
        {
            Radius = radius;
        }

        public double getArea() //Metod
        {
            return Radius * Radius * pi;
        }
    }
}
