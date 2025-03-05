using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailSendACommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
