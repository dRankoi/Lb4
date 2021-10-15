using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4._3
{
    class Y : Letter
    {
        string x, y, z;
        public Y(string X, string Y, string Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public override void Print()
        {
            Console.WriteLine($"Class Y: {x}, {y}, {z}");
            Debug.WriteLine($"{x.GetType()} Y.X: {x}");
            Debug.WriteLine($"{y.GetType()} Y.Y: {y}");
            Debug.WriteLine($"{z.GetType()} Y.Z: {z}");
        }
    }
}
