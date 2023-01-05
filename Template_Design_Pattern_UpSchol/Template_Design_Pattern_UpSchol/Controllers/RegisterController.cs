using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_Design_Pattern_UpSchol.DAL.Entities;
using Template_Design_Pattern_UpSchol.Models;

namespace Template_Design_Pattern_UpSchol.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                UserName = model.UserName,
                Email = model.Mail
            };

            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
            
        }
    }
}
