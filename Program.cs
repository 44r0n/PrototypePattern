using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = GetPrototype1();
            Console.WriteLine(prototype.Text);
            prototype = GetPrototype2();
            Console.WriteLine(prototype.Text);
        }

        static Prototype GetPrototype1() => new ConcretePrototype1().Clone();

        static Prototype GetPrototype2() => new ConcretePrototype2().Clone();
    }
}
