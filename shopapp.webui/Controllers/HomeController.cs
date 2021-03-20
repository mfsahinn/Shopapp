using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.data.Abstract;

using shopapp.entity;

namespace shopapp.webui.Controllers
{
    // localhost:5000/home
    public class HomeController : Controller
    {
        public IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }




        public IActionResult Index()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = _productRepository.GetAll()

            };

            return View(productViewModel);
        }

        // localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}