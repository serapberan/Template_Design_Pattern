using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_Design_Pattern_UpSchol.TemplateDesignPattern
{
    public class DefaultUserCardTemplate : UserCardTemplate //bu card da sadece boş resim görünücek
    {
        protected override string SetFooter()
        {
            return string.Empty; // boş dönsün
        }

        protected override string SetImage()
        {
            return "<img class='car-img-top' src='/images/user.png' style='width:50px; height:50px;'>";
        }
    }
}
