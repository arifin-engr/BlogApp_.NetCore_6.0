using BlogApp.BLL.interfaces;
using BlogApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BLL.Services
{
    internal class BlogPostService : IBlogAppService<BlogPost>

    {
        public Task<BlogPost> Add(BlogPost _object)
        {
            throw new NotImplementedException();
        }

        public void Delete(BlogPost _object)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> GetAll()
        {
            throw new NotImplementedException();
        }

        public BlogPost GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(BlogPost _object)
        {
            throw new NotImplementedException();
        }
    }
}
