using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDotNetDay1
{
    public class DotNetRuntimeDemo
    {
        public void ShowTypes()
        {
            int age = 35;
            string name = "Abhinav";
            bool isDeveloper = true;
            decimal salary = 50000;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Is Developer: {isDeveloper}");
            Console.WriteLine($"Salary: {salary}");

            Console.WriteLine();
            Console.WriteLine("Actual .NET Types:");

            Console.WriteLine(age.GetType());
            Console.WriteLine(name.GetType());
            Console.WriteLine(isDeveloper.GetType());
            Console.WriteLine(salary.GetType());
        }
    }
}
