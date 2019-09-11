using System.Threading.Tasks;

namespace Jawad.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BeersContext _beersContext;

        public UnitOfWork(BeersContext beersContext)
        {
            _beersContext = beersContext;
        }

        public int SaveChanges()
        {
            return _beersContext.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _beersContext.SaveChangesAsync();
        }
    }
}