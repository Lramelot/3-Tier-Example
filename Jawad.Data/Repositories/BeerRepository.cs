using Jawad.Core.Domains;
using Jawad.Data.Repositories.Interfaces;

namespace Jawad.Data.Repositories
{
    public class BeerRepository : IBeerRepository
    {
        private readonly BeersContext _beersContext;

        public BeerRepository(BeersContext beersContext)
        {
            _beersContext = beersContext;
        }

        public void CreateBeer(Brewer brewer, Beer beer)
        {
            _beersContext.Brewers.Attach(brewer);
            beer.Brewer = brewer;

            _beersContext.Beers.Add(beer);
        }
    }
}