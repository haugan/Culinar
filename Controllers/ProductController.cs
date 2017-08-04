using Culinar.Models;
using Microsoft.AspNetCore.Mvc;

namespace Culinar.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repo;
        
        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        // GET product/list
        public ViewResult List() => View(repo.Products);
    }
}
