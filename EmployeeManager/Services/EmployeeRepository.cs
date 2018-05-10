using EmployeeManager.Interfaces;
using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManager.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IList<Employee> _employees;

        public EmployeeRepository()
        {
            _employees = new List<Employee>
            {
                new Employee
                {
                    EmployeeId = "e2577888-2980-4986-90f1-b0d569adeaef",
                    Name = "Michał Sykutera",
                    Gender = "Male",
                    Role = "Software Engineer",
                    Skills = new List<string> { "Frontend development", "Backend development" },
                },
                new Employee
                {
                    EmployeeId = "fe5f5556-042b-48ef-9d91-6c896acd8d21",
                    Name = "Jan Kowalski",
                    Gender = "Male",
                    Role = "Project manager",
                    Skills = new List<string> { "Management", "Job interviewing" },
                },
                new Employee
                {
                    EmployeeId = "a4b192e6-259f-4a59-96b8-1d43c2c10bd1",
                    Name = "Maria Nowak",
                    Gender = "Female",
                    Role = "Software Tester",
                    Skills = new List<string> { "Integration Testing", "Unit Testing" },
                },
                new Employee
                {
                    EmployeeId = "fe5f5553-042b-48ef-9d91-6c896acd8d21",
                    Name = "Jerzy Janowicz",
                    Gender = "Male",
                    Role = "Team leader",
                    Skills = new List<string> { "Management", "Job interviewing" },
                },
                new Employee
                {
                    EmployeeId = "e2577881-2980-4986-90f1-b0d569adeaef",
                    Name = "Michał Łukowicz",
                    Gender = "Male",
                    Role = "Junior Software Engineer",
                    Skills = new List<string> { "Frontend development", "Backend development" },
                },
            };
        }

        public IEnumerable<Employee> GetAll() => _employees;

        public void Add(Employee employee)
        {
            while (true)
            {
                employee.EmployeeId = Guid.NewGuid().ToString();
                if (_employees.Any(x => x.EmployeeId == employee.EmployeeId))
                    continue;

                _employees.Add(employee);
                return;
            }
        }

        public bool Remove(string employeeId)
        {
            var employee = _employees.SingleOrDefault(x => x.EmployeeId == employeeId);
            if (employee != null)
            {
                _employees.Remove(employee);
                return true;
            }
            return false;
        }

        public bool Update(Employee employee)
        {
            if (Remove(employee.EmployeeId))
            {
                Add(employee);
                return true;
            }
            return false;
        }

        public Employee Get(string employeeId)
        {
            var employee = _employees.SingleOrDefault(x => x.EmployeeId == employeeId);
            return employee;
        }
    }
}
