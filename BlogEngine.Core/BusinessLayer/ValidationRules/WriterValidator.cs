using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName)
                .NotEmpty().WithMessage("Yazar adı soyadı alanı boş geçilemez")
                .MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınızı")
                .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapın");

            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");

            RuleFor(x => x.WriterPassword)
                .NotEmpty().WithMessage("Şifre boş geçilemez")
                .MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalıdır")
                .Matches("[A-Z]").WithMessage("Şifre en az 1 büyük harf içermelidir")
                .Matches("[a-z]").WithMessage("Şifre en az 1 küçük harf içermelidir")
                .Matches("[0-9]").WithMessage("Şifre en az 1 rakam içermelidir");

            //RuleFor(x => x.ConfirmPassword)
            //    .NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez")
            //    .When(x => !string.IsNullOrEmpty(x.WriterPassword))
            //    .Equal(x => x.WriterPassword)
            //    .WithMessage("Şifreler eşleşmiyor");


        }
    }
}
