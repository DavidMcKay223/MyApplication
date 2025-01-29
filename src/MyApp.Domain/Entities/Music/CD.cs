using MyApp.Domain.Enums.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.Music
{
    public class CD
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public Genre Genre { get; set; }
        public List<Track> Tracks { get; set; } = [];
        public int AlbumId { get; set; }
        public Album? Album { get; set; }
    }
}
