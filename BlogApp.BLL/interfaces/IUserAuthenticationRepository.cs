using BlogApp.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BLL.interfaces
{
    public interface IUserAuthenticationRepository
    {
        Task<IdentityResult> RegisterUserAsync(UserRegisterModel userForRegistration);
        Task<bool> ValidateUserAsync(UserRegisterModel loginDto);
        Task<string> CreateTokenAsync();
    }
}
