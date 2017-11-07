using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MvcSolution.Data
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Create(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetEntity(int id);
        int Commit();
    }
}
