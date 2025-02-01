using FluentValidation;
using MyApp.Application.DTOs.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Medical
{
    public class OtherInsuranceInfoDtoValidator : AbstractValidator<OtherInsuranceInfoDto>
    {
        public OtherInsuranceInfoDtoValidator()
        {
            RuleFor(x => x.PolicyHolderName).MaximumLength(50).WithMessage("Policy Holder Name must be less than 50 characters.");
            RuleFor(x => x.PolicyNumber).MaximumLength(20).WithMessage("Policy Number must be less than 20 characters.");
            RuleFor(x => x.PlanName).MaximumLength(50).WithMessage("Plan Name must be less than 50 characters.");
        }
    }
}
