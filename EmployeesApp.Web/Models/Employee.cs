using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace EmployeesApp.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; } = null!;
        public required string Email { get; set; } = null!;
    }
}
