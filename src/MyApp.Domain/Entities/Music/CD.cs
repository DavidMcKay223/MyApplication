using MyApp.Domain.Enums.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.Music
{
    [Table("Music_CD")]
    public class CD
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(500)]
        public required string Name { get; set; }
        public Genre Genre { get; set; }
        public List<Track> Tracks { get; set; } = [];
        public int AlbumId { get; set; }
        public Album? Album { get; set; }
    }
}
