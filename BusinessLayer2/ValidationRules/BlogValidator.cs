using EntityLayer.Concrate.EntityFramework;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer2.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Img).NotEmpty().WithMessage("Fotoğrafı boş geçemzesiniz.");
            RuleFor(x => x.BlogHeader).NotEmpty().WithMessage("Başlığı boş geçemezsiniz.");
            RuleFor(x => x.BlogArticle1).NotEmpty().WithMessage("1.Paragrafı boş geçemezsiniz.");
            RuleFor(x => x.BlogArticle2).NotEmpty().WithMessage("2.Paragrafı boş geçemezsiniz.");
            RuleFor(x => x.BlogArticle3).NotEmpty().WithMessage("3.Paragrafı boş geçemezsiniz.");
        }
    }
}
