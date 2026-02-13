using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator() 
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog başlığını en az 5 karekter tanımlayınız");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Blog başlığını 150 karakterden daha az giriş yapınız");

            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş geçemezsiniz.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz.");
        }
    }
}
