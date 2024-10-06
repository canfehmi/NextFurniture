using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Context;
using NextFurniture.Models.DAL.Entities;
using NextFurniture.Repositories;

namespace NextFurniture.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        NextFurnitureContext context = new NextFurnitureContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Abouts.ToList();
            return View(value);
        }
    }
}
