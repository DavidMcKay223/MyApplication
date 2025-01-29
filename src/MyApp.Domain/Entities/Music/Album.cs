using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.Music
{
    public class Album
    {
        public int Id { get; set; }
        public required string Artist { get; set; }
        public List<CD> CDs { get; set; } = [];
    }
}
