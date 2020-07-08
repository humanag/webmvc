using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly IDbConnection _connection;
        protected MyDbContext _context;

        public Repository(MyDbContext dbProvider)
        {
            _connection = dbProvider.Database.Connection;
            if (_connection.State == ConnectionState.Closed) _connection.Open();
            
            _context = dbProvider;
        }

        public IDbConnection Connection { get => _connection; }

        protected DbSet<TEntity> DbSet { get { return GetDbSet(); } }
        protected abstract DbSet<TEntity> GetDbSet();

        public virtual bool Delete(TEntity entity, int pUid = 0)
        {
            try
            {
                this.DbSet.Remove(entity);
                return true;
            } catch
            {
                return false;
            }
        }

        public virtual bool Delete(object id, int pUid = 0)
        {
            var item = this.DbSet.Find(id);
            if (item == null)
                return false;

            return this.Delete(item);
        }

        public virtual TEntity Get(object id, int pUid = 0) 
        {
            return this.DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll(int page = 1, int pageSize = 20, long pUid = 0)
        {
            return this.DbSet;
        }

        public virtual IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate, int pUid = 0)
        {
            return this.DbSet.Where(predicate).AsEnumerable<TEntity>();
        }

        public virtual TEntity Insert(TEntity entity, int pUid = 0)
        {
            return this.DbSet.Add(entity);
        }

        public virtual bool Update(object id, TEntity entity, int pUid = 0)
        {
            var item = this.DbSet.Find(id);
            if (item == null) return false;
            MapEntity(item, entity);
            return true;
        }

        protected abstract void MapEntity(TEntity item, TEntity entity, int pUid = 0);
    }
}
