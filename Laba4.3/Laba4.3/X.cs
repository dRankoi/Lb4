using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4._3
{
    class X : Letter
    {
        string x, y, z;
        public X(string X, string Y, string Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public override void Print()
        {
            Console.WriteLine($"Class X: {x}, {y}, {z}");
            Debug.WriteLine($"{x.GetType()} X.X: {x}");
            Debug.WriteLine($"{y.GetType()} X.Y: {y}");
            Debug.WriteLine($"{z.GetType()} X.Z: {z}");
        }
    }
}
