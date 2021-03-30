using System;
using System.Collections.Generic;

namespace RickLocalization.Application.ViewModel
{
    public class RickViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlImage { get; set; }
        public List<DimensionViewModel> DimensionsTraveller { get; set; }
    }
}