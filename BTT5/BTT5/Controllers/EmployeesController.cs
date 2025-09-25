using Microsoft.AspNetCore.Mvc;
using EmployeeApp.Models;

namespace EmployeeApp.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, FullName = "Nguyen Van A", Gender = "Male", Phone = "0123456789", Email = "a@example.com", Salary = 1000, Status = "Active" },
                new Employee { Id = 2, FullName = "Tran Thi B", Gender = "Female", Phone = "0987654321", Email = "b@example.com", Salary = 1200, Status = "Inactive" },
                new Employee { Id = 3, FullName = "Le Van C", Gender = "Male", Phone = "0369852147", Email = "c@example.com", Salary = 1500, Status = "Active" },
                new Employee { Id = 4, FullName = "Pham Thi D", Gender = "Female", Phone = "0741852963", Email = "d@example.com", Salary = 1300, Status = "Active" },
                new Employee { Id = 5, FullName = "Hoang Van E", Gender = "Male", Phone = "0159753486", Email = "e@example.com", Salary = 1100, Status = "Inactive" },
                new Employee { Id = 6, FullName = "Vu Thi F", Gender = "Female", Phone = "0753159864", Email = "f@example.com", Salary = 1400, Status = "Active" },
                new Employee { Id = 7, FullName = "Do Van G", Gender = "Male", Phone = "0951357842", Email = "g@example.com", Salary = 1250, Status = "Active" }
            };

            return View(employees);
        }
    }
}
