namespace Reference.Framework.Data.Repositories
{
    using Reference.Framework.Data.Infrastructure;
    using Reference.Framework.Model;

    public class GearRepository : RepositoryBase<Gear>, IGearRepository
    {
        public GearRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }


}
