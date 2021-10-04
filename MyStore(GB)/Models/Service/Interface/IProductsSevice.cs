using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore_GB_.Models.Service.Interface
{
    public interface IProductsSevice
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
    }
}
