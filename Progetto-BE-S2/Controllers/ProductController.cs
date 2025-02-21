using Microsoft.AspNetCore.Mvc;
using Progetto_BE_S2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Progetto_BE_S2.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>()
        {
            new Product
 {
     Id = Guid.NewGuid(),
     Name = "Scketchers air 23",
     Price = 50,
     Description = "Una scarpa sportiva comoda e leggera.",
      CoverImage = "https://m.media-amazon.com/images/I/81jmWhRym7L._AC_SX695_.jpg",
     AdditionalImage1 = "https://m.media-amazon.com/images/I/71ozsbBA1vL._AC_SY695_.jpg",
     AdditionalImage2 = "https://m.media-amazon.com/images/I/71GxWIuM6EL._AC_SX695_.jpg"
 },
  new Product
 {
     Id = Guid.NewGuid(),
     Name = "Scketchers air 23",
     Price = 50,
     Description = "Una scarpa sportiva comoda e leggera.",
      CoverImage = "https://m.media-amazon.com/images/I/81jmWhRym7L._AC_SX695_.jpg",
     AdditionalImage1 = "https://m.media-amazon.com/images/I/71ozsbBA1vL._AC_SY695_.jpg",
     AdditionalImage2 = "https://m.media-amazon.com/images/I/71GxWIuM6EL._AC_SX695_.jpg"
 },
   new Product
 {
     Id = Guid.NewGuid(),
     Name = "Scketchers air 23",
     Price = 50,
     Description = "Una scarpa sportiva comoda e leggera.",
      CoverImage = "https://m.media-amazon.com/images/I/81jmWhRym7L._AC_SX695_.jpg",
     AdditionalImage1 = "https://m.media-amazon.com/images/I/71ozsbBA1vL._AC_SY695_.jpg",
     AdditionalImage2 = "https://m.media-amazon.com/images/I/71GxWIuM6EL._AC_SX695_.jpg"
 },
 new Product
 {
     Id = Guid.NewGuid(),
     Name = "Scketchers air 23",
     Price = 60,
     Description = "Scarpa ad alte prestazioni per sport intensivi.",
     CoverImage = "https://m.media-amazon.com/images/I/81jmWhRym7L._AC_SX695_.jpg",
     AdditionalImage1 = "https://m.media-amazon.com/images/I/71ozsbBA1vL._AC_SY695_.jpg",
     AdditionalImage2 = "https://m.media-amazon.com/images/I/71GxWIuM6EL._AC_SX695_.jpg"
 }

        };

        
        public IActionResult Index()
        {
            var productsList = new ProductsViewModel
            {
                Products = products
            };
            return View(productsList);
        }

       
        public IActionResult Details(Guid id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }

       
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = Guid.NewGuid(); 
                products.Add(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

       
        public IActionResult Delete(Guid id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
            return RedirectToAction("Index");
        }
    }
}
