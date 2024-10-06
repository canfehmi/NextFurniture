using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Entities;
using NextFurniture.Repositories;

namespace NextFurniture.Controllers
{
	[Authorize(Roles = "Admin")]
	public class ContactController : Controller
    {
        GenericRepository<Contact> repo = new GenericRepository<Contact>();
        [HttpGet]
        public IActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(Contact c)
        {
            var contact = repo.Find(x => x.Id == 1);
            contact.Title = c.Title;
            contact.Description = c.Description;
            repo.TUpdate(contact);
            return RedirectToAction("Index");
        }
    }
}
