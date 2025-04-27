using System;

namespace MyFirstApp11
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public void Drive()
        {
            Console.WriteLine(Brand + " is driving at " + Speed + " km/h.");
        }
    }
}

