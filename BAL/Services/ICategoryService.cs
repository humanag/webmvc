using BAL.Domain;
using DAL.Entity;
using System.Collections.Generic;

namespace BAL.Services
{
    public interface ICategoryService: IBaseService<CategoryDto, Category>
    {
        IEnumerable<CategoryWithProductContDto> GetAllWithProductCount();
    }
}
