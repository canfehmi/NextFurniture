using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Context;

namespace NextFurniture.ViewComponents
{
    public class _WhyUsComponentPartial : ViewComponent
    {
        NextFurnitureContext db = new NextFurnitureContext();
        public IViewComponentResult Invoke()
        {
            var values = db.WhyUss.ToList();
            return View(values);
        }
    }
}
