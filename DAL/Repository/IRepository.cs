using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(int page = 1, int pageSize = 20, long pUid = 0);
        IEnumerable<T> GetAll(Func<T, bool> predicate, int pUid = 0);
        T Get(object id, int pUid = 0);
        T Insert(T entity, int pUid = 0);
        bool Delete(T entity, int pUid = 0);
        bool Delete(object id, int pUid = 0);
        bool Update(object id, T entity, int pUid = 0);
    }
}
