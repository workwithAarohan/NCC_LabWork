using System;

namespace OverrideAndOverload
{
    public class Derived: Base
    {
        public override void display()
        {
            Console.WriteLine("This is derived class.");
        }
        public void display(string Name)
        {
            Console.WriteLine("Hello I am " + Name);
        }
    }
}


