﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Employees
{
    public class Employee    
    {
        string empId;
        string managerId;
        int salary;
        int ceoCount = 0;

        //Dictionary to store managers and employees 
        Dictionary<string, List<string>> managers = new Dictionary<string, List<string>>();
        Dictionary<string, Employee> employees = new Dictionary<string, Employee>();


        //Default constructor for Employer
        public Employee()
        {

        }

        //Employee constructor that takes the csv string
        public Employee(string csvString)
        {
            validateCsv(csvString);
        }

       
        //Method to validate csv string
        public void validateCsv(String csvString)
        {
            StringReader stringReader = new StringReader(csvString);

            // Given the CSV is in the format employeeId, managerId, salary
            while (stringReader.Peek() > -1)
            {
                String row = stringReader.ReadLine();
                String[] param = row.Split(',');
                int paramLength = param.Length;

                empId = param[0];

                //Validation
                //Validate salaries to be integers
                try
                {
                    salary = int.Parse(param[2]);
                }
                catch (Exception e)
                {
                    throw new ArgumentException(e.Message + "Salaries need to be integers");
                }

                //One employee does not report to more than one manager.
                if (paramLength > 3 && (int.Parse(param[2]).Equals(typeof(string))))
                {
                    throw new Exception("Employee reporting to more than one manager");
                }

                //There is only one CEO, i.e. only one employee with no manager.
                if (ceoCount > 1)
                {
                    throw new Exception("There should only be one CEO");
                }
                else if (param[1] == "" && ceoCount <= 2)
                {
                    ceoCount++;
                    managerId = param[1];
                }
                else
                {
                    managerId = param[1];
                }
                //Validate all managers to be employees

                if (empId == null || empId == "")
                {
                    throw new Exception("All managers should be employees");
                }
                //Adding managers to managers dictionary
                if (managerId != "")
                {
                    addManager(managerId, empId);
                }
                //Adding employees to employees dictionary
                employees.Add(empId, createEmployee(empId, managerId, salary));
            } 
        }

        //Create new employees
        public Employee createEmployee(String emplID, String manID, int sal)
        {
            Employee employee = new Employee();
            employee.empId = emplID;
            employee.managerId = manID;
            employee.salary = sal;
            return employee;
        }

        //Add manager to the manager dictionary
        public void addManager(String managerID, String employeeID){
            if (managers.ContainsKey(managerID))
            {
                managers[managerID].Add(employeeID);
            }
            else
            {
                List<string> junior = new List<string>() { employeeID };
                managers.Add(managerID, junior);
            }
        }

        //Method to calculate budget for each manager
        public long managerBudget(String managerId)
        {
            long budget = 0;
            if (!managers.ContainsKey(managerId))
            {
                //Base case
                budget = employees[managerId].salary;
            }
            else
            {
                //Recurse
                foreach(string manager in managers[managerId])
                {
                    budget += managerBudget(manager);
                }
                budget += employees[managerId].salary;
            }
            
            return budget;
        }

    }

}

