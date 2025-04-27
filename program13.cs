using System;

namespace MyFirstApp13
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine(Brand + " is moving at " + Speed + " km/h.");
        }
    }
}
