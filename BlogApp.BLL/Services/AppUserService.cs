using BlogApp.BLL.interfaces;
using BlogApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BLL.Services
{
    internal class AppUserService : IBlogAppService<AppUser>
    {
        public Task<AppUser> Add(AppUser _object)
        {
            throw new NotImplementedException();
        }

        public void Delete(AppUser _object)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AppUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public AppUser GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(AppUser _object)
        {
            throw new NotImplementedException();
        }
    }
}
