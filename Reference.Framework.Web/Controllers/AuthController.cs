namespace Reference.Framework.Web.Controllers
{
    using Microsoft.Owin.Security;
    using Reference.Framework.Service;
    using Reference.Framework.Web.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    [AllowAnonymous]
    public class AuthController : Controller
    {
        private IUserService userService;

        public AuthController(IUserService userService)
        {
            this.userService = userService;
        }

        public ActionResult LogIn(string returnUrl)
        {
            var model = new LoginViewModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult LogIn(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var authenticationManager = HttpContext.GetOwinContext().Authentication;
            var authenticationService = new AuthenticationService(authenticationManager, this.userService);

            var authenticationResult = authenticationService.SignIn(model.Email, model.Password);

            if (authenticationResult.IsSuccess)
            {
                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }

            ModelState.AddModelError(string.Empty, authenticationResult.ErrorMessage);
            return View();
        }

        public ActionResult LogOut()
        {
            IAuthenticationManager authenticationManager = HttpContext.GetOwinContext().Authentication;
            authenticationManager.SignOut(FrameworkAuthentication.ApplicationCookie);

            return RedirectToAction(nameof(System.Web.UI.WebControls.Login));
        }

        /*
        //TODO: Implement Registration
        //public ActionResult Register()
        //{
        //    var authenticationManager = HttpContext.GetOwinContext().Authentication;
        //    var authenticationService = new AuthenticationService(authenticationManager, this.userService);

        //    authenticationService.RegisterUser();

        //    return RedirectToAction(nameof(LogIn));
        //}
        */

        private string GetRedirectUrl(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("Index", "Home");
            }

            return returnUrl;
        }
    }
}