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
            RuleFor(x => x.InsuredIdNumber).MaximumLength(20).WithMessage("Insured ID Number must be less than 20 characters.")
                .NotNull().WithMessage("Insured ID Number is required.");
            RuleFor(x => x.Patient).NotNull().WithMessage("Patient information is required.");
            RuleFor(x => x.Insured).NotNull().WithMessage("Insured information is required.");
            RuleFor(x => x.BillingProvider).NotNull().WithMessage("Billing provider information is required.");
            RuleFor(x => x.ServiceFacility).NotNull().WithMessage("Service facility information is required.");
            RuleFor(x => x.TotalCharge).GreaterThanOrEqualTo(0).WithMessage("Total charge must be greater than or equal to 0.");
            RuleFor(x => x.AmountPaid).GreaterThanOrEqualTo(0).WithMessage("Amount paid must be greater than or equal to 0.");
            RuleFor(x => x.PatientSignatureDate).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Patient signature date cannot be in the future.");
            RuleFor(x => x.PhysicianSignatureDate).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Physician signature date cannot be in the future.");

            RuleForEach(x => x.ServiceLines).SetValidator(new ServiceLineDtoValidator());
            RuleForEach(x => x.DiagnosisCodes).SetValidator(new DiagnosisCodeDtoValidator());

            RuleFor(x => x.Patient).SetValidator(new PatientInfoDtoValidator());
            RuleFor(x => x.Patient.Address).SetValidator(new AddressDtoValidator());

            RuleFor(x => x.Insured).SetValidator(new InsuredInfoDtoValidator());
            RuleFor(x => x.Insured.Address).SetValidator(new AddressDtoValidator());

            RuleFor(x => x.OtherInsurance).SetValidator(new OtherInsuranceInfoDtoValidator());

            RuleFor(x => x.BillingProvider).SetValidator(new ProviderInfoDtoValidator());
            RuleFor(x => x.BillingProvider.Address).SetValidator(new AddressDtoValidator());

            RuleFor(x => x.ServiceFacility).SetValidator(new ProviderInfoDtoValidator());
            RuleFor(x => x.ServiceFacility.Address).SetValidator(new AddressDtoValidator());
        }
    }
}
