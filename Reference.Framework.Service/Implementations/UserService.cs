namespace Reference.Framework.Service
{
    using Reference.Framework.Data.Infrastructure;
    using Reference.Framework.Data.Repositories;
    using Reference.Framework.Model;
    using System;

    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        private IUnitOfWork unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }

        public string GetUserRole(User user)
        {
            // TODO: get this from DB
            return UserRole.Admin.ToString();
        }

        public void RegisterUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            try
            {
                this.unitOfWork.BeginTransaction();

                this.userRepository.Add(user);

                this.unitOfWork.Commit();

                this.unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                this.unitOfWork.Rollback();
                throw ex;
            }
        }

        public User GetUserByEmail(string email)
        {
            return this.userRepository.Get(x => x.Email == email);
        }
    }
}
