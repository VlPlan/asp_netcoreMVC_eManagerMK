using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using eManager.Domain;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Serilog;

namespace eManager.Controllers
{
    
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IToastNotification _toastNotification;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserController(IUserService userService, IToastNotification toastNotification, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userService = userService;
            _toastNotification = toastNotification;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult LogIn()
        {
            return View(new LoginViewModel());
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult LogIn(LoginViewModel model)
        {


            if (ModelState.IsValid)
            {
                _userService.Login(model);
     
           
                        _toastNotification.AddSuccessToastMessage("You have successfully logged in!");
                        Log.Information($"User with username {model.Username} logged in!");
                        return RedirectToAction("index", "home");
        
        
               
                //_toastNotification.AddSuccessToastMessage("You have successfully logged in!");
                //Log.Information($"User with username {model.Username} logged in!");
                //return RedirectToAction("index", "home");

            }
            else
            {
                _toastNotification.AddWarningToastMessage("Username or password are incorect!");
            }

            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(model);
               
                return RedirectToAction("index", "home");
            }
            return View(model);
        }

        public IActionResult LogOut()
        {
            _userService.Logout();
            return RedirectToAction("index", "home");
        }


        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View(new ChangeUserPasswordViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ChangeUserPasswordViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("LogIn", "User");
                }
                var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (!result.Succeeded)
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, err.Description);
                    }
                    return View();
                }
                await _signInManager.RefreshSignInAsync(user);
                return View("ConfirmResetPassword");
            }
            return View(model);

        }

        public IActionResult ConfirmResetPassword()
        {
            return View();
        }
    }
}