using FluentValidation;
using MyApp.Application.DTOs.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Medical
{
    public class ClaimDtoValidator : AbstractValidator<ClaimDto>
    {
        public ClaimDtoValidator()
        {
            RuleFor(x => x.InsuredIdNumber).MaximumLength(20).WithMessage("Insured ID Number must be less than 20 characters.");
            RuleFor(x => x.Patient).NotNull().WithMessage("Patient information is required.");
            RuleFor(x => x.Insured).NotNull().WithMessage("Insured information is required.");
            RuleFor(x => x.BillingProvider).NotNull().WithMessage("Billing provider information is required.");
            RuleFor(x => x.ServiceFacility).NotNull().WithMessage("Service facility information is required.");
            RuleFor(x => x.TotalCharge).GreaterThanOrEqualTo(0).WithMessage("Total charge must be greater than or equal to 0.");
            RuleFor(x => x.AmountPaid).GreaterThanOrEqualTo(0).WithMessage("Amount paid must be greater than or equal to 0.");
            RuleFor(x => x.PatientSignatureDate).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Patient signature date cannot be in the future.");
            RuleFor(x => x.PhysicianSignatureDate).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Physician signature date cannot be in the future.");
        }
    }
}
