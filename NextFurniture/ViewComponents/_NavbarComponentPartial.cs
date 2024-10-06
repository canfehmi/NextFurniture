using Microsoft.AspNetCore.Mvc;

namespace NextFurniture.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()

        {
            return View();
        }
    }
}
