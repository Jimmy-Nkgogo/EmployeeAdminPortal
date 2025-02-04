using EmployeeAdminPortal.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
           var allEmployees =  dbContext.Employees.ToList();

            return Ok(allEmployees);
        }
        [HttpPost]
        public IActionResult AddEmployee()
        {

        }
    }
}
