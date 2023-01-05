using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._01._2023
{
    internal class Department
    {
        private Employee[] _employees = new Employee[0];
        public Employee[] Employees => _employees;
        public int HRLimit;
        public int AccountantLimit;
        public int SecretaryLimit;
        public void AddEmployee(string type, int employeeCount)
        {if (CountByType(type) < GetLimitByType(type))
            {
                Employee employee = new Employee(type) { EmployeeCount = employeeCount };
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
            }
            
        }
        private int CountByType(string type)
        {
            int count = 0;
            for(int i=0; i<type.Length; i++)
            {
                if (_employees[i].Type == type)
                    count++;
            }
            return count;
        }
        public int GetLimitByType(string type)
        {
            switch (type)
            {
                case "HR":
                    return this.HRLimit;
                case "Accountant":
                    return this.AccountantLimit;
                case "Secretary":
                    return this.SecretaryLimit;
                default:
                    return 0;
            }
        }
        public bool EmployeeSalary(double salary)
        {
            if (salary >= 250)
            { return true; }
            return false;
        }
       


    }
}
