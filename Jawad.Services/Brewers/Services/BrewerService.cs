using System.Collections.Generic;
using Jawad.Core.Domains;
using Jawad.Data.Repositories.Interfaces;
using Jawad.Data.UnitOfWork;
using Jawad.Service.Brewers.Commands;
using Jawad.Service.Brewers.Services.Interfaces;

namespace Jawad.Service.Brewers.Services
{
    public class BrewerService : IBrewerService
    {
        private readonly IBrewerRepository _brewerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BrewerService(
            IBrewerRepository brewerRepository,
            IUnitOfWork unitOfWork
        )
        {
            _brewerRepository = brewerRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Brewer> GetAll()
        {
            var brewers = _brewerRepository.GetAll();
            return brewers;
        }

        public Brewer Create(CreateBrewerCommand command)
        {
            var brewer = new Brewer
            {
                Name = command.Name,
                City = command.City
            };

            _brewerRepository.Create(brewer);
            _unitOfWork.SaveChanges();

            return brewer;
        }
    }
}