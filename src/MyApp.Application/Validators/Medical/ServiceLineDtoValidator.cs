using FluentValidation;
using MyApp.Application.DTOs.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Medical
{
    public class ServiceLineDtoValidator : AbstractValidator<ServiceLineDto>
    {
        public ServiceLineDtoValidator()
        {
            RuleFor(x => x.ProcedureCode).NotEmpty().WithMessage("Procedure code is required.")
                .MaximumLength(10).WithMessage("Procedure code must be less than 10 characters.");
            RuleFor(x => x.Modifier).MaximumLength(2).WithMessage("Modifier must be less than 2 characters.");
            RuleFor(x => x.DiagnosisPointer).MaximumLength(10).WithMessage("Diagnosis pointer must be less than 10 characters.");
            RuleFor(x => x.Charge).GreaterThanOrEqualTo(0).WithMessage("Charge must be greater than or equal to 0.");
            RuleFor(x => x.RenderingProviderId).NotEmpty().WithMessage("Rendering provider ID is required.")
                .MaximumLength(20).WithMessage("Rendering provider ID must be less than 20 characters.");
            RuleFor(x => x.ServiceEndDate).GreaterThanOrEqualTo(x => x.ServiceStartDate)
                .WithMessage("End date must be after start date.");
        }
    }
}
