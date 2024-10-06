using Microsoft.AspNetCore.Mvc;

namespace NextFurniture.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
