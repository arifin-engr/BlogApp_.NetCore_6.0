
using BlogApp.DAL.Data;
using BlogApp.DAL.Repositories.IRepository;
using BlogApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories
{
    public class BlogCategoryRepository : Repository<BlogCategory>, IBlogCategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public BlogCategoryRepository(ApplicationDbContext db):base(db)
        {
            _db =db;
        }
        public void Update(BlogCategory obj)
        {
            _db.BlogCategories.Update(obj);
        }
    }
}
