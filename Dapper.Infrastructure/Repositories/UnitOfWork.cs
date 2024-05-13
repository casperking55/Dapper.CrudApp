using Dapper.Application.Interfaces;

namespace Dapper.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IMarriageRepository marriageRepository)
        {
            Marriages = marriageRepository;
        }
        public IMarriageRepository Marriages { get; }
    }
}
