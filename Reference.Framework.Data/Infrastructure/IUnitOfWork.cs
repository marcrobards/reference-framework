namespace Reference.Framework.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void BeginTransaction();

        void SaveChanges();

        void Commit();

        void Rollback();
    }
}
