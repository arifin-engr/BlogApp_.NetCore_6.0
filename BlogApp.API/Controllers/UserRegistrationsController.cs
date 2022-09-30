
using BlogApp.DAL.Data;
using BlogApp.Model;
using BlogApp.Model.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationsController 
    {
        UserManager<AppUser> _userManager;
        ApplicationDbContext _db;
        public UserRegistrationsController(UserManager<AppUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;   
        }



        //Register
        [HttpPost]
        [Route("register")]
        public async Task< HttpResponseMessage> RegisterUser([FromBody] UserRegistrationVM userRegistration)
        {
            string name = userRegistration.UserName; ;
            var ExistUserName= await _userManager.FindByNameAsync(name);
            if (ExistUserName==null)
            {
                AppUser appUser = new AppUser();
                appUser.UserName = userRegistration.UserName;
                appUser.Email = userRegistration.Email;
                appUser.EmailConfirmed = false;
                string _password = userRegistration.Password;
                IdentityResult result = _userManager.CreateAsync(appUser, _password).Result;
                if (result.Succeeded)
                {
                 
                }
                

            }
            //var userResult = await _repository.UserAuthentication.RegisterUserAsync(userRegistration);
            HttpResponseMessage respponse = new HttpResponseMessage(HttpStatusCode.OK);
            return respponse;



        }


    }
}
