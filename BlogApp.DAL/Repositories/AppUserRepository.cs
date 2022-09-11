using BlogApp.DAL.Contacts;
using BlogApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories
{
    public class AppUserRepository : IRepository<AppUser>
    {
        public Task<AppUser> Create(AppUser _object)
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
