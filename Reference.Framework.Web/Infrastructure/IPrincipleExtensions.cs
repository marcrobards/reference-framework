namespace Reference.Framework.Web
{
    using Reference.Framework.Model;
    using System;
    using System.Security.Claims;
    using System.Security.Principal;

    public static class IPrincipalExtensions
    {
        public static int GetUserId(this IPrincipal user)
        {
            var claimsPrincipal = user as ClaimsPrincipal;
            if (claimsPrincipal != null)
            {
                var value = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    return Convert.ToInt32(value);
                }
            }

            return -1;
        }

        public static bool IsInRole(this IPrincipal user, Role role)
        {
            if (user == null)
            {
                return false;
            }

            return user.IsInRole(role.ToString());
        }
    }
}