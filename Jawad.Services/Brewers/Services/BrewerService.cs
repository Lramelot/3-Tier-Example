using System.Collections.Generic;
using System.Linq;
using Jawad.Core.Domains;
using Jawad.Data;
using Jawad.Service.Brewers.Commands;
using Jawad.Service.Brewers.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Jawad.Service.Brewers.Services
{
    public class BrewerService : IBrewerService
    {
        private readonly BeersContext _beersContext;

        public BrewerService(BeersContext beersContext)
        {
            _beersContext = beersContext;
        }

        public IEnumerable<Brewer> GetAll()
        {
            var brewers = _beersContext.Brewers.ToList();
            return brewers;
        }

        public Brewer Create(CreateBrewerCommand command)
        {
            var brewer = new Brewer
            {
                Name = command.Name,
                City = command.City
            };

            _beersContext.Brewers.Add(brewer);
            _beersContext.SaveChanges();

            return brewer;
        }

        public Brewer GetOne(int id)
        {
            var brewer = _beersContext
                .Brewers
                .Include(b => b.Beers)
                .First(b => b.Id == id);

            return brewer;
        }
    }
}