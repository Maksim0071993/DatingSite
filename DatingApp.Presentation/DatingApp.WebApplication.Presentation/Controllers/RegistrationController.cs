using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.WebApplication.Presentation.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DatingApp.WebApplication.Presentation.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IRegistrationService _registrationService;

        public RegistrationController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }
         
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {                
                return RedirectToAction("Index", "Search");
            }
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Index([FromForm] RegistrationViewModel model)
        {
            var resultVerivicationEmail = _registrationService.EmailVerifaction(model.Email);
            if (resultVerivicationEmail == true)
            {
                ModelState.AddModelError("", "Пользователь с таким Email существует");
            }
            else if (model.UserPassword != model.ConfirmPassword)
            {
                ModelState.AddModelError("", "Пароли должны совпадать");
            }
            else
            {
                var result = _registrationService.Register(model.Email, model.UserPassword);
                await Authenticate(model.Email, result);
                return RedirectToAction("Create", "Profile");
            }
            return View();
        }
        private async Task Authenticate(string userName, int userId)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userId.ToString())
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
