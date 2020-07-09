using AutoMapper;
using BAL.Domain;
using DAL;
using DAL.Entity;

namespace BAL.Services.Implement
{
    public class BlogService : BaseService<BlogDto, Blog>, IBlogService
    {
        public BlogService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
