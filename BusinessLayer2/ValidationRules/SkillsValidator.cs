using EntityLayer.Concrate.EntityFramework;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer2.ValidationRules
{
    public class SkillsValidator : AbstractValidator<Skill>
    {
        public SkillsValidator()
        {
            RuleFor(x => x.SkillsName).NotEmpty().WithMessage("Yetenek Adını boş geçemezsiniz.");
            RuleFor(x => x.Percent).NotEmpty().WithMessage("Yetenek Yüzdesini boş geçemezsiniz.");
        }
    }
}
