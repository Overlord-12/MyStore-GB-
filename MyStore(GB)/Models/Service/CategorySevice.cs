using Models;
using Models.Entities;
using MyStore_GB_.Models.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore_GB_.Models.Service
{
    public class CategorySevice:ICategorysService
    {
        private DataBaseContext _dataBaseContext;
        public CategorySevice(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return _dataBaseContext.Categories.ToList();
        }
    }
}
