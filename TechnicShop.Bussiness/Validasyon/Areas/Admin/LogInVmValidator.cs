using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicShop.Model.ViewModels.Areas.Admin;

namespace TechnicShop.Bussiness.Validasyon.Areas.Admin
{
    public class LogInVmValidator : AbstractValidator<LogInViewModel>
    {
        public LogInVmValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Lütfen Email Alanını Boş Bırakmayınız.")
                .NotNull().WithMessage("Email alanı zorunlu")
                .EmailAddress().WithMessage("Lütfen email giriniz.").Equal(x => x.Email).WithMessage("Email Eşleşmiyor");


            RuleFor(x => x.Password)/*Must(buyuk).*/
                .NotEmpty().WithMessage("Lütfen Sifre Alanını boş bırakmayınız")
                .MaximumLength(15).WithMessage("Lütfen En fazla 15 karakter giriniz")
                .MinimumLength(3).WithMessage("Lütfen En az 3 karakter giriniz.");

        }

        //private bool buyuk(string arg)
        //{
        //    throw new NotImplementedException();
        //}




        //RuleFor(p => p.Password).NotEmpty().WithMessage("Your password cannot be empty")
        //            .MinimumLength(8).WithMessage("Your password length must be at least 8.")
        //            .MaximumLength(16).WithMessage("Your password length must not exceed 16.")
        //            .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
        //            .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
        //            .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.")
        //            .Matches(@"[\!\?\*\.]+").WithMessage("Your password must contain at least one (!? *.).");
    }
}
