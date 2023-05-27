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
    [Authorize(Roles = "Admin")]

    public class UserController : Controller
    {
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;

        public UserController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var model = new UserAdminViewModel();
            var users = new List<User>();

            foreach (var user in _userManager.Users)
            {
                user.UserRoles = await _userManager.GetRolesAsync(user);
                users.Add(user);
            }
            model.Users = users;

            return View(model);
        }

         [HttpPost]
        public async Task<IActionResult> AddToAdmin(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromAdmin(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                await _userManager.RemoveFromRoleAsync(user, "Admin");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("Index");
        }
    }
}
