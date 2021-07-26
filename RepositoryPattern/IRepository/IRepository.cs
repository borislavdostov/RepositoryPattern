using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryPattern.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> expression);
        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
