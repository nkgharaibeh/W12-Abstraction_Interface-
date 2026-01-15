using System;

namespace CsharpInterface_Example4_MultipleInterfaces
{
    interface IPolygon
    {
        void CalculateArea(int a, int b);
    }

    interface IColor
    {
        void GetColor();
    }

    // One class implements two interfaces
    class Rectangle : IPolygon, IColor
    {
        public void CalculateArea(int a, int b)
        {
            int area = a * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }

        public void GetColor()
        {
            Console.WriteLine("Red Rectangle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.CalculateArea(100, 200);
            r1.GetColor();

            Console.ReadLine();
        }
    }
}
