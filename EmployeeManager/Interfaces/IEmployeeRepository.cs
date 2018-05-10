using EmployeeManager.Models;
using System.Collections.Generic;

namespace EmployeeManager.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        Employee Get(string employeeId);

        void Add(Employee employee);

        bool Remove(string employeeId);

        bool Update(Employee employee);
    }
}
