using FluentValidation;
using TechnicShop.Model.ViewModels.Areas.Admin;

namespace TechnicShop.Bussiness.Validasyon.Areas.Admin
{
    public class ForgotPasswordVmValidator : AbstractValidator<ForgotPasswordViewModel>
    {
        public ForgotPasswordVmValidator()
        {
            When(p => p.EmailOrPhoneNumber.Contains("@"), () =>
            {
                RuleFor(p => p.EmailOrPhoneNumber).NotNull().WithMessage("Lütfen Geçerli Bir Email Giriniz");
            });
            When(p => !p.EmailOrPhoneNumber.Contains("@"), () =>
            {
                RuleFor(p => p.EmailOrPhoneNumber).NotNull().WithMessage("Lütfen Geçerli Bir Telefon Numarası Giriniz");
            });
        }
    }
}
