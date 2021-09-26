using Models;
using MyStore_GB_.Models.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore_GB_.Models.Service
{
    public class EmployeeService : IEmployeeService
    {
        static List<Employee> employees = new()
        {
            new Employee { Id = 1, LastName = "Stivenson", FirstName = "Stiv", Role = "DEV" },
            new Employee { Id = 2, LastName = "Stivenson", FirstName = "Bob", Role = "PM" },
            new Employee { Id = 3, LastName = "Stivenson", FirstName = "Shelly", Role = "QA" }
        };

        public void Create(Employee employee)
        {
            employee.Id = employees.Max(t => t.Id + 1);
            employees.Add(employee);
        }

        public bool Delete(int id)
        {
            if (employees.Remove(employees.FirstOrDefault(t => t.Id == id)) == true) return true;
            return false;
        }

        public Employee Details(int id)
        {
            return (Employee)employees.FirstOrDefault(t => t.Id == id);
        }

        public void Edit(Employee employee)
        {
            employees.Remove(employees.FirstOrDefault(t => t.Id == employee.Id));
            employees.Add(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }
    }
}
