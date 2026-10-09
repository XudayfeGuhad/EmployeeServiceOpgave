
using Microsoft.AspNetCore.Mvc;
using IBASEmployeeService.Models;

namespace IBASEmployeeService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = "21",
                    Name = "Mette Bangsbo",
                    Email = "meba@ibas.dk",
                    Department = new Department()
                    {
                        Id = 1,
                        Name = "Salg"
                    }
                },
                new Employee()
                {
                    Id = "22",
                    Name = "Hans Merkel",
                    Email = "hame@ibas.dk",
                    Department = new Department()
                    {
                        Id = 2,
                        Name = "Support"
                    }
                },
                new Employee()
                {
                    Id = "23",
                    Name = "Karsten Mikkelsen",
                    Email = "kami@ibas.dk",
                    Department = new Department()
                    {
                        Id = 2,
                        Name = "Support"
                    }
                },
                new Employee()
                {
                    Id = "24",
                    Name = "Ali Hassan",
                    Email = "ali@ibas.dk",
                    Department = new Department()
                    {
                        Id = 3,
                        Name = "IT"
                    }
                },
                new Employee()
                {
                    Id = "25",
                    Name = "Sara Jensen",
                    Email = "sara@ibas.dk",
                    Department = new Department()
                    {
                        Id = 3,
                        Name = "IT"
                    }
                },
                new Employee()
                {
                    Id = "26",
                    Name = "Omar Ahmed",
                    Email = "omar@ibas.dk",
                    Department = new Department()
                    {
                        Id = 3,
                        Name = "IT"
                    }
                },
                new Employee()
                {
                    Id = "27",
                    Name = "Fatima Noor",
                    Email = "fatima@ibas.dk",
                    Department = new Department()
                    {
                        Id = 4,
                        Name = "Kantinen"
                    }
                },
                new Employee()
                {
                    Id = "28",
                    Name = "Peter Larsen",
                    Email = "peter@ibas.dk",
                    Department = new Department()
                    {
                        Id = 4,
                        Name = "Kantinen"
                    }
                }
            };

            return employees;
        }
    }
}
