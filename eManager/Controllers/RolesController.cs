using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eManager.Domain;
using eManager.Models;
using eManager.WebModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eManager.Controllers
{
    [Authorize(Roles = "admin")]
  
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult AllRoles()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult AllUsers()
        {
            List<User> users = _userManager.Users.ToList();
            List<UserViewModel> usersList = new List<UserViewModel>();
            foreach (var u in users)
            {
                usersList.Add(new UserViewModel() { Id = u.Id, FullName = u.FullName, UserName = u.UserName });

            }
            return View(usersList);
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View(new CreateUserRolesViewModel());
        }

        [HttpPost]
        public IActionResult CreateRole(CreateUserRolesViewModel model)
        {
            IdentityRole newRole = new IdentityRole(model.RoleName);
            var result = _roleManager.CreateAsync(newRole);
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> ManageUserRole(string userId)
        {
            var user = _userManager.FindByIdAsync(userId);
            User userSelected = _userManager.Users.FirstOrDefault(x => x.Id == userId);
            ViewBag.UserId = userId;
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User does not exist!";
                return View("Error");
            }
            var model = new List<UserRolesViewModel>();
            foreach (var role in _roleManager.Roles)
            {
                var userRoleModel = new UserRolesViewModel { RoleId = role.Id, RoleName = role.Name };


                if (await _userManager.IsInRoleAsync(userSelected, role.Name))
                {
                    userRoleModel.isSelected = true;
                }
                else
                {
                    userRoleModel.isSelected = false;
                }
                model.Add(userRoleModel);
            }
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> ManageUserRole(List<UserRolesViewModel> model, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id={userId} cannot be found!";
                return View("Error");
            }
            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Не може да се избрише доделениот тикет за дозвола");
                return View(model);
            }

            result = await _userManager.AddToRolesAsync(user, model.Where(x => x.isSelected).Select(y => y.RoleName));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Не може да се додели тикетот на овој клиент");
                return View(model);
            }
            return RedirectToAction("EditUser", new { Id = userId });
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(string Id)
        {
            var role = await _roleManager.FindByIdAsync(Id);

            if (role == null)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    RequestId = Id.ToString()
                };
                return View("Error", error);
            }

            var userModel = new EditUserRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };
            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userModel.Users.Add(user.UserName);
                }
            }
            return View(userModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditUserRoleViewModel userModel)
        {
            var role = await _roleManager.FindByIdAsync(userModel.Id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id={userModel.Id} cannot be found!";
                return View("Error");
            }
            else
            {
                role.Name = userModel.RoleName;
                var result = await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("AllRoles");
                }
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }

            }
            return View(userModel);
        }

        [HttpGet]
        public async Task<IActionResult> UserInRole(string roleId)
        {
            ViewBag.RoleId = roleId;
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id={roleId} does not exist!";
                return View("Error");
            }
            var model = new List<UserRoleViewModel>();
            foreach (var user in _userManager.Users)
            {
                var userRoleModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleModel.isSelected = true;
                }
                else
                {
                    userRoleModel.isSelected = false;
                }
                model.Add(userRoleModel);
            }
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> UserInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with {roleId} cannot be found!";
                return View("Error");
            }
            for (int i = 0; i > model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].UserId);
                IdentityResult result = null;

                if (model[i].isSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].isSelected && await _userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                    {
                        continue;
                    }
                    else
                    {
                        return RedirectToAction("EditRole", new { Id = roleId });
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if(user == null)
            {

                ViewBag.ErrorMessage = $"User with Id={id} cannot be found!";
                return View("Error");
            }

            var userClaims = await _userManager.GetClaimsAsync(user);
            var userRoles = await _userManager.GetRolesAsync(user);

            var model = new EditUserViewModel
            {
                Id = user.Id,
                FullName = user.FullName,
                UserName = user.UserName,
                Claims = userClaims.Select(v => v.Value).ToList(),
                Roles = userRoles

            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);

            if(user == null)
            {
                ViewBag.ErrorMessage = $"User with Id={model.Id} cannot be found!";
                return View("Error");

            }
            else
            {
                user.FullName = model.FullName;
                user.UserName = model.UserName;

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("AllUsers");
                }
                foreach(var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
                return View(model);
            }

        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id={id} cannot be found!";
                return View("Error");
            }
            else
            {
                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("AllUsers");
                }
                foreach(var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
                return View("AllUsers");
            }
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Denied()
        {
            return View();
        }

     
    }
}