using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4._3
{
    class Z : Letter
    {
        string x, y, z;
        public Z(string X, string Y, string Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public override void Print()
        {
            Console.WriteLine($"Class Z: {x}, {y}, {z}");
            Debug.WriteLine($"{x.GetType()} Z.X: {x}");
            Debug.WriteLine($"{y.GetType()} Z.Y: {y}");
            Debug.WriteLine($"{z.GetType()} Z.Z: {z}");
        }
    }
}