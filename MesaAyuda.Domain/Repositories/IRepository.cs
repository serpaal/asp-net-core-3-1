namespace MesaAyuda.Domain.Repositories
{
    public interface IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
