using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public class DeleteCDDto
    {
        public int ID { get; set; }
        public List<DeleteTrackDto>? Tracks { get; set; }
    }
}
