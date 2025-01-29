using MyApp.Domain.Enums.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public record UpdateCDDto(
        int Id,
        string Name,
        Genre Genre,
        List<UpdateTrackDto> Tracks
    );
}
