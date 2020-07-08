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

        protected override void MapEntity(SysParam item, SysParam entity, int pUid = 0)
        {
            item.Name = entity.Name;
            item.Value = entity.Value;
            item.Type = entity.Type;
        }
    }
}
