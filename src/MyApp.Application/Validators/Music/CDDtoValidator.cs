using FluentValidation;
using MyApp.Application.DTOs.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Music
{
    public class CDDtoValidator : AbstractValidator<CDDto>
    {
        public CDDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("CD Name is required.")
                .MaximumLength(500).WithMessage("CD Name must be less than 500 characters.");

            RuleForEach(x => x.Tracks).SetValidator(new TrackDtoValidator());
        }
    }
}
