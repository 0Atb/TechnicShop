using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicShop.Model.ViewModels.Areas.Admin
{
    public class LogInViewModel
    {
        //dataAnnotations işlemleri

        //[EmailAddress(ErrorMessage ="Lütfen Geçerli Bir Email Giriniz.")]
        //[Required(ErrorMessage ="Lütfen Email Giriniz.")]
        public string Email { get; set; }
        //[Required(ErrorMessage ="Lütfen Şifre Giriniz")]
        //[StringLength(16,ErrorMessage ="En fazla 16 karakter yazabilirsiniz")]
        //[MinLength(3,ErrorMessage ="Lütfen en az 3 karakter giriniz.")]
        //[MaxLength(15,ErrorMessage ="En fazla 15 karakter yazabilirsiniz")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
