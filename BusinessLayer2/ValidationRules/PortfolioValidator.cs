using EntityLayer.Concrate.EntityFramework;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer2.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<MyPortfolio>
    {
        public PortfolioValidator()
        {
            //RuleFor(x => x.Img).NotEmpty().WithMessage("Fotoğrafı boş geçemezsiniz.");
            RuleFor(x => x.Link).NotEmpty().WithMessage("Çalışmanızın linkini boş geçemezsiniz.");
            RuleFor(x => x.Header).NotEmpty().WithMessage("Başlığı boş geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Açıklamayı boş geçemzsiniz.");
           
        }
    }
}
