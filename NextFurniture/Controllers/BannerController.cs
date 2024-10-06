using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Entities;
using NextFurniture.Repositories;

namespace NextFurniture.Controllers
{
	[Authorize(Roles = "Admin")]
	public class BannerController : Controller
    {
        GenericRepository<Banner> repo = new GenericRepository<Banner>();
        [HttpGet]
        public IActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Banner b)
        {
            var t = repo.Find(x => x.Id == 1);
            t.Title = b.Title;
            t.Description = b.Description;
            t.ImgUrl = b.ImgUrl;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
