using System;

namespace CsharpInterface_Example4_InterfaceReference
{
    interface IPolygon
    {
        void CalculateArea(int l, int b);
    }

    class Rectangle : IPolygon
    {
        public void CalculateArea(int l, int b)
        {
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using reference variable of an interface:
            // This is a key OOP idea: "program to an interface, not an implementation"
            IPolygon r1 = new Rectangle();
            r1.CalculateArea(100, 200);

            Console.ReadLine();
        }
    }
}
