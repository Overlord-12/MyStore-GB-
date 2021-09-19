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
            new Employee { Id = 1, LastName = "Stivenson", FirstName="Stiv", Role = "DEV" },
            new Employee { Id = 2, LastName = "Stivenson", FirstName = "Bob", Role = "PM" },
            new Employee { Id = 3, LastName = "Stivenson", FirstName = "Shelly", Role = "QA" }
        };
        public IActionResult Index()
        {
            return View(employees);
        }
        public IActionResult Details(int id)
        {
            var test = (Employee)employees.FirstOrDefault(t => t.Id == id);
            return View((Employee)employees.FirstOrDefault(t => t.Id == id));
        }
    }
}
