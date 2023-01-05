using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_Design_Pattern_UpSchol.Models
{
    public class UserRegisterViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
