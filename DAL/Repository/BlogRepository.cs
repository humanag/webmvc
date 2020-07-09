using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    class BlogRepository : Repository<Blog>
    {
        public BlogRepository(MyDbContext dbProvider) : base(dbProvider)
        {
        }

        protected override DbSet<Blog> GetDbSet()
        {
            return _context.Blogs;
        }

        protected override void MapEntity(Blog item, Blog entity, int pUid = 0)
        {
            item.CategoryId = entity.CategoryId;
            item.Content = entity.Content;
            item.CreateBy = entity.CreateBy;
            item.CreateDate = entity.CreateDate;
            item.Image = entity.Image;
            item.MetaTitle = entity.MetaTitle;
            item.Sort = entity.Sort;
            item.Title = entity.Title;
            item.UpdateBy = entity.UpdateBy;
            item.UpdateDate = entity.UpdateDate;
            item.Views = entity.Views;
            item.Visible = entity.Visible;
        }
    }
}
