using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;
using EmployeesApp.Web.Views.Employees;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers
{
    public class EmployeesController : Controller
    {
        static EmployeeService service = new EmployeeService();

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = service.GetAll();
            var viewModel = new IndexVM
            {
                Employees = model
                .Select( e => new IndexVM.EmployeeVM
                {
                    Name = e.Name,
                    Id = e.Id,
                    ShowAsHighlighted = e.Email.StartsWith("admin", StringComparison.CurrentCultureIgnoreCase)
                })
                .ToArray()
            };
            return View(viewModel);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
                return View();

            service.Add(employee);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var model = service.GetById(id);
            return View(model);
        }
    }
}
