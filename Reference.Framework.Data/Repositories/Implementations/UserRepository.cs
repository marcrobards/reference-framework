namespace Reference.Framework.Data.Repositories
{
    using Reference.Framework.Data.Infrastructure;
    using Reference.Framework.Model;
    using System.Linq;

    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public Role GetUserRole(int userId)
        {
            var user = this.Get(x => x.UserId == userId && x.IsDeleted == false);

            return (Role)user.UserRoles.First().LuRole.RoleId;
        }
    }
}
