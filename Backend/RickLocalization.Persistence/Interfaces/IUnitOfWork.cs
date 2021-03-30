using System;

namespace RickLocalization.Persistence.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
         bool Commit();
    }
}