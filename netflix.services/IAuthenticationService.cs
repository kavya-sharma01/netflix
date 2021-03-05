using System;
using System.Collections.Generic;
using System.Text;
using netflix.modal;

namespace netflix.services
{
   public interface IAuthenticationService
    {
        user ValidateUserNameAndPassword(string email, string ps);
       
    }

   
}
