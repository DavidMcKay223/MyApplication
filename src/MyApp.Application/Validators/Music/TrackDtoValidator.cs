using FluentValidation;
using MyApp.Application.DTOs.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Music
{
    public class TrackDtoValidator : AbstractValidator<TrackDto>
    {
        public TrackDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required.")
                .MaximumLength(500).WithMessage("Title must be less than 500 characters.");
        }
    }
}
