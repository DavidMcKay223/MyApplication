using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.Music
{
    [Table("Music_Track")]
    public class Track
    {
        [Key]
        public int ID { get; set; }
        public int Number { get; set; }
        [MaxLength(500)]
        public required string Title { get; set; }
        public TimeSpan Length { get; set; }
        public int CDId { get; set; }
        public CD? CD { get; set; }
    }
}
