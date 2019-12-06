using System;

using R5T.Stagira;


namespace R5T.Thermopylae
{
    /// <summary>
    /// The name that identifies an authentication.
    /// </summary>
    public class AuthenticationName : TypedString
    {
        public AuthenticationName(string value)
            : base(value)
        {
        }
    }
}
