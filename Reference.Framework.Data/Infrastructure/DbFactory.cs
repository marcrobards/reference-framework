namespace Reference.Framework.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        ExerciseEntities dbContext;

        public ExerciseEntities Init()
        {
            return dbContext ?? (dbContext = new ExerciseEntities());            
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
