using BlogApp.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BlogApp.Web.UI.Controllers
{

    //https://localhost:7005/api/UserLogin/login
    public class LoginUserController : Controller
    {
        Uri baseUri = new Uri("https://localhost:7005/api");
        HttpClient client;

        public LoginUserController()
        {
            client = new HttpClient();
            client.BaseAddress = baseUri;
        }
        public IActionResult Login()
        {

            //Session["UserID"] = obj.UserId.ToString();
            //Session["UserName"] = obj.UserName.ToString();
            //return RedirectToAction("UserDashBoard");
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginModel userLoginModel)
        {
            string Data = JsonConvert.SerializeObject(userLoginModel);
            StringContent content = new StringContent(Data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(baseUri + "/UserLogin", content).Result;
            if (response.IsSuccessStatusCode)
            {
                List<string> roleList = new List<string>();
                roleList = GetAllRole(userLoginModel.UserName);
                //string r = "ddd";
                //bool isExist = roleList.Find(r);
                
                //var role1=roleList.Where(x => x.Equals("Super Admin"));
                bool role1=roleList.Contains("Super Admin");
                bool role2=roleList.Contains("Admin");
               // bool role2=roleList.Where(x => x.Equals("Admin")).First();
               // var role3=roleList.Find("Super Admin")

               

                if (role1 != null)
                {
                    return Redirect("http://localhost:5160/Home/Index");
                }
                else if (role2!= null)
                {
                    return Redirect("http://localhost:5160/Home/Index");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

                // return RedirectToLocal(returnUrl);

                //http://localhost:5160/

                // return RedirectToAction("TestPage", "Home");
            }
            return View();
        }

        private List<string> GetAllRole(string username)
        {

            List<string> roles = new List<string>();
            HttpResponseMessage response = client.GetAsync(baseUri + "/UserLogin/"+username).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                roles = JsonConvert.DeserializeObject<List<string>>(data);
            }

            return roles;
        }

    }
}
