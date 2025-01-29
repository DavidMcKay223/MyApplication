using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.Music
{
    public class Track
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public required string Title { get; set; }
        public TimeSpan Length { get; set; }
        public int CDId { get; set; }
        public CD? CD { get; set; }
    }
}
