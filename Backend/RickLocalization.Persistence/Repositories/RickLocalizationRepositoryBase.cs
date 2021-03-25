using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RickLocalization.Domain.Interfaces;

namespace RickLocalization.Persistence.Repositories
{
    public class RickLocalizationRepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RickLocalizationContext Db;
        protected DbSet<T> DbSet;

        ~RickLocalizationRepositoryBase()
        {
            Dispose(false);
        }

        public RickLocalizationRepositoryBase(RickLocalizationContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();   
        }

        public void Add(T entitie)
        {
            DbSet.Add(entitie);
        }

        public void Update(T entitie)
        {
            DbSet.Update(entitie);
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public T GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<T> List()
        {
            return DbSet.ToList();
        }

        #region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool status)
        {
            if (!status) return;
        }
        #endregion
    }
}