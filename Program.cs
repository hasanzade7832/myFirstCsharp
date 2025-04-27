using System;
using MyFirstApp1;
using MyFirstApp2;
using MyFirstApp3;
using MyFirstApp4;
using MyFirstApp5;
using MyFirstApp6;
using MyFirstApp7;
using MyFirstApp8;
using MyFirstApp9;
using MyFirstApp10;
using MyFirstApp11;
using MyFirstApp12;
using MyFirstApp13;
using MyFirstApp14;
using MyFirstApp15;
using MyFirstApp16;
using MyFirstApp17;
using MyFirstApp18;
using MyFirstApp19;


namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // program1: کار با متغیرها و ورودی‌ها
            //Program1.PrintUserInfo("Sepehr", 20, 1.75, true, 'A');

            // program2: چک کردن سن کاربر
            //Program2.CheckAge(29);

            // program3: کار با آرایه و چاپ خوش آمدگویی
            //string[] myNames = { "Ali", "Zahra", "Mohammad Hoseyn" };
            //Program3.MyList(myNames);

            // program4: ساخت شیء از کلاس Cars
            //Cars myCar = new Cars();
            //myCar.color = "Red";
            //myCar.Drive();

            // program5: استفاده از کلاس استاتیک ship
            //ship.color = "Blue";
            //ship.Drive();

            // program6: کار با متدهای استاتیک و غیر استاتیک
            //int sumResult = Program6.Add(5, 10);
            //Console.WriteLine("Sum Result: " + sumResult);

            //Program6.SayHello("Mohammad Hoseyn");

            // program7: کار با کپسوله سازی در Student
            //Student student1 = new Student();
            //student1.Name = "Mohammad Hoseyn";
            //student1.Age = 20;

            //Console.WriteLine("Student Name: " + student1.Name);
            //Console.WriteLine("Student Age: " + student1.Age);

            //Console.WriteLine("Trying to set negative age...");
            //student1.Age = -5; 
            //Console.WriteLine("Student Age after invalid input: " + student1.Age);

            // program8: حالت ساده‌تر کپسوله سازی (Book)
            //Book myBook = new Book();
            //myBook.Title = "Golestan Saadi";
            //myBook.Pages = 200;

            //Console.WriteLine("Book Title: " + myBook.Title);
            //Console.WriteLine("Book Pages: " + myBook.Pages);

            // program9: استفاده از Constructor بدون پارامتر (Animal)
            //Animal animal = new Animal();
            //Console.WriteLine("Animal Name: " + animal.Name);
            //Console.WriteLine("Animal Age: " + animal.Age);

            // program10: استفاده از Constructor با پارامتر (Car)
            //Car car = new Car("BMW X5", 2022);
            //Console.WriteLine("Car Model: " + car.Model);
            //Console.WriteLine("Car Year: " + car.Year);

            // --- برنامه 11: استفاده از کلاس Vehicle ---
            //چون 11 در ارث بری برای پدر هست لازم نیست در اینجا ازش استفاده بشه

            // --- برنامه 12: استفاده از کلاس CarsNew که از Vehicle ارث‌بری کرده ---
            //CarsNew myNewCar = new CarsNew();
            //myNewCar.Brand = "Mercedes-Benz";
            //myNewCar.Model = "C-Class";
            //myNewCar.Speed = 180;
            //myNewCar.ShowCarInfo();

            //13 چون پدر هست نمیخاد استفاده بشه ازش
            //14 virtual - override
            //Carss myCar = new Carss();
            //myCar.Drive();

            // برنامه 16: استفاده از ارث‌بری Animal برای Dog و Cat
            //Dog myDog = new Dog();
            //myDog.Speak(); // خروجی: Dog barks!

            //Cat myCat = new Cat();
            //myCat.Speak(); // خروجی: Cat meows!

            //Console.WriteLine("--- تست با OVERRIDE ---");
            //Animals myDogAsAnimal = new Dogs();   
            //myDogAsAnimal.Speak();               
            //Console.WriteLine();

            //Console.WriteLine("--- تست با NEW ---");
            //Animals myCatAsAnimal = new Cats();    
            //myCatAsAnimal.Speak();               

            //Console.WriteLine();

            //Console.WriteLine("--- تست مستقیم با شیء واقعی ---");
            //Cat myRealCat = new Cat();         
            //myRealCat.Speak();

            //18
            //Employee emp1 = new Employee();
            //Employee emp2 = new Manager();
            //Employee emp3 = new Worker();

            //Console.WriteLine("📋 نتیجه صدا زدن CalculateSalary:");

            //emp1.CalculateSalary(); // رفتار خود Employee
            //emp2.CalculateSalary(); // رفتار Manager واقعی
            //emp3.CalculateSalary(); // رفتار Worker واقعی

            //19

            Vehicles v1 = new Vehicles();
            Vehicles v2 = new Carsss();
            Vehicles v3 = new Airplane();
            Airplane realPlane = new Airplane();

            Console.WriteLine("📋 تست متد Move() برای انواع Vehicle:");

            v1.Move(); // Vehicle is moving...
            v2.Move(); // Car is driving on the road. (override شده)
            v3.Move(); // Vehicle is moving... (چون new استفاده شده و نوع متغیر Vehicle است ❌)

            Console.WriteLine();
            Console.WriteLine("📋 تست مستقیم با Airplane واقعی:");
            realPlane.Move(); // Airplane is preparing for flight on runway. (چون مستقیم نوع Airplane است ✅)
            realPlane.Fly();  // Airplane is flying in the sky! (متد جدید Fly مخصوص Airplane)

        }
    }
}
