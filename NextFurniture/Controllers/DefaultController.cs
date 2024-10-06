using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Context;
using NextFurniture.Models.DAL.Entities;
using NextFurniture.Repositories;

namespace NextFurniture.Controllers
{
    public class DefaultController : Controller
    {
        NextFurnitureContext _context = new NextFurnitureContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message m)
        {
            if(ModelState.IsValid)
            {
                m.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
                _context.Messages.Add(m);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
