using MyApp.Domain.Enums.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public class CreateCDDto
    {
        public required string Name { get; set; }
        public Genre Genre { get; set; }
        public List<CreateTrackDto>? Tracks { get; set; }
    }
}
