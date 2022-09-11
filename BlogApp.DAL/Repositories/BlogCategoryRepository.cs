using BlogApp.DAL.Contacts;
using BlogApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories
{
    public class BlogCategoryRepository : IRepository<BlogCategory>
    {
        public Task<BlogCategory> Create(BlogCategory _object)
        {
            throw new NotImplementedException();
        }

        public void Delete(BlogCategory _object)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public BlogCategory GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(BlogCategory _object)
        {
            throw new NotImplementedException();
        }
    }
}
