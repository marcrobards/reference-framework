namespace Reference.Framework.Data.Repositories
{
    using Reference.Framework.Data.Infrastructure;
    using Reference.Framework.Model;

    public class LuGenderRepository : RepositoryBase<LuGender>, ILuGenderRepository
    {
        public LuGenderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
