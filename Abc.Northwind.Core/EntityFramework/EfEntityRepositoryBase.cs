using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Abc.Core.DataAccess;
using Abc.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Abc.Core.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, IEntity, new()
    {
        public void Add(TEntity entity)
        {
            using (var addEntity = new TContext())
            {

            }
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
           
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
