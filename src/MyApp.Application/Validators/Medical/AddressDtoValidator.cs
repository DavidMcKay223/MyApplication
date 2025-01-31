using FluentValidation;
using MyApp.Application.DTOs.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Medical
{
    public class AddressDtoValidator : AbstractValidator<AddressDto>
    {
        public AddressDtoValidator()
        {
            RuleFor(x => x.Street).MaximumLength(100).WithMessage("Street must be less than 100 characters.");
            RuleFor(x => x.City).MaximumLength(50).WithMessage("City must be less than 50 characters.");
            RuleFor(x => x.State).MaximumLength(2).WithMessage("State must be 2 characters.");
            RuleFor(x => x.ZipCode).MaximumLength(10).WithMessage("ZipCode must be less than 10 characters.");
            RuleFor(x => x.Phone).MaximumLength(20).WithMessage("Phone must be less than 20 characters.");
        }
    }
}
