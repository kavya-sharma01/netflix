using Microsoft.AspNetCore.Mvc;
using netflix.web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netflix.services;
using Microsoft.AspNetCore.Http;

namespace netflix.web.Controllers
{
    public class Authentication : Controller
    {
        private readonly IAuthenticationService authenticationService;

        public Authentication(IAuthenticationService
            authenticationService)
        {
           this.authenticationService = authenticationService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult loginviewuser()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            var userDetail = authenticationService.ValidateUserNameAndPassword(loginViewModel.email, loginViewModel.ps);
            if (userDetail !=null)
            {
                HttpContext.Session.SetString("UserEmail" , userDetail.email);
                HttpContext.Session.SetString("UserId", userDetail.Id.ToString());
                return RedirectToAction("MyAccount", "Account");
            }
            ViewBag.isInvalidCreds = true;
            return View();
        }

    }
}
