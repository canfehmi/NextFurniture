using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Entities;
using NextFurniture.Repositories;

namespace NextFurniture.Controllers
{
	[Authorize(Roles = "Admin")]
	public class MessageController : Controller
    {
        GenericRepository<Message> repo = new GenericRepository<Message>();
        public IActionResult Index()
        {
            var values = repo.List();
            values.Reverse();
            return View(values);
        }
    }
}
