namespace Reference.Framework.Data.Repositories
{
    using Reference.Framework.Data.Infrastructure;
    using Reference.Framework.Model;

    public class WorkoutRepository : RepositoryBase<Workout>, IWorkoutRepository
    {
        public WorkoutRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
