using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public interface IBaseService<Tv, Te>
    {
        Task<Tv> Insert(Tv dto, int uid = 0);

        Task<bool> Update(Tv dto, int uid = 0);

        Task<bool> Delete(object id, int uid = 0);

        IEnumerable<Tv> GetAll(int page = 1, int pageSize = 20, int uid = 0);

        IEnumerable<Tv> GetAll(string keyword, int uid = 0);

        IEnumerable<Tv> GetAll(Func<Te, bool> predicate, int uid = 0);

        Tv Get(object id, int uid = 0);
        Tv Get(Func<Te, bool> predicate, int uid = 0);
    }
}
