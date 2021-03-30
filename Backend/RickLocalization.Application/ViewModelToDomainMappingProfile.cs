using AutoMapper;
using RickLocalization.Application.ViewModel;
using RickLocalization.Domain.Models;

namespace RickLocalization.Application
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<DimensionViewModel, Dimension>();
            CreateMap<RickViewModel,Rick>();
            CreateMap<MortyViewModel,Morty>();
        }
    }
}