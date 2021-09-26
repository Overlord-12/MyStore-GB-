using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore_GB_.Models.Service.Interface
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAll();
        public bool Delete(int id);
        public Employee Details(int id);
        public void Edit(Employee employee);
        public void Create(Employee employee);
    }
}
