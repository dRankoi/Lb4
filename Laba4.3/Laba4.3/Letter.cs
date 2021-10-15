using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4._3
{
    class Letter
    {
        string x, y, z;

        public virtual void Print()
        {
            Console.WriteLine($"Class Letter: {x}, {y}, {z}");
        }
    }
}
