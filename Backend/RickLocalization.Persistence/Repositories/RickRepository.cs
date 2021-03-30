using RickLocalization.Domain.Models;

namespace RickLocalization.Persistence.Repositories
{
    public class RickRepository : RickLocalizationRepositoryBase<Rick>
    {
        public RickRepository(RickLocalizationContext context) : base(context)
        {
            
        }
    }
}