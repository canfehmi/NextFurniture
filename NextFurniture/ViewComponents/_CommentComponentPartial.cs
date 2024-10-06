using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Context;

namespace NextFurniture.ViewComponents
{
    public class _CommentComponentPartial : ViewComponent
    {
        NextFurnitureContext context = new NextFurnitureContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Comments.ToList();
            return View(values);
        }
    }
}
