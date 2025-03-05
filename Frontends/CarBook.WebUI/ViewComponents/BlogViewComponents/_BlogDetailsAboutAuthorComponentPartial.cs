using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsAboutAuthorComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
