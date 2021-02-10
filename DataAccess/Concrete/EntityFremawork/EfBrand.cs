using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFremawork
{
    public class EfBrand : IBrandDal
    {
        public void Add(Brand entity)
        {
            if (entity.BrandName.Length > 2)
            {
                using (ReCapContext context = new ReCapContext())
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            else
            {
                Console.WriteLine("Araç ismini hatalı girdiniz");
            }

        }

        public void Update(Brand entity)
        {
            if (entity.BrandName.Length > 2)
            {
                using (ReCapContext context = new ReCapContext())
                {
                    var updatedEntity = context.Entry(entity);
                    updatedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            else
            {
                Console.WriteLine("Araç ismini hatalı girdiniz");
            }
        }

        public void Delete(Brand entity)
        {

            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }
    }
}
