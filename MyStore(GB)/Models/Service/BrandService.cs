using Models;
using Models.Entities;
using MyStore_GB_.Models.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore_GB_.Models.Service
{
    public class BrandService : IBrandsSevice
    {
        private readonly DataBaseContext _dataBaseContext;
        public BrandService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public IEnumerable<Brand> GetAllBrends()
        {
            return _dataBaseContext.Brands.ToList();
        }
    }
}
