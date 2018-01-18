namespace Reference.Framework.Data.Repositories
{
    using Reference.Framework.Data.Infrastructure;
    using Reference.Framework.Model;

    public class LuSportRepository : RepositoryBase<LuSport>, ILuSportRepository
    {
        public LuSportRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface ILuSportRepository : IRepository<LuSport>
    {
    }
}
