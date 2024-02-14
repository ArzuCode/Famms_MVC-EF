using Famms_MVC.Models;
using Famms_MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Famms_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly FammsDbContext _context;

        public ProductController(FammsDbContext context)
        {
            _context = context;
        }

        [ResponseCache(Duration =5)]
        public IActionResult Index()
        {
            var products = _context.ProductsTbls.ToList();
            var model = new ProductIndexVM
            {
                ProductsTbls = products
            };
            return View(model);

        }

    }
}
