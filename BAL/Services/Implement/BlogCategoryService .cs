using AutoMapper;
using BAL.Domain;
using DAL;
using DAL.Entity;

namespace BAL.Services.Implement
{
    public class BlogCategoryService : BaseService<BlogCategoryDto, BlogCategory>, IBlogCategoryService
    {
        public BlogCategoryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
