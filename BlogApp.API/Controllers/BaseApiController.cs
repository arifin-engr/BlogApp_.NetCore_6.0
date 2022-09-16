using AutoMapper;
using BlogApp.BLL.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.API.Controllers
{
   
    public class BaseApiController : ControllerBase
    {
        protected readonly IRepositoryManager _repository;
        protected readonly IMapper _mapper;

        public BaseApiController(IRepositoryManager repository,  IMapper mapper)
        {
            _repository = repository;
            // _logger = logger;
            _mapper = mapper;
        }
    }
}
