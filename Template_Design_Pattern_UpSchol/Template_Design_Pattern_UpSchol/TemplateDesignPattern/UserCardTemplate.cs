using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_Design_Pattern_UpSchol.DAL.Entities;

namespace Template_Design_Pattern_UpSchol.TemplateDesignPattern
{
    public abstract  class UserCardTemplate //newlenemez metod içi dolurulur
    {
        protected AppUser AppUser { get; set; } //protected bulunduğu sınıf ve kalıtım verdiği ulaşılır
        public void SetUser(AppUser appUser)
        {
            AppUser = appUser;
        }
        protected abstract string SetImage();//method olarak tanımladık çünkü kullanıcıya göre arayüz değişicek
        protected abstract string SetFooter(); // 

        //abstract class sayesinde metod içini doluruyoruz
        public string Build() //yapıcı metod tanımladık
        {
            var sb = new StringBuilder();//html de string formatta geçememimizi sağlar
            sb.Append("<div class='card'>"); //parametreleri string yapar ve biirleştiri templatecard ın cercevesini oluşturduk
            sb.Append(SetImage());
            //$dışardan paramerte alacak verigöndermek için -   @alt alta devam edebilmek için
            sb.Append($@"<div class='card-body' 
                        <h5>{AppUser.Name}</h5>
                        <p>{AppUser.Description}</p>");
            sb.Append(SetFooter());
            sb.Append("</div>");
            sb.Append("</div>");
            return sb.ToString();
        }
    }
}
