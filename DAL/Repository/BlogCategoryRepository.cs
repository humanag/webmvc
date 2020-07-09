using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class BlogCategoryRepository : Repository<BlogCategory>
    {
        public BlogCategoryRepository(MyDbContext dbProvider) : base(dbProvider)
        {
        }

        protected override DbSet<BlogCategory> GetDbSet()
        {
            return _context.BlogCategories;
        }

        protected override void MapEntity(BlogCategory item, BlogCategory entity, int pUid = 0)
        {
            item.Name = entity.Name;
            item.MetaTitle = entity.MetaTitle;
            item.Sort = entity.Sort;
            item.UpdateBy = entity.UpdateBy;
            item.UpdateDate = entity.UpdateDate;
        }
    }
}
