using AutoMapper;
using BAL.Domain;
using DAL;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services.Implement
{
    public class ProductService : BaseService<ProductDto, Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public IEnumerable<ProductDto> GetNew()
        {
            var res = GetAll(x => x.IsNew == true);
            
            return res;
        }
    }
}
