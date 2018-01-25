namespace Reference.Framework.Web
{
    using Microsoft.Owin.Security;
    using Reference.Framework.Model;
    using Reference.Framework.Service;
    using System;
    using System.Security.Claims;
    using System.Security.Cryptography;
    using System.Text;

    public class AuthenticationService
    {
        private readonly IAuthenticationManager authenticationManager;
        private readonly IUserService userService;

        public AuthenticationService(IAuthenticationManager authenticationManager, IUserService userService)
        {
            this.authenticationManager = authenticationManager;
            this.userService = userService;
        }

        public AuthenticationResult SignIn(string email, string password)
        {
            var user = this.userService.GetUserByEmail(email);

            if (user == null)
            {
                return new AuthenticationResult("Email or Password Incorrect");
            }

            var suppliedPassword = $"{password}{user.Salt}";

            var hashedPassword = this.Hash(suppliedPassword);

            if (!hashedPassword.Equals(user.PasswordHash))
            {
                return new AuthenticationResult("Email or Password Incorrect");
            }

            var identity = CreateIdentity(user);

            authenticationManager.SignOut(FrameworkAuthentication.ApplicationCookie);
            authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, identity);

            return new AuthenticationResult();
        }

        public void RegisterUser(User user, string password)
        {
            var rng = new RNGCryptoServiceProvider();

            var salt = GenerateRandomSalt(rng, 100);
            var passwordHash = this.Hash($"{password}{salt}");

            user.Salt = salt;
            user.PasswordHash = passwordHash;

            this.userService.RegisterUser(user);
        }

        private ClaimsIdentity CreateIdentity(User user)
        {
            var identity = new ClaimsIdentity(FrameworkAuthentication.ApplicationCookie, ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            identity.AddClaim(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "OWIN"));
            identity.AddClaim(new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"));
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()));

            var role = this.userService.GetUserRole(user);

            identity.AddClaim(new Claim(ClaimTypes.Role, role.ToString()));

            return identity;
        }

        private string GenerateRandomSalt(RNGCryptoServiceProvider rng, int size)
        {
            var bytes = new byte[size];

            rng.GetBytes(bytes);

            return Convert.ToBase64String(bytes);
        }

        private string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);

            byte[] hashBytes;

            using (var algorithm = new SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}