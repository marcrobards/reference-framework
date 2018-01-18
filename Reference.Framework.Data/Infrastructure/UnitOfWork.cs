namespace Reference.Framework.Data.Infrastructure
{
    using System.Data.Entity;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;

        public DbContextTransaction Transaction { get; private set; }

        private ExerciseEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ExerciseEntities DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void BeginTransaction()
        {
            this.Transaction = DbContext.Database.BeginTransaction();
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }

        public void Commit()
        {
            this.Transaction.Commit();            
        }

        public void Rollback()
        {
            this.Transaction.Rollback();
        }
    }
}
