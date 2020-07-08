using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    class BlogRepository : Repository<News>
    {
        public BlogRepository(MyDbContext dbProvider) : base(dbProvider)
        {
        }

        protected override DbSet<News> GetDbSet()
        {
            return _context.News;
        }

        protected override void MapEntity(News item, News entity, int pUid = 0)
        {
            item.CategoryId = entity.CategoryId;
            item.Content = entity.Content;
            item.CreateBy = entity.CreateBy;
            item.CreateDate = entity.CreateDate;
            item.Image = entity.Image;
            item.Meta = entity.Meta;
            item.Sort = entity.Sort;
            item.Title = entity.Title;
            item.UpdateBy = entity.UpdateBy;
            item.UpdateDate = entity.UpdateDate;
            item.Views = entity.Views;
            item.Visible = entity.Visible;
        }
    }
}
