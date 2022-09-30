using BlogApp.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BlogApp.Web.UI.Areas.SimpleUser.Controllers
{
    [Area("SimpleUser")]
    public class CreateUserController : Controller
    {
        //https://localhost:7005/api/UserRegistrations/register
        Uri baseUri = new Uri("https://localhost:7005/api");
        HttpClient client;
        public CreateUserController()
        {
            client = new HttpClient();
            client.BaseAddress = baseUri;
        }
        public IActionResult UserRegistration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserRegistration(UserRegistrationVM viewModel)
        {
            string Data = JsonConvert.SerializeObject(viewModel);
            StringContent content = new StringContent(Data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(baseUri + "/UserRegistrations/register", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Login", "LoginUser");
            }
            return View();
        }



    }
}
