using System;

namespace MyFirstApp17
{
    // --- کلاس والد ---
    public class Animals
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // --- کلاس فرزند با override ---
    public class Dogs : Animals
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks!");
        }
    }

    // --- کلاس فرزند با new ---
    public class Cats : Animals
    {
        public new void Speak()
        {
            Console.WriteLine("Cat meows!");
        }
    }
}
