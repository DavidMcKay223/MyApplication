using MyApp.Domain.Enums.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public record CDDto(int Id = 0, string Name = "", Genre Genre = Genre.None, List<TrackDto>? Tracks = null);
}
