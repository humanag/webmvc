using BAL.Domain;
using DAL.Entity;
using System.Collections.Generic;

namespace BAL.Services
{
    public interface IProductService : IBaseService<ProductDto, Product>
    {
        IEnumerable<ProductDto> GetNew();
    }
}
