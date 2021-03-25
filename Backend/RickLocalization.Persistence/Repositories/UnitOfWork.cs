using RickLocalization.Domain.Interfaces;

namespace RickLocalization.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RickLocalizationContext _context;

        public UnitOfWork(RickLocalizationContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}