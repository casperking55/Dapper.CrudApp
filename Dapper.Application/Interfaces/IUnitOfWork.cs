namespace Dapper.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IMarriageRepository Marriages { get; }
    }
}
