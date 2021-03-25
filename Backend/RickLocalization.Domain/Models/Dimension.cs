using System;

namespace RickLocalization.Domain.Models
{
    public class Dimension
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlImage { get; set; }
        public Morty Morty { get; set; }
        public Guid MortyId { get; set; }
        public Rick Rick { get; set; }
        public Guid RickId { get; set; }
    }
}