using MyApp.Domain.Enums.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public record UpdateCDDto(
        string Name,
        Genre Genre,
        List<UpdateTrackDto> Tracks
    );
}
