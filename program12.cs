namespace MyFirstApp12
{
    // Car از Vehicle ارث‌بری میکنه
    public class CarsNew : MyFirstApp11.Vehicle
    {
        public string Model { get; set; }

        public void ShowCarInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Speed: " + Speed + " km/h");
        }
    }
}

