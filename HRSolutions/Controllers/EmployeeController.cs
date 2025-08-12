using Microsoft.AspNetCore.Mvc;
using HRSolutions.Models;
using System.Threading.Tasks;
using HRSolutions.Data;
using Microsoft.EntityFrameworkCore;

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
            return View(new Employee());
        }

        [HttpPost]
        public async Task<IActionResult> NewEmployee(Employee employee, IFormFile ProfileImage)
        {

            if (ModelState.IsValid)
            {
                if (ProfileImage != null && ProfileImage.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        await ProfileImage.CopyToAsync(ms);
                        employee.ProfileImage = ms.ToArray();
                    }
                }

                _context.Employee.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction("NewEmployee"); // Replace with your actual success view
            }
            return View(employee);
        }
        //public async Task<IActionResult> EmployeeProfile(string searchName)
        //{
        //    var names = await _context.Employee
        //        .Select(e => e.PreferredName)
        //        .ToListAsync();

        //    ViewBag.Names = names;

        //    if (!string.IsNullOrEmpty(searchName))
        //    {
        //        var employee = await _context.Employee
        //            .FirstOrDefaultAsync(e => e.PreferredName == searchName);

        //        if (employee != null)
        //            return View(employee);

        //        ViewBag.Message = "Employee not found.";
        //        return View(null);
        //    }

        //    return View(null);
        //}

        public IActionResult ViewEmployee(string firstName, string lastName)
        {
            var employee = _context.Employee
                .FirstOrDefault(e => e.FirstName == firstName && e.LastName == lastName);
            if(employee != null)
            {
                var model = new Employee
                {
                    empId = employee.empId,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Title = employee.Title,
                    MiddleName = employee.MiddleName,
                    PreferredName = employee.MiddleName,
                    DateOfBirth = employee.DateOfBirth,
                    Gender = employee.Gender,
                    MaritalStatus = employee.MaritalStatus,
                    BloodGroup = employee.BloodGroup,
                    NICNumber = employee.NICNumber,
                    PassportNumber = employee.PassportNumber,
                    PassportExpiryDate = employee.PassportExpiryDate,
                    Street1 = employee.Street1,
                    Street2 = employee.Street2,
                    City = employee.City,
                    ZIPCode = employee.ZIPCode,
                    State = employee.State,
                    Country = employee.Country,
                    MobileNumber = employee.MobileNumber,
                    PersonalEmail = employee.PersonalEmail,
                    ProfileImage = employee.ProfileImage,
                    JobRole = employee.JobRole,
                    Initials = employee.Initials

                    // PreferredNames not needed anymore unless reused elsewhere
                };
                return View(model);
            }

            return View();
            
        }
    }
    }
