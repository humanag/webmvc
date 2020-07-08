using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(MyDbContext dbProvider) : base(dbProvider)
        {
        }

        protected override DbSet<Category> GetDbSet()
        {
            return _context.Categories;
        }

        protected override void MapEntity(Category item, Category entity, int pUid = 0)
        {
            item.MetaTitle = entity.MetaTitle;
            item.Name = entity.Name;
            item.ParentId = entity.ParentId;
            item.Sort = entity.Sort;
            item.UpdateBy = pUid;
            item.UpdateDate = DateTime.Now;
            item.Visible = entity.Visible;
        }
    }
}
