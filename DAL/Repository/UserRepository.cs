using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UserRepository : Repository<SysUser>
    {
        public UserRepository(MyDbContext dbProvider) : base(dbProvider)
        {
        }

        protected override DbSet<SysUser> GetDbSet()
        {
            return _context.SysUsers;
        }

        protected override void MapEntity(SysUser item, SysUser entity, int pUid = 0)
        {
            throw new NotImplementedException();
        }
    }
}
