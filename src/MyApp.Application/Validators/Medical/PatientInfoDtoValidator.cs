using FluentValidation;
using MyApp.Application.DTOs.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Medical
{
    public class PatientInfoDtoValidator : AbstractValidator<PatientInfoDto>
    {
        public PatientInfoDtoValidator()
        {
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name required.")
                .MaximumLength(50).WithMessage("Last Name must be less than 50 characters.");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name required.").MaximumLength(50).WithMessage("First Name must be less than 50 characters.");
            RuleFor(x => x.BirthDate).NotEmpty().WithMessage("Birth Date required.");
        }
    }
}
