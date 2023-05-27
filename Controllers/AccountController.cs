using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuarterlySales.Models.DataAcccess;
using QuarterlySales.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterlySales.Controllers
{
    public class AccountController : Controller
    {

        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = "")
        {
            var model = new LoginViewModel();
            model.RememberMe = false;
            model.ReturnUrl = returnUrl;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Attempt to sign in the user
                var result = await _signInManager.PasswordSignInAsync(model.Username,
                    model.Password, model.RememberMe, false);

                //If this succeeds, then redirect to the return Url, or if it's blank,
                // go back to the home page.
                if (result.Succeeded)
                {
                    if (!string.IsNullOrWhiteSpace(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }

                }

            }
            ModelState.AddModelError("", "Invalid username/password.");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            var model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User() { UserName = model.Username };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }

            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
