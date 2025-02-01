using FluentValidation;
using MyApp.Application.DTOs.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Medical
{
    public class ProviderInfoDtoValidator : AbstractValidator<ProviderInfoDto>
    {
        public ProviderInfoDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Provider Name required.").MaximumLength(100).WithMessage("Provider Name must be less than 100 characters.");
            RuleFor(x => x.FederalTaxId).NotEmpty().WithMessage("Federal Tax Id required.")
                .MaximumLength(20).WithMessage("Federal Tax Id must be less than 20 characters.");
            RuleFor(x => x.NpiNumber).MaximumLength(20).WithMessage("Npi Number must be less than 20 characters.");
            RuleFor(x => x.Phone).MaximumLength(20).WithMessage("Phone must be less than 20 characters.");
        }
    }
}
