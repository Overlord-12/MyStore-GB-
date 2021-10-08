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
        private DataBaseContext _dataBaseContext;
        public EmployeeService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public void Create(Employee employee)
        {
            employee.Id = _dataBaseContext.Employees.Max(t => t.Id + 1);
            _dataBaseContext.Employees.Add(employee);
        }

        public void Delete(int id)
        {
            _dataBaseContext.Employees.Remove(_dataBaseContext.Employees.FirstOrDefault(t => t.Id == id));
        }

        public Employee Details(int id)
        {
            return (Employee)_dataBaseContext.Employees.FirstOrDefault(t => t.Id == id);
        }

        public void Edit(Employee employee)
        {
            _dataBaseContext.Employees.Remove(_dataBaseContext.Employees.FirstOrDefault(t => t.Id == employee.Id));
            _dataBaseContext.Employees.Add(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _dataBaseContext.Employees.ToList();
        }
    }
}
