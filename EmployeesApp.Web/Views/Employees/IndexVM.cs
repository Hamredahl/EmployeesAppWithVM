using EmployeesApp.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees;

public class IndexVM
{
    public required EmployeeVM[] Employees { get; set; }

    public class EmployeeVM
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        //public required string Email { get; set; } Behövs ej
        public required bool ShowAsHighlighted { get; set; }
    }
}
