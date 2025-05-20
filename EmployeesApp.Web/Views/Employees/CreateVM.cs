using EmployeesApp.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees
{
    public class CreateVM
    {
        [Required(ErrorMessage = "You must specify a name")]
        public required string Name { get; set; }
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Invalid e-mail address")]
        [Required(ErrorMessage = "You must specify an e-mail address")]
        public required string Email { get; set; }
        [Display(Name = "What is 2 + 2?")]
        [Range(4, 4, ErrorMessage ="Nah bruh you aint hooman!")]
        public required int BotCheck { get; set; }
    }
}
