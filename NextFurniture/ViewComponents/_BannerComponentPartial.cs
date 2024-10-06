using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Context;
using NextFurniture.Models.DAL.Entities;
using NextFurniture.Repositories;

namespace NextFurniture.ViewComponents
{
    public class _BannerComponentPartial : ViewComponent
    {
        NextFurnitureContext db = new NextFurnitureContext();
        GenericRepository<Banner> repo = new GenericRepository<Banner>();
        public IViewComponentResult Invoke()
        {
            var value = db.Banners.ToList();
            return View(value);
        }
    }
}
