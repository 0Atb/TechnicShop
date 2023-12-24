using Infrastructure.Data.Abstract;
using Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Concrete.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : AudiTableEntity, IBaseDomain, new()
        where TContext : DbContext,new()
    {
        public TEntity Delete(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Set<TEntity>().Remove(entity); //Set<TEntity>() entity'nin listesini döner
                ctx.SaveChanges();
                return entity;
            }
        }

        public TEntity DeleteById(int id)
        {
            using (TContext ctx = new TContext())
            {
                TEntity entity = ctx.Set<TEntity>().FirstOrDefault(x => x.Id == id);
                ctx.Set<TEntity>().Remove(entity);
                ctx.SaveChanges();
                return entity;
            }
        }
        
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null, params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> query = ctx.Set<TEntity>();
                if (includelist.Length>0)
                {
                    foreach (string item in includelist)
                    {
                        query = query.Include(item);
                    }
                }
                return filter == null ? query.FirstOrDefault() : query.SingleOrDefault();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> query = ctx.Set<TEntity>();
                if (includelist.Length > 0)
                {
                    foreach (string item in includelist)
                    {
                        query = query.Include(item);
                    }
                }
                return filter == null ? query.ToList() : query.Where(filter).ToList();
            }
        }

        public TEntity GetById(int id, params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> query = ctx.Set<TEntity>();
                if (includelist.Length > 0)
                {
                    foreach (string item in includelist)
                    {
                        query = query.Include(item);
                    }
                }
                return query.SingleOrDefault(x => x.Id == id);
            }
        }

        public TEntity Insert(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Set<TEntity>().Add(entity); 
                ctx.SaveChanges();
                return entity;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                TEntity ent = ctx.Set<TEntity>().Attach(entity).Entity;
                ctx.Entry(entity).State = EntityState.Modified;
                ctx.SaveChanges();
                return entity;
            }
        }
    }
}
