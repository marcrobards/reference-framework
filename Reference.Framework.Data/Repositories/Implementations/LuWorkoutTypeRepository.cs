namespace Reference.Framework.Data.Repositories
{
    using Reference.Framework.Data.Infrastructure;
    using Reference.Framework.Model;

    public class LuWorkoutTypeRepository : RepositoryBase<LuWorkoutType>, ILuWorkoutTypeRepository
    {
        public LuWorkoutTypeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
