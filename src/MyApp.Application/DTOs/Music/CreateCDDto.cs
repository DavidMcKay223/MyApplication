using MyApp.Domain.Enums.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public record CreateCDDto(
        string Name,
        Genre Genre,
        List<CreateTrackDto> Tracks
    );
}
