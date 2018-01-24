namespace Reference.Framework.Web
{
    using Microsoft.Owin;
    using Microsoft.Owin.Security.Cookies;
    using Owin;
    using System;

    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = FrameworkAuthentication.ApplicationCookie,
                LoginPath = new PathString("/Auth/Login"),
                Provider = new CookieAuthenticationProvider(),
                CookieName = "FrameworkAuthenticationCookie",
                CookieHttpOnly = true,
                ExpireTimeSpan = TimeSpan.FromHours(12),
            });
        }
    }
}