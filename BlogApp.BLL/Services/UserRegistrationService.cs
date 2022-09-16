using BlogApp.BLL.interfaces;
using BlogApp.DAL.Repositories;
using BlogApp.Model;
using BlogApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BLL.Services
{
    public class UserRegistrationService : IUserRegistrationService<UserRegisterModel>
    {
        UserRegistrationRepository repository; //new UserRegistrationRepository();
        public UserRegistrationService(UserRegistrationRepository repository)
        {
            this.repository = repository;

           // this.repository= new UserRegistrationRepository(new UserManager<AppUser>,RoleManager<IdentityRole>);
        }
        

        public async Task<bool> CreateUser(UserRegisterModel model)
        {
            
              bool IsRegistered = await repository.Create(model);

               return IsRegistered;
           
           
        }

        public void DeleteUser(UserRegisterModel _object)
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

        public bool GetByName(string name)
        {

            if (name != null)
            {
                var userExists = repository.GetByName(name);
                if (userExists == null)
                    return true;
            }
           
           
            return false;
        }

        public void UpdateUser(UserRegisterModel appUser)
        {
           
        }
    }
}
