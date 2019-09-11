using System.Collections.Generic;
using Jawad.Core.Domains;

namespace Jawad.Data.Repositories.Interfaces
{
    public interface IBrewerRepository
    {
        IEnumerable<Brewer> GetAll();
        void Create(Brewer brewer);
    }
}