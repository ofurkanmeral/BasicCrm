using CrmData.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrmData.Concrete
{
    public class GenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext:DbContext,new()
    {
        public void Create(TEntity entity)
        {
            using(var context=new DataContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new DataContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> getAll()
        {
            using(var context=new DataContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity getById(int id)
        {
            using (var context = new DataContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public virtual void Update(TEntity entity)
        {
            using (var context = new DataContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
