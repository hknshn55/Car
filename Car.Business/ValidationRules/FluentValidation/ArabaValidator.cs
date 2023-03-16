using Car.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Business.ValidationRules.FluentValidation
{
    public class ArabaValidator:AbstractValidator<Araba>
    {
        public ArabaValidator()
        {
            RuleFor(x => x.Marka).MaximumLength(50);
            RuleFor(x => x.Model).NotNull();
        }
    }
}
