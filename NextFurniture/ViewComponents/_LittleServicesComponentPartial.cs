using Microsoft.AspNetCore.Mvc;

namespace NextFurniture.ViewComponents
{
    public class _LittleServicesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()

        {
            return View();
        }
    }
}
