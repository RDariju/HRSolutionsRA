using Microsoft.AspNetCore.Mvc;
using HRSolutions.Models;
using System.Threading.Tasks;
using HRSolutions.Data;

namespace HRSolutions.Controllers
{
    public class EmployeeController : Controller
    {
        //private readonly IEmployeeService _employeeService;
        private readonly ApplicationDbContext _context;

        //public employeeController(IEmployeeService employeeService)
        //{
        //    _employeeService = employeeService;
        //}

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult NewEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewEmployee(Employee employee)
        {
            
            if (ModelState.IsValid)
            {
                _context.Employee.Add(employee);
                _context.SaveChanges();
                return RedirectToAction(); // or wherever you want to go next
            }

            return View();
        }
    }
    }
