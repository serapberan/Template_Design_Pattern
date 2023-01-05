using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_Design_Pattern_UpSchol.DAL.Entities;

namespace Template_Design_Pattern_UpSchol.DAL
{
    public class Context : IdentityDbContext <AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FEC73RP; initial catalog=DbTemplateDp; integrated security=true");
        }

        
    }
}
