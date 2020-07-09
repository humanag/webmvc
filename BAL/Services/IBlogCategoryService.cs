using BAL.Domain;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public interface IBlogCategoryService: IBaseService<BlogCategoryDto, BlogCategory>
    {
    }
}
