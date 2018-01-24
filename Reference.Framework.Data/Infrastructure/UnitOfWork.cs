namespace Reference.Framework.Data.Infrastructure
{
    using System.Data.Entity;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;

        private ExerciseEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public DbContextTransaction Transaction { get; private set; }

        public ExerciseEntities DbContext
        {
            get { return this.dbContext ?? (this.dbContext = this.dbFactory.Init()); }
        }

        public void BeginTransaction()
        {
            this.Transaction = this.DbContext.Database.BeginTransaction();
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
