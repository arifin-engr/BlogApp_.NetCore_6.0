using BlogApp.DAL.Contacts;
using BlogApp.DAL.Data;
using BlogApp.Model;
using BlogApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories
{
    public class UserRegistrationRepository : IRepository<UserRegisterModel>
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext context;
        public UserRegistrationRepository(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
        }
        
        public async Task<bool> Create(UserRegisterModel appUser)
        {
            AppUser user = new AppUser()
            {
                Email = appUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = appUser.UserName
            };
            var result = await userManager.CreateAsync(user, appUser.Password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        public void Delete(UserRegisterModel _object)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserRegisterModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserRegisterModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public  string GetByName(string name)
        {
          

           

            var userName=   userManager.FindByNameAsync(name).ToString();
           
            return userName;
        }
        //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> manager)
        //{
        //    manager.FindByNameAsync("sdhjsd");
        //    // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        //    var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
        //    // Add custom user claims here
        //    return userIdentity;
        //}

        public void Update(UserRegisterModel _object)
        {
            throw new NotImplementedException();
        }
    }
}
