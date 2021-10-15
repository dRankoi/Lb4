using System;

namespace Laba4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            X x = new X("1", "2", "3");
            Y y = new Y("2", "3", "4");
            Z z = new Z("5", "6", "7");

            x.Print();
            y.Print();
            z.Print();

            Console.ReadKey();
        }
    }
}
