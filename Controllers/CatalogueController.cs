using Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_1.Controllers
{
    public class CatalogueController : Controller
    {
        private IStoreRepository repository;
        public CatalogueController(IStoreRepository repo)
        {
            repository = repo;
        }

        [Route("Catalogue")]
        [Route("Catalogue/{category}")]
        public IActionResult Index(string category = null)
        {
            ViewBag.pageName = "Catalogue";
            return View(repository.Products
                .Where(product => category == null || product.Category == category));
        }

        [Route("Product/{productId}")]
        public IActionResult ProductDetails(int productId)
        {

            return View(repository.Products
                .FirstOrDefault(p => p.ProductID == productId));
        }
    }
}
