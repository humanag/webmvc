using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(MyDbContext dbProvider) : base(dbProvider)
        {
        }

        protected override DbSet<Product> GetDbSet()
        {
            return _context.Products;
        }

        protected override void MapEntity(Product item, Product entity, int pUid = 0)
        {
            item.CategoryId = entity.CategoryId;
            item.Code = entity.Code;
            item.Description = entity.Description;
            item.Detail = entity.Detail;
            item.Image = entity.Image;
            item.IsNew = entity.IsNew;
            item.MetaTitle = entity.MetaTitle;
            item.Name = entity.Name;
            item.Sort = entity.Sort;
            item.UpdateDate = item.UpdateDate;
            item.UpdateBy = entity.UpdateBy;
            item.Views = entity.Views;
            item.Visible = entity.Visible;
        }
    }
}
