using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public class CreateAlbumDto
    {
        public required string ArtistName { get; set; }
        public List<CreateCDDto>? CDs { get; set; }
    }
}
