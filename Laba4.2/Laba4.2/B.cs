using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4._2
{
    public class B
    {
        public virtual void PrintProperties()
        {
            Debug.WriteLine($"У класса нет агрументов");
        }
    }
    public class C : B
    {
        public string Name { get; set; } = "";

        public C(string name)
        {
            Name = name;
        }

        public override void PrintProperties()
        {
            Debug.WriteLine("Свойства класса С:");
            Debug.Indent();
            Debug.WriteLine($"{nameof(Name)}: {Name}");
            Debug.Unindent();
        }
    }
}
