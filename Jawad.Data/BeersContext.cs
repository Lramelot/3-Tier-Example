using Jawad.Core.Domains;
using Microsoft.EntityFrameworkCore;

namespace Jawad.Data
{
    public class BeersContext : DbContext
    {
        public BeersContext(DbContextOptions<BeersContext> options) : base(options) { }

        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brewer> Brewers { get; set; }
    }
}