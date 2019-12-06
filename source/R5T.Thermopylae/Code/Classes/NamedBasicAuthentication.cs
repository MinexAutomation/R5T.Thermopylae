using System;


namespace R5T.Thermopylae
{
    public class NamedBasicAuthentication : BasicAuthentication
    {
        public AuthenticationName Name { get; set; }
    }
}
