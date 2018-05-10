using EmployeeManager.Interfaces;
using EmployeeManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeManager.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet("")]
        public IEnumerable<Employee> Employees() => _employeeRepository.GetAll();

        [HttpPost("")]
        public void Add([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
                _employeeRepository.Add(employee);
        }

        [HttpDelete("{employeeId}")]
        public void Remove(string employeeId)
        {
            if (!string.IsNullOrWhiteSpace(employeeId))
                _employeeRepository.Remove(employeeId);
        }

        [HttpPut("")]
        public void Update([FromBody] Employee employee)
        {
            _employeeRepository.Update(employee);
        }

        [HttpGet("{employeeId}")]
        public Employee Get(string employeeId)
        {
            return _employeeRepository.Get(employeeId);
        }
    }
}