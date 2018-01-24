namespace Reference.Framework.Service
{
    using Reference.Framework.Model;

    public interface IUserService
    {
        string GetUserRole(User user);

        void RegisterUser(User user);

        User GetUserByEmail(string email);
    }
}
