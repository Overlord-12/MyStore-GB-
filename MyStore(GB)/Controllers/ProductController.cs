using Microsoft.AspNetCore.Mvc;
using MyStore_GB_.Models.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore_GB_.Controllers
{
    public class ProductController : Controller
    {
        private IProductsSevice _productsSevice;
        public ProductController(IProductsSevice productsSevice)
        {
            _productsSevice = productsSevice;
        }
        public IActionResult Index()
        {
            return View(_productsSevice.GetAllProducts());
        }
        public IActionResult Details(int id)
        {
            return View(_productsSevice.GetProduct(id));
        }
    }
}
