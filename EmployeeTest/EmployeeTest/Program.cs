using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            long budget = 0;

            StringBuilder csvString;

            csvString = new StringBuilder();

            csvString.AppendLine("Employee4,Employee2,500");
            csvString.AppendLine("Employee3,Employee1,500");
            csvString.AppendLine("Employee1,,1000");
            csvString.AppendLine("Employee5,Employee1,500");
            csvString.AppendLine("Employee2,Employee1,800");

            employees = new Employees(csvString.ToString());
            
            budget = employees.GetSalaryBudget("Employee1");
            Console.WriteLine(budget);
        }
    }
}
