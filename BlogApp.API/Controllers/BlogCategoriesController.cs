using BlogApp.DAL.Repositories.IRepository;
using BlogApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public BlogCategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IEnumerable<BlogCategory> GetBlogCategories()
        {
            return _unitOfWork.Category.GetAll();
        }

        [HttpGet]
        [Route("/[controller]/[action]/{id?}")]
        public HttpResponseMessage GetBlogCategoryById(int? id)
        {
            HttpResponseMessage response;
            if (id == null)
            {
                response = new HttpResponseMessage(HttpStatusCode.NotFound);
                return response;
            }
            BlogCategory obj = _unitOfWork.Category.GetFirstOrDefault(x => x.BlogCategoryId == id);
            if (obj == null)
            {
                response = new HttpResponseMessage(HttpStatusCode.NotFound);
                return response;
            }
            response = new HttpResponseMessage(HttpStatusCode.NotFound);
            return response;
        }
        [HttpPost]
        public HttpResponseMessage Create(BlogCategory obj)
        {
            HttpResponseMessage response;
            if (obj == null)
            {

                response = new HttpResponseMessage(HttpStatusCode.NoContent);
                return response;
            }
            _unitOfWork.Category.Add(obj);
            _unitOfWork.Save();
            response = new HttpResponseMessage(HttpStatusCode.Created);
            return response;
        }
    }
}
