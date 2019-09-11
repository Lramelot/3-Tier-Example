using Jawad.Core.Domains;
using Jawad.Data.Repositories.Interfaces;
using Jawad.Data.UnitOfWork;
using Jawad.Service.Beers.Commands;
using Jawad.Service.Beers.Services.Interfaces;

namespace Jawad.Service.Beers.Services
{
    public class BeerService : IBeerService
    {
        private readonly IBeerRepository _beerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BeerService(
            IBeerRepository beerRepository,
            IUnitOfWork unitOfWork
        )
        {
            _beerRepository = beerRepository;
            _unitOfWork = unitOfWork;
        }

        public Beer CreateBeer(CreateBeerCommand command)
        {
            var brewer = new Brewer {Id = command.BrewerId};
            var beer = new Beer
            {
                Name = command.Name,
                Description = command.Description,
                AlcoolPercentage = command.AlcoolPercentage,
            };

            _beerRepository.CreateBeer(brewer, beer);
            _unitOfWork.SaveChanges();

            return beer;
        }
    }
}