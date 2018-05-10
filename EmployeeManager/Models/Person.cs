using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}
