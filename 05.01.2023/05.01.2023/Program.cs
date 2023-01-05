using System;

namespace _05._01._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("HR");
            Employee employee2 = new Employee("Accountant");
            Employee employee3 = new Employee("Secretary");
            Console.WriteLine(employee1.No);
            Console.WriteLine(employee2.No);
            Console.WriteLine(employee3.No);
        }
    }
}
