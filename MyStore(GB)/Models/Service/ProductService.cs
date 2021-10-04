using Microsoft.EntityFrameworkCore;
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
        public IEnumerable<Product> GetAllProducts()
        {
            return _dataBaseContext.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            return _dataBaseContext.Products.Include(t=>t.Brand).Include(t=>t.Category).FirstOrDefault(t=>t.Id == id);
        }
    }
}
