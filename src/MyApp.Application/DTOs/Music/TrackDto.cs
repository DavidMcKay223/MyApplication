using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public record TrackDto(int Id = 0, int Number = 1, string Title = "", TimeSpan Length = new TimeSpan());
}
