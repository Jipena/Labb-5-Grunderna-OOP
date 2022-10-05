using System;

namespace Labb_5___Grunderna_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Circle c2 = new Circle(6);
            Console.WriteLine(c1.getArea());
            Console.WriteLine(c2.getArea());
        }
    }
}
