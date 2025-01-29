using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public class AlbumDto
    {
        public int Id { get; set; }
        public required string Artist { get; set; }
        public List<CDDto>? CDs { get; set; }
    }
}
