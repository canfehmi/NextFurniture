using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Entities;
using NextFurniture.Repositories;

namespace NextFurniture.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        GenericRepository<Contact> repo = new GenericRepository<Contact>();
        public IViewComponentResult Invoke()
        { 
            ViewBag.Title = repo.Find(x => x.Id == 1).Title;
            ViewBag.Description = repo.Find(x => x.Id == 1).Description;
            return View(); 
        }
    }
}
