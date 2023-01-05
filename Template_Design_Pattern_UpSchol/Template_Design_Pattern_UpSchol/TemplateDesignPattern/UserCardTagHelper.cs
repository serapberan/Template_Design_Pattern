using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_Design_Pattern_UpSchol.DAL.Entities;

namespace Template_Design_Pattern_UpSchol.TemplateDesignPattern
{
    public class UserCardTagHelper : TagHelper
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public UserCardTagHelper(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public AppUser AppUser { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            UserCardTemplate userCardTemplate;
            if (_contextAccessor.HttpContext.User.Identity.IsAuthenticated) //otantike olan kullanıcı
            {
                userCardTemplate = new GoldUserCardTemplate();
            }
            else
            {
                userCardTemplate = new DefaultUserCardTemplate();
            }

            userCardTemplate.SetUser(AppUser);

            output.Content.SetHtmlContent(userCardTemplate.Build());
        }
    }
}
