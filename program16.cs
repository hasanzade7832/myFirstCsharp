using System;
using MyFirstApp15;

namespace MyFirstApp16
{
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks!");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows!");
        }
    }
}
