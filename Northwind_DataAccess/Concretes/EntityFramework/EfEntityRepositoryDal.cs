using Microsoft.EntityFrameworkCore;
using Northwind_DataAccess.Abstracts;
using Northwind_Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Northwind_DataAccess.Concretes.EntityFramework
{
    public class EfEntityRepositoryDal<TEntity, TContext> : IEntityRepositoryDal<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var addedEntity = db.Entry(entity);
                addedEntity.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var deletedEntity = db.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext db = new TContext())
            {
                return db.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext db = new TContext())
            {
                if (filter == null)
                {
                    return db.Set<TEntity>().ToList();
                }
                else
                {
                    return db.Set<TEntity>().Where(filter).ToList();
                }
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var updatedEntity = db.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
