using AutoMapper;
using BlogApp.BLL.interfaces;
using BlogApp.DAL.Data;
using BlogApp.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BLL.Services
{
    public class RepositoryManager : IRepositoryManager
    {

        private ApplicationDbContext _context;

        
        private IUserAuthenticationRepository _userAuthenticationRepository;
        private UserManager<AppUser> _userManager;
        private IMapper _mapper;
        private IConfiguration _configuration;

        public RepositoryManager(ApplicationDbContext context, UserManager<AppUser> userManager, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
            _configuration = configuration;
        }


        public IUserAuthenticationRepository UserAuthentication
        {
            get
            {
                if (_userAuthenticationRepository is null)
                    _userAuthenticationRepository = new UserAuthenticationRepository(_userManager, _configuration, _mapper);
                return _userAuthenticationRepository;
            }
        }
           

    public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
