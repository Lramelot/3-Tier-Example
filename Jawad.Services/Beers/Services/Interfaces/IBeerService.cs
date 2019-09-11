using Jawad.Core.Domains;
using Jawad.Service.Beers.Commands;

namespace Jawad.Service.Beers.Services.Interfaces
{
    public interface IBeerService
    {
        Beer CreateBeer(CreateBeerCommand command);
    }
}