using System;

namespace CsharpInterface_Example5_Practical
{
    interface IPolygon
    {
        void CalculateArea();
    }

    class Rectangle : IPolygon
    {
        public void CalculateArea()
        {
            int l = 30;
            int b = 90;
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }

    class Square : IPolygon
    {
        public void CalculateArea()
        {
            int l = 30;
            int area = l * l;
            Console.WriteLine("Area of Square: " + area);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.CalculateArea();

            Square s1 = new Square();
            s1.CalculateArea();

            Console.ReadLine();
        }
    }
}
