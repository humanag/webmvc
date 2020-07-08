using AutoMapper;
using BAL.Domain;
using DAL;
using DAL.Entity;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services.Implement
{
    public class CategoryService : BaseService<CategoryDto, Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        //public IEnumerable<CategoryDto> GetAll()
        //{
        //    IEnumerable<CategoryDto> categories = new CategoryDto[]
        //    {
        //        new CategoryDto() { Id = 1, Name = "Cửa lưới chống muỗi" },
        //        new CategoryDto() { Id = 2, Name = "Cửa nhựa lõi thép" },
        //        new CategoryDto() { Id = 3, Name = "Cửa nhôm Xingfa nhập Quảng Đông" },
        //        new CategoryDto() { Id = 4, Name = "Cầu thang kính" },
        //        new CategoryDto() { Id = 5, Name = "Cửa nhôm PMA" },
        //        new CategoryDto() { Id = 6, Name = "Vách kính" },
        //        new CategoryDto() { Id = 7, Name = "Vách kính tắm" },
        //        new CategoryDto() { Id = 8, Name = "Lan can kính" }
        //    };
        //    return categories;
        //}

        public IEnumerable<CategoryWithProductContDto> GetAllWithProductCount()
        {
            var entities = GetRepository().GetAll(1, 20000);
            return _mapper.Map<IEnumerable<CategoryWithProductContDto>>(source: entities);
        }

        private CategoryRepository GetRepository()
        {
            return (CategoryRepository)_unitOfWork.GetRepository<Category>();
        } 
    }
}
