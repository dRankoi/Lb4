using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4._2
{
    public class D : B
    {
        public DateTime Time { get; }

        public D()
        {
            Time = DateTime.Now;
        }

        public override void PrintProperties()
        {
            Debug.WriteLine($"Свойства класса Д:");
            Debug.Indent();
            Debug.WriteLine($"{nameof(Time)}: {Time}");
            Debug.Unindent();
        }
    }
}
