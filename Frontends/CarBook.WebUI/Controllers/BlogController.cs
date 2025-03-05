using CarBook.Dto.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers;

public class BlogController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public BlogController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.v1 = "Bloglarımız";
        ViewBag.v2 = "Bloglar";

        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7221/api/Blogs/GetAllBlogsWithAuthor");

        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAllBlogWithAuthorDto>>(jsonData);

            return View(values);
        }

        return View();
    }

    public async Task<IActionResult> Detail(int id)
    {
        ViewBag.v1 = "Bloglarımız";
        ViewBag.v2 = "Blog Detayı ve Yorumlar";
        ViewBag.blogId = id;
        return View();
    }
}
