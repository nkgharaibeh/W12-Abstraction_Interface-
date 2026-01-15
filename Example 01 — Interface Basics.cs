using System;

namespace Tutlane_Interface_Example1
{
    // Interface = a contract (ONLY declarations, no implementation bodies)
    // Note: Interface members are implicitly public in C#.
    interface IUser
    {
        void GetDetails(string x);
    }

    // Class implements interface using ':'
    class User : IUser
    {
        public void GetDetails(string a)
        {
            Console.WriteLine("Name: {0}", a);
        }
    }

    // Another class implementing the same interface (different behavior/output)
    class User1 : IUser
    {
        public void GetDetails(string a)
        {
            Console.WriteLine("Location: {0}", a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // We cannot do: IUser u = new IUser();  // ERROR: interface cannot be instantiated

            // We can create an object from a class that implements the interface
            IUser u = new User();
            u.GetDetails("Ahmed Ali");

            IUser u1 = new User1();
            u1.GetDetails("Jordan");

            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
