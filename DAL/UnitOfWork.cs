using DAL.Entity;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {

        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        
        MyDbContext Context { get; }
        bool Save();
        Task<bool> SaveAsync();
    }

    //public interface IUnitOfWork<TContext> : IUnitOfWork where TContext : IDbConnectionProvider
    //{
    //}

    public class UnitOfWork : IUnitOfWork
    {
        public MyDbContext Context { get; }
        protected IDbTransaction Transaction { 
            get { return (IDbTransaction)Context.Database.CurrentTransaction; } 
            set => transaction = value; 
        }

        private IDbTransaction transaction;
        private Dictionary<Type, object> _repositories;
        private bool _disposed;

        public UnitOfWork(MyDbContext context)
        {
            Context = context;
            // _transaction = (IDbTransaction)context.Database.CurrentTransaction;
            _disposed = false;
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories == null) _repositories = new Dictionary<Type, object>();
            var type = typeof(TEntity);
            if (!_repositories.ContainsKey(type))
                switch (type.ToString())
                {
                    case "DAL.Entity.SysUser":
                        _repositories[type] = new UserRepository(Context);
                        break;
                    case "DAL.Entity.Category":
                        _repositories[type] = new CategoryRepository(Context);
                        break;
                    case "DAL.Entity.Product":
                        _repositories[type] = new ProductRepository(Context);
                        break;
                    case "DAL.Entity.Blog":
                        _repositories[type] = new BlogRepository(Context);
                        break;
                    case "DAL.Entity.BlogCategory":
                        _repositories[type] = new BlogCategoryRepository(Context);
                        break;
                    default:
                        _repositories[type] = new SysParamRepository(Context);
                        break;
                }

            if (!_repositories.ContainsKey(type))
            {
                var repositorType = typeof(Repository<>);
                var obj = Activator.CreateInstance(repositorType.MakeGenericType(typeof(TEntity)), Context, this);
                if (obj != null)
                    _repositories.Add(type, obj);
            }

            return (IRepository<TEntity>)_repositories[type];
        }

        public bool Save()
        {
            Context.SaveChanges();
            if (Transaction != null)
                Transaction.Commit();
            return true;
        }
        public async Task<bool> SaveAsync()
        {
            await Task.Run(() =>
            {
                if (Transaction != null)
                    Transaction.Commit();
            });
            return true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool isDisposing)
        {
            if (!_disposed)
            {
                if (isDisposing)
                {
                    if (Context.Database.Connection != null) Context.Database.Connection.Dispose();
                    if (Transaction != null) Transaction.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
