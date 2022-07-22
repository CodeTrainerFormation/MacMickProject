using Dal;
using Microsoft.AspNetCore.Mvc;

namespace MacMickeyWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly MacContext context;

        public ProductController(MacContext context)
        {
            this.context = context;
        }

        // GET : /Product/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View(context.Products.ToList());
        }
    }
}
