using FluentValidation;
using ServiceStack;
using ServiceStack.NativeTypes;
using System.Text.RegularExpressions;
using TechnicShop.Model.ViewModels.Areas.Admin;
using static System.Net.Mime.MediaTypeNames;

namespace TechnicShop.Bussiness.Validasyon.Areas.Admin
{
    public class ForgotPasswordVmValidator : AbstractValidator<ForgotPasswordViewModel>
    {
        public ForgotPasswordVmValidator()
        {
            //When(p => p.EmailOrPhoneNumber.Contains("@"), () =>
            //{
            //    RuleFor(p => p.EmailOrPhoneNumber).NotNull().WithMessage("Lütfen Geçerli Bir Email Giriniz");
            //});
            //When(p => !p.EmailOrPhoneNumber.Contains("@"), () =>
            //{
            //    RuleFor(p => p.EmailOrPhoneNumber).NotNull().WithMessage("Lütfen Geçerli Bir Telefon Numarası Giriniz");
            //});

            RuleFor(p => p.EmailOrPhoneNumber)
                .NotNull().NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
                //.EmailAddress().WithMessage("Email veya Telefon numarası girmek zorunludur.");
                //.Must(value => IsValidEmail(value) || IsValidPhoneNumber(value)).WithMessage("Format geçerli değil.");

        }

        private bool IsValidPhoneNumber(string value)
        {
            return Regex.IsMatch(value, @"^\d{10}$");
        }

        private bool IsValidEmail(string value)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(value);
                return addr.Address == value;
            }
            catch
            {
                return false;
            }
        }

        private bool Control(string arg)
        {
            try
            {
                Convert.ToInt64(arg);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        bool IsValidEmailOrTelephone(string emailOrPhone)
        {
            bool phone = Regex.IsMatch(emailOrPhone, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            bool email = Regex.IsMatch(emailOrPhone, @"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}");
            return phone || email;
        }
    }
}
