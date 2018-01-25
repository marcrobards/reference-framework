namespace Reference.Framework.Service
{
    using Reference.Framework.Model;

    public interface IUserService
    {
        Role GetUserRole(User user);

        void RegisterUser(User user);

        User GetUserByEmail(string email);
    }
}
