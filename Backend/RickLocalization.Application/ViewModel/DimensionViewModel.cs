using System;

namespace RickLocalization.Application.ViewModel
{
    public class DimensionViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlImage { get; set; }
        public MortyViewModel Morty { get; set; }
        public Guid MortyId { get; set; }
        public RickViewModel Rick { get; set; }
        public Guid RickId { get; set; }
    }
}