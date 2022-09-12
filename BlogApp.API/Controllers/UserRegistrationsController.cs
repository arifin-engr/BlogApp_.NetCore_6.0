using BlogApp.BLL.Services;
using BlogApp.Model;
using BlogApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationsController : ControllerBase
    {
       
        UserRegistrationService _userService = new UserRegistrationService();

      

        //Register
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterModel appUser)
        {


            if (appUser!=null)
            {
                bool UserNameIsExist= _userService.GetByName(appUser.UserName);
                if (UserNameIsExist==true)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });
                }
              bool result= await _userService.CreateUser(appUser);
                if (result == false)
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            }

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });

        }


    }
}
