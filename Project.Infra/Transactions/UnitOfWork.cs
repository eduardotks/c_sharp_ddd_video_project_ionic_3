using Project.Infra.Persistence.EF;

namespace Project.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectContext _context;

        public UnitOfWork(ProjectContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}