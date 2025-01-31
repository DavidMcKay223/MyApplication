using FluentValidation;
using MyApp.Application.DTOs.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Medical
{
    public class DiagnosisCodeDtoValidator : AbstractValidator<DiagnosisCodeDto>
    {
        public DiagnosisCodeDtoValidator()
        {
            RuleFor(x => x.Code).NotEmpty().WithMessage("Diagnosis code is required.")
                .MaximumLength(10).WithMessage("Diagnosis code must be less than 10 characters.");
            RuleFor(x => x.Priority).InclusiveBetween(1, 12).WithMessage("Priority must be between 1 and 12.");
        }
    }
}
