using System;
using System.Collections.Generic;

namespace RickLocalization.Persistence.Interfaces
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        void Add(T entitie);

        void Update(T entitie);

        void Delete(Guid id);

        IEnumerable<T> List();

        T GetById(Guid id);
    }
}