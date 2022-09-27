using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories.IRepository
{
    public interface IUnitOfWork
    {
        public IBlogCategoryRepository Category { get;}
        void Save();
    }
}
