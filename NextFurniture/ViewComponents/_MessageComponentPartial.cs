using Microsoft.AspNetCore.Mvc;

namespace NextFurniture.ViewComponents
{
    public class _MessageComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
