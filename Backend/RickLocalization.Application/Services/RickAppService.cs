using System;
using System.Collections.Generic;
using AutoMapper;
using RickLocalization.Application.Interface;
using RickLocalization.Application.ViewModel;
using RickLocalization.Domain.Models;
using RickLocalization.Persistence.Interfaces;

namespace RickLocalization.Application.Services
{
    public class RickAppService : IRickAppService
    {
        private readonly IRepositoryBase<Rick> _repositoryBase;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public RickAppService(IRepositoryBase<Rick> repositoryBase, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repositoryBase = repositoryBase;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public bool Add(RickViewModel entitie)
        {
            _repositoryBase.Add(_mapper.Map<Rick>(entitie));
            return _unitOfWork.Commit();
        }

        public bool Update(RickViewModel entitie)
        {
            _repositoryBase.Update(_mapper.Map<Rick>(entitie));
            return _unitOfWork.Commit();
        }

        public bool Delete(Guid id)
        {
            var rick = _mapper.Map<RickViewModel>(_repositoryBase.GetById(id));
            if (rick is null)
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

        public RickViewModel GetById(Guid id)
        {
            return _mapper.Map<RickViewModel>(_repositoryBase.GetById(id));
        }

        public IEnumerable<RickViewModel> List()
        {
            return _mapper.Map<IEnumerable<RickViewModel>>(_repositoryBase.List());
        }
    }
}