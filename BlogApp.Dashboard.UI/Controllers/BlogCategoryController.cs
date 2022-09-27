using BlogApp.Dashboard.UI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BlogApp.Dashboard.UI.Controllers
{
    public class BlogCategoryController : Controller
    {
        Uri baseUri = new Uri("https://localhost:7005/api");
        HttpClient client;
       
        public BlogCategoryController()
        {

            client = new HttpClient();
            client.BaseAddress = baseUri;
        }
        public IActionResult Index()
        {
            List<BlogCategoryVM> viewModels = new List<BlogCategoryVM>();
            HttpResponseMessage response = client.GetAsync(baseUri + "/BlogCategories").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                viewModels = JsonConvert.DeserializeObject<List<BlogCategoryVM>>(data);
            }

            return View(viewModels);
         
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogCategoryVM viewModel)
        {
            string Data = JsonConvert.SerializeObject(viewModel);
            StringContent content = new StringContent(Data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(baseUri + "/BlogCategories", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
