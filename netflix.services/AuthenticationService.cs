using netflix.modal;
using System;
using System.Collections.Generic;
using System.Text;

namespace netflix.services
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService()
            {
            }

        public user ValidateUserNameAndPassword(string email, string ps)
        {
            var _email = "kavya@yahoo.com";
            var _ps = "1234";
            if (email == _email && _ps == ps)
            {
                return new user { 
                Id=9990,
                email=_email
                
                };
            }
            else
            {
                return null;
            }

        }
    }
    
}
