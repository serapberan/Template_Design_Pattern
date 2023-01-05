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
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password,false,false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
