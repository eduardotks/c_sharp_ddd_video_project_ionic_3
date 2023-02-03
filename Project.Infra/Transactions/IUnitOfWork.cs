namespace Project.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
