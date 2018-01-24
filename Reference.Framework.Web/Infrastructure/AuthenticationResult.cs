namespace Reference.Framework.Web
{
    using Reference.Framework.Model;
    using System;

    public class AuthenticationResult
    {
        public AuthenticationResult(string errorMessage = null)
        {
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; private set; }

        public bool IsSuccess => string.IsNullOrEmpty(ErrorMessage);
    }
}