using System;
using System.Collections.Generic;

namespace RickLocalization.Application.Interface
{
    public interface IAppService<T> : IDisposable where T : class
    {
        bool Add(T entitie);

        bool Update(T entitie);

        bool Delete(Guid id);

        IEnumerable<T> List();

        T GetById(Guid id);
    }
}