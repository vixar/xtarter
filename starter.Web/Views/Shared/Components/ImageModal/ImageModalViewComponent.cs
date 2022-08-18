using Microsoft.AspNetCore.Mvc;

namespace starter.Web.Views.Shared.Components.ImageModal
{
    public class ImageModalViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}