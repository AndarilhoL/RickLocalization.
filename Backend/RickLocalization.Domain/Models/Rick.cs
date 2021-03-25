using System;
using System.Collections.Generic;

namespace RickLocalization.Domain.Models
{
    public class Rick
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlImage { get; set; }
        public List<Dimension> DimensionsTraveller { get; set; }
    }
}