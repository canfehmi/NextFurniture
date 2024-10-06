using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Entities;
using NextFurniture.Repositories;

namespace NextFurniture.Controllers
{
	[Authorize(Roles = "Admin")]
	public class WhyUsController : Controller
    {
        GenericRepository<WhyUs> repo = new GenericRepository<WhyUs>();
        [HttpGet]
        public IActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(WhyUs value)
        {
            var t = repo.Find(x => x.Id == 1);
            t.HeadTitle = value.HeadTitle;
            t.ReasonTitle1 = value.ReasonTitle1;
            t.ReasonTitle2 = value.ReasonTitle2;
            t.ReasonTitle3 = value.ReasonTitle3;
            t.ReasonDescription1 = value.ReasonDescription1;
            t.ReasonDescription2 = value.ReasonDescription2;
            t.ReasonDescription3 = value.ReasonDescription3;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
