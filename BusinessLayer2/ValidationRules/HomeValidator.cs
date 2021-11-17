using EntityLayer.Concrate.EntityFramework;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer2.ValidationRules
{
    public class HomeValidator : AbstractValidator<Home>
    {
        public HomeValidator()
        {
            RuleFor(x => x.TopTitle).NotEmpty().WithMessage("Başlığı boş geçemezsiniz.");
            RuleFor(x => x.BottomTitle).NotEmpty().WithMessage("Alt başlığı boş geçemezsiniz.");
        }
    }
}
