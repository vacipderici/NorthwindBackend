﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntiy, TContext> : IEntityRepository<TEntiy>
          where TEntiy : class, IEntity, new()
          where TContext : DbContext, new()
    {

        public void Add(TEntiy entity)
        {

            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntiy entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntiy Get(Expression<Func<TEntiy, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntiy>().SingleOrDefault(filter);
            }
        }
        public void Update(TEntiy entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }

        public IList<TEntiy> GetList(Expression<Func<TEntiy, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntiy>().ToList()
                    : context.Set<TEntiy>().Where(filter).ToList();
            }


        }
    }
}
