using System.Collections.Generic;
using System.Linq;
using Jawad.Core.Domains;
using Jawad.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Jawad.Data.Repositories
{
    public class BrewerRepository : IBrewerRepository
    {
        private readonly BeersContext _beersContext;

        public BrewerRepository(BeersContext beersContext)
        {
            _beersContext = beersContext;
        }

        public IEnumerable<Brewer> GetAll()
        {
            var brewers = _beersContext.Brewers.ToList();
            return brewers;
        }

        public void Create(Brewer brewer)
        {
            _beersContext.Brewers.Add(brewer);
        }

        public Brewer FindById(int id)
        {
            var brewer = _beersContext
                .Brewers
                .Include(b => b.Beers)
                .First(b => b.Id == id);

            return brewer;
        }
    }
}