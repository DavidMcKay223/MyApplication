using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public class DeleteAlbumDto
    {
        public int ID { get; set; }
        public List<DeleteCDDto>? CDs { get; set; }
    }
}
