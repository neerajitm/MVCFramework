using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSolution.Data
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected DbContext _context = null;
        protected IDbSet<TEntity> entity;
        private bool _disposed = false;

        public GenericRepository(DbContext context)
        {
            _context = context;
            entity = _context.Set<TEntity>();
        }

        public DbContext Dbcontext
        {
            get
            {
                return _context;
            }
        }

        public TEntity Create(TEntity entity)
        {
            return this.entity.Add(entity);
        }

        public TEntity Delete(TEntity entity)
        {
            return this.entity.Remove(entity);
        }

        public TEntity Update(TEntity entity)
        {
            return this.entity.Attach(entity);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return entity.AsEnumerable<TEntity>();
        }

      

        public int Commit()
        {
            return _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public TEntity GetEntity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
