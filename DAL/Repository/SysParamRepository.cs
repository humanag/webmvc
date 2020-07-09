using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SysParamRepository : Repository<SysParam>
    {
        public SysParamRepository(MyDbContext dbProvider) : base(dbProvider)
        {
        }

        protected override DbSet<SysParam> GetDbSet()
        {
            return _context.SysParams;
        }

        public override bool Update(object id, SysParam entity, int pUid = 0)
        {
            if (id != null)
                return base.Update(id, entity, pUid);

            var item = this.DbSet.FirstOrDefault(x => x.Code == entity.Name && x.Type == entity.Type);
            if (item != null)
                MapEntity(item, entity);
            else
                this.DbSet.Add(entity);
            
            return true;
        }

        protected override void MapEntity(SysParam item, SysParam entity, int pUid = 0)
        {
            item.Name = entity.Name;
            item.Value = entity.Value;
            item.Type = entity.Type;
        }
    }
}
