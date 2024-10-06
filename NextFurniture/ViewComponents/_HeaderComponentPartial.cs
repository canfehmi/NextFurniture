using Microsoft.AspNetCore.Mvc;

namespace NextFurniture.ViewComponents
{
    public class _HeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
