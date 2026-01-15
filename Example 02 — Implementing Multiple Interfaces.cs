using System;

namespace Tutlane_Interface_Example2
{
    interface IName
    {
        void GetName(string x);
    }

    interface ILocation
    {
        void GetLocation(string x);
    }

    interface IAge
    {
        void GetAge(int x);
    }

    // A single class can implement multiple interfaces (like "multiple inheritance" of contracts)
    class User : IName, ILocation, IAge
    {
        public void GetName(string a)
        {
            Console.WriteLine("Name: {0}", a);
        }

        public void GetLocation(string a)
        {
            Console.WriteLine("Location: {0}", a);
        }

        public void GetAge(int a)
        {
            Console.WriteLine("Age: {0}", a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.GetName("Ahmed Ali");
            u.GetLocation("Jordan");
            u.GetAge(12);

            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
