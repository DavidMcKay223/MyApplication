using FluentValidation;
using MyApp.Application.DTOs.Music;
using MyApp.Application.Validators.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Music
{
    public class AlbumDtoValidator : AbstractValidator<AlbumDto>
    {
        public AlbumDtoValidator()
        {
            RuleFor(x => x.ArtistName).NotEmpty().WithMessage("Artist Name is required.")
                .MaximumLength(500).WithMessage("Artist Name must be less than 500 characters.");

            RuleForEach(x => x.CDs).SetValidator(new CDDtoValidator());
        }
    }
}
