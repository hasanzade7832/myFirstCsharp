using System;

namespace MyFirstApp18
{
    public class Employee
    {
        public virtual void CalculateSalary()
        {
            Console.WriteLine("Employee Salary: 5,000,000");
        }
    }

    public class Manager : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Manager Salary: 7,000,000 + 500,000 Bonus");
        }
    }

    public class Worker : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Worker Salary: 4,000,000");
        }
    }
}