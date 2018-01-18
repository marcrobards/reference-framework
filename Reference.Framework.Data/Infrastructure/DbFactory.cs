namespace Reference.Framework.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ExerciseEntities dbContext;

        public ExerciseEntities Init()
        {
            return this.dbContext ?? (this.dbContext = new ExerciseEntities());            
        }

        protected override void DisposeCore()
        {
            if (this.dbContext != null)
            {
                this.dbContext.Dispose();
            }
        }
    }
}
