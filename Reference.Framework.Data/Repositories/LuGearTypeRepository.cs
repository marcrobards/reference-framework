namespace Reference.Framework.Data.Repositories
{
    using Reference.Framework.Data.Infrastructure;
    using Reference.Framework.Model;

    public class LuGearTypeRepository : RepositoryBase<LuGearType>, ILuGearTypeRepository
    {
        public LuGearTypeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface ILuGearTypeRepository : IRepository<LuGearType>
    {
    }
}
