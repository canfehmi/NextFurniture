using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Entities;
using NextFurniture.Repositories;

namespace NextFurniture.Controllers
{
	[Authorize(Roles = "Admin")]
	public class AboutController : Controller
    {
        GenericRepository<About> repo = new GenericRepository<About>();
        [HttpGet]
        public IActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About a)
        {
            var t = repo.Find(x => x.Id == 1);
            t.Title = a.Title;
            t.Description = a.Description;
            t.ImgUrl1 = a.ImgUrl1;
            t.ImgUrl2 = a.ImgUrl2;
            t.ImgUrl3 = a.ImgUrl3;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
