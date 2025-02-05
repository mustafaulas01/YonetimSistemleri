﻿using Core.Entities;
using System.Linq.Expressions;

namespace Core
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        T Get(Expression<Func<T, bool>> filter);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }

}
