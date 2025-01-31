using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Shared.DTOs
{
    public class NavBarItemDto
    {
        public List<NavBarItemDto>? ChildList { get; set; }
        public required string Description { get; set; }
        public required string Class { get; set; }
        public required string Href { get; set; }
    }
}
