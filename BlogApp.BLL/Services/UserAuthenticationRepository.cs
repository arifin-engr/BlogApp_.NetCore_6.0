using AutoMapper;
using BlogApp.BLL.interfaces;
using BlogApp.Model;
using BlogApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BLL.Services
{
    internal class UserAuthenticationRepository : IUserAuthenticationRepository
    {


        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private AppUser? _user;

        public UserAuthenticationRepository(UserManager<AppUser> userManager, IConfiguration configuration, IMapper mapper)
        {
            _userManager = userManager;
            _configuration = configuration;
            _mapper = mapper;
        }


        public Task<string> CreateTokenAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> RegisterUserAsync(UserRegisterModel userForRegistration)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ValidateUserAsync(UserRegisterModel loginDto)
        {
           var res = await _userManager.FindByNameAsync(loginDto.UserName);
            if (res == null)
            return false;
            return true;
        }
    }
}
