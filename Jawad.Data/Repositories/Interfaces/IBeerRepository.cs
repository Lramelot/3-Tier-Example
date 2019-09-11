using Jawad.Core.Domains;

namespace Jawad.Data.Repositories.Interfaces
{
    public interface IBeerRepository
    {
        void CreateBeer(Brewer brewer, Beer beer);
    }
}