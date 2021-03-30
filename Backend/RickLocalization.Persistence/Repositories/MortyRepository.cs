using RickLocalization.Domain.Models;

namespace RickLocalization.Persistence.Repositories
{
    public class MortyRepository : RickLocalizationRepositoryBase<Morty>
    {
        public MortyRepository(RickLocalizationContext context) : base(context)
        {

        }
    }
}
