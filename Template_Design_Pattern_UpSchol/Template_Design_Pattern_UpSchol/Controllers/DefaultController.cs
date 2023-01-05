﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_Design_Pattern_UpSchol.DAL.Entities;

namespace Template_Design_Pattern_UpSchol.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DefaultController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task <IActionResult> Index()
        {
            var values = await _userManager.Users.ToListAsync();
            return View(values);
    
        }
        public async Task<IActionResult> Index2()
        {
            var values = await _userManager.Users.ToListAsync();
            return View(values);

        }
    }
}
