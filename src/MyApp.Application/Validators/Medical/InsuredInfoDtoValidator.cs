using FluentValidation;
using MyApp.Application.DTOs.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Medical
{
    public class InsuredInfoDtoValidator : AbstractValidator<InsuredInfoDto>
    {
        public InsuredInfoDtoValidator()
        {
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name required")
                .MaximumLength(50).WithMessage("Last Name must be less than 50 characters.");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name required")
                .MaximumLength(50).WithMessage("First Name must be less than 50 characters.");
            RuleFor(x => x.GroupNumber).MaximumLength(20).WithMessage("Group Number must be less than 20 characters.");

            RuleFor(x => x.Address).SetValidator(new AddressDtoValidator());
        }
    }
}
