using Models;
using Models.Entities;
using MyStore_GB_.Models.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore_GB_.Models.Service
{
    public class ProductService : IProductsSevice
    {
        private readonly DataBaseContext _dataBaseContext;
        public ProductService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public IEnumerable<Product> GetAllCategory()
        {
            return _dataBaseContext.Products.ToList();
        }
    }
}
