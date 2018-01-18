namespace Reference.Framework.Data.Repositories
{
    using Reference.Framework.Data.Infrastructure;
    using Reference.Framework.Model;

    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
