using Jawad.Core.Domains;
using Jawad.Data;
using Jawad.Service.Beers.Commands;
using Jawad.Service.Beers.Services.Interfaces;

namespace Jawad.Service.Beers.Services
{
    public class BeerService : IBeerService
    {
        private readonly BeersContext _beersContext;

        public BeerService(BeersContext beersContext)
        {
            _beersContext = beersContext;
        }

        public Beer CreateBeer(CreateBeerCommand command)
        {
            var brewer = new Brewer {Id = command.BrewerId};
            var beer = new Beer
            {
                Name = command.Name,
                Description = command.Description,
                AlcoolPercentage = command.AlcoolPercentage,
                Brewer = brewer
            };

            _beersContext.Brewers.Attach(brewer);
            _beersContext.Beers.Add(beer);
            _beersContext.SaveChanges();

            return beer;
        }
    }
}