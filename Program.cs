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

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // program1
            //Program1.PrintUserInfo();

            // program2
            //Program2.CheckAge();

            // program3
            //string[] myNames = { "ali", "zahra", "mmdhosseyn" };
            //Program3.MyList(myNames);

            // program4
            //Cars myCar = new Cars();
            //myCar.color = "red";
            //myCar.Drive();

            // program4 
            //MyFirstApp4.Car myCar = new MyFirstApp4.Car();
            //myCar.color = "red";
            //myCar.Drive();

            // program5 (using static Car from MyFirstApp5)
            //Car.color = "blue";
            //Car.Drive();

            // program6
            int result = Program6.Add(5, 10);
            Console.WriteLine("Sum result: " + result);

            Program6.SayHello("mmdh");

            // program7 (using Student)
            Student student1 = new Student();
            student1.Name = "MohammadHossein";
            student1.Age = 20;

            Console.WriteLine("Student Name: " + student1.Name);
            Console.WriteLine("Student Age: " + student1.Age);

            Console.WriteLine("Trying to set negative age...");
            student1.Age = -5; // Should print error
            Console.WriteLine("Student Age after invalid input: " + student1.Age);

            // program8 (using Book - simple)
            Book myBook = new Book();
            myBook.Title = "Golestan Saadi";
            myBook.Pages = 200;

            Console.WriteLine("Book Title: " + myBook.Title);
            Console.WriteLine("Book Pages: " + myBook.Pages);

            // program9 (using Car - with control)
            Cars1 myCar2 = new Cars1();
            myCar2.Model = "Pride";
            myCar2.Speed = 120;

            Console.WriteLine("Car Model: " + myCar2.Model);
            Console.WriteLine("Car Speed: " + myCar2.Speed);

        }
    }
}
