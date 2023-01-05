using System;
using System.Collections.Generic;
using System.Text;

namespace _05._01._2023
{
    internal class Employee
    { 
        static int _noCount;
        public string No;
        public int EmployeeCount;
        public string Type;
        private string _fullName;
        public double Salary;
        DateTime StartDate;
        static Employee()
        {
            _noCount = 100;
        }
        public Employee(string type)
        {
            _noCount++;
            this.Type = type;
            No = type[0] + _noCount.ToString();

        }
        public string FullName
        {
            get => _fullName;
            set
            {
                if (char.IsUpper(FullName[0]))
                    _fullName = value;
            }
        }
        
    }
}
