using AutoMapper;
using RickLocalization.Application.ViewModel;
using RickLocalization.Domain.Models;

namespace RickLocalization.Application
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Dimension, DimensionViewModel>();
            CreateMap<Rick,RickViewModel>();
            CreateMap<Morty,MortyViewModel>();
        }
    }
}