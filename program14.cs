using System;
using MyFirstApp13; // ارجاع به Vehicle

namespace MyFirstApp14
{
    public class Carss : Vehicle
    {
        public string Model { get; set; }

        // بازنویسی متد Drive مخصوص Car
        public override void Drive()
        {
            Console.WriteLine("The car " + Brand + " " + Model + " is driving fast at " + Speed + " km/h!");
        }

        // متد اضافه‌ی مخصوص Car
        public void ShowCarInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Speed: " + Speed + " km/h");
        }
    }
}
