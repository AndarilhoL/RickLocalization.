using AutoMapper;
using RickLocalization.Application.Interface;
using RickLocalization.Application.ViewModel;
using RickLocalization.Domain.Models;
using RickLocalization.Persistence.Interfaces;
using System;
using System.Collections.Generic;

namespace RickLocalization.Application.Services
{
    public class MortyAppService : IMortyAppService
    {
        private readonly IRepositoryBase<Morty> _repositoryBase;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public MortyAppService(IRepositoryBase<Morty> repositoryBase, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repositoryBase = repositoryBase;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public bool Add(MortyViewModel entitie)
        {
            _repositoryBase.Add(_mapper.Map<Morty>(entitie));
            return _unitOfWork.Commit();
        }

        public bool Update(MortyViewModel entitie)
        {
            _repositoryBase.Update(_mapper.Map<Morty>(entitie));
            return _unitOfWork.Commit();
        }

        public bool Delete(Guid id)
        {
            var morty = _mapper.Map<MortyViewModel>(_repositoryBase.GetById(id));
            if (morty is null)
            {
                return false;
            }

            _repositoryBase.Delete(id);
            return _unitOfWork.Commit();
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

        public MortyViewModel GetById(Guid id)
        {
            return _mapper.Map<MortyViewModel>(_repositoryBase.GetById(id));
        }

        public IEnumerable<MortyViewModel> List()
        {
            return _mapper.Map<IEnumerable<MortyViewModel>>(_repositoryBase.List());
        }
    }
}
