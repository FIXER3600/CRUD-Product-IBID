using Microsoft.AspNetCore.Mvc;
using ProductProject.Models;
using ProductProject.Repository;
using System.Diagnostics;
namespace ProductProject.Controllers
{
        public class HomeController : Controller
        {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            List<Product> produtos=_productRepository.GetAll();
            return View(produtos);
        }
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    
}
