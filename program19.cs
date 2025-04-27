using System;

namespace MyFirstApp19
{
    public class Vehicles
    {
        public virtual void Move()
        {
            Console.WriteLine("Vehicle is moving...");
        }
    }

    public class Carsss : Vehicles
    {
        public override void Move()
        {
            Console.WriteLine("Car is driving on the road.");
        }
    }

    public class Airplane : Vehicles
    {
        public new void Move()
        {
            Console.WriteLine("Airplane is preparing for flight on runway.");
        }

        public void Fly()
        {
            Console.WriteLine("Airplane is flying in the sky!");
        }
    }
}