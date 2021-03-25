using System;

namespace RickLocalization.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
         bool Commit();
    }
}