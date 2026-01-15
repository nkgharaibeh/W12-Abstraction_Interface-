using System;

namespace CsharpInterface_Example3
{
    // Interface method has no body (ONLY signature)
    interface IPolygon
    {
        void CalculateArea(int l, int b);
    }

    // Class implements the interface and MUST provide method body
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
            Rectangle r1 = new Rectangle();
            r1.CalculateArea(100, 200); // output should match slides

            Console.ReadLine();
        }
    }
}
