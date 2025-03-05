using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsCommentsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() => View(); 
    }
}
