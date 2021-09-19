using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace MyStore_GB_.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> employees = new()
        {
            new Employee {  }
        };
        public IActionResult Index()
        {
            return View();
        }
    }
}
