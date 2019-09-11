using System.Collections.Generic;
using Jawad.Core.Domains;
using Jawad.Service.Brewers.Commands;

namespace Jawad.Service.Brewers.Services.Interfaces
{
    public interface IBrewerService
    {
        IEnumerable<Brewer> GetAll();
        Brewer Create(CreateBrewerCommand command);
    }
}