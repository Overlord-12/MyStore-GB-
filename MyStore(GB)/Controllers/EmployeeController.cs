using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using MyStore_GB_.Models.Service.Interface;

namespace MyStore_GB_.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employee)
        {
            _employeeService = employee;
        }
        public IActionResult Index()
        {
            return View(_employeeService.GetAll());
        }
        public IActionResult Details(int id)
        {
            return View(_employeeService.Details(id));
        }
        public IActionResult Delete(int id)
        {
            if (_employeeService.Delete(id) == true)
            {

            }
            else ModelState.AddModelError("Role","Не удалось удалить модель");
            return RedirectToAction("Index","Employee", new { t=_employeeService.GetAll()});
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_employeeService.Details(id));
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _employeeService.Edit(employee);
            return RedirectToAction("Index", "Employee");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _employeeService.Create(employee);
            return RedirectToAction("Index", "Employee");
        }
    }
}
