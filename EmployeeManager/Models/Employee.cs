using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Models
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; }

        [Required]
        public string Role { get; set; }

        public IEnumerable<string> Skills { get; set; }
    }
}