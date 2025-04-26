using System;

namespace MyFirstApp1
{
    public static class Program1
    {
        public static void PrintUserInfo()
        {
            int age = 20;
            double height = 1.75;
            bool isStudent = true;
            char grade = 'A';
            string name = "sepehr";

            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("height: " + height);
            Console.WriteLine("isStudent: " + isStudent);
            Console.WriteLine("grade: " + grade);
        }
    }
}
