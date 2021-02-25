using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContex> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContex : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //if (entity.DailyPrice > 0)
            //{
            using (TContex context = new TContex())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            //}
            //else
            //{
            //    Console.WriteLine("Günlük ücreti hatalı girdiniz");
            //}

        }

        public void Update(TEntity entity)
        {
            //if (entity.DailyPrice > 0)
            //{
            using (TContex context = new TContex())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
            //}
            //else
            //{
            //    Console.WriteLine("Günlük ücreti hatalı girdiniz");
            //}
        }

        public void Delete(TEntity entity)
        {
            using (TContex context = new TContex())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContex context = new TContex())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContex context = new TContex())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
    }
}
