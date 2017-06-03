using BNR.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNR.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

      //  private static readonly ILog log = LogManager.GetLogger(typeof(Repository<TEntity>));

        public Repository(DbContext context)
        {
            Context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return Context.Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                throw;
            }
        }

        public TEntity Get(object id)
        {
            try
            {
                return Context.Set<TEntity>().Find(id);
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                throw;
            }
        }

        public void Insert(TEntity entity)
        {
            try
            {
                Context.Set<TEntity>().Add(entity);
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                throw;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                Context.Set<TEntity>().Attach(entity);
                Context.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                throw;
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                Context.Set<TEntity>().Remove(entity);
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                throw;
            }
        }
    }
}
