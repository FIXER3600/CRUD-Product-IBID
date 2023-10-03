using Microsoft.AspNetCore.Mvc;
using ProductProject.Models;
using ProductProject.Repository;

namespace ProductProject.Controllers
{
    public class ProductController:Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository; 
        }
        public IActionResult Index()
        {
       
            return View();
        }
        public IActionResult Create()
        {
            // Ação para exibir o formulário de criação de produto
            return View();
        }
        public IActionResult DeleteConfirmation(int id)
        {
            Product prod = _productRepository.GetById(id);
            return View(prod);
        }
        public IActionResult Delete(int id)
        {
            _productRepository.Delete(id);
            return RedirectToAction(actionName: "Index", controllerName: "Home");
        }
        public IActionResult Edit(int id)
        {
         Product prod=   _productRepository.GetById(id);
            return View(prod);

        }
        [HttpPost]
        public IActionResult Create(Product produto)
        {
            if(ModelState.IsValid) {
                _productRepository.Create(produto);
                return RedirectToAction(actionName: "Index", controllerName: "Home");
            }
            return View(produto);
        }
        [HttpPost]
        public IActionResult Alterate(Product produto)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Edit(produto);
                return RedirectToAction(actionName: "Index", controllerName: "Home");
            }
            return View( "Edit", produto);
            
        }
    }
}
