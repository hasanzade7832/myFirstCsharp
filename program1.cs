using System;

namespace MyFirstApp1
{
    public static class Program1
    {
        public static void PrintUserInfo(string name, int age, double height, bool isStudent, char grade)
        {

            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("height: " + height);
            Console.WriteLine("isStudent: " + isStudent);
            Console.WriteLine("grade: " + grade);
        }
    }
}
