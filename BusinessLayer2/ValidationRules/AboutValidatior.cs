using EntityLayer.Concrate.EntityFramework;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer2.ValidationRules
{
    public class AboutValidatior:AbstractValidator<About>
    {
        public AboutValidatior()
        {
            RuleFor(x => x.Img).NotEmpty().WithMessage("Fotoğrafı boş geçemzesiniz.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz.");
            RuleFor(x => x.Degree).NotEmpty().WithMessage("Derecenizi boş geçemezsiniz.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehri boş geçemzsiniz.");
            RuleFor(x => x.GitHub).NotEmpty().WithMessage("Github Linkini boş geçemezsiniz.");
        }
    }
}
