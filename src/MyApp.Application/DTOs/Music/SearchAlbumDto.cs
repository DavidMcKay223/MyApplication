using MyApp.Application.Common;
using MyApp.Domain.Enums.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public class AlbumSearchDto : AbstractSearchDto<AlbumSortBy, AlbumSortOrder>
    {
        public string? ArtistName { get; set; }
        public string? CdName { get; set; }
        public string? TrackTitle { get; set; }
        public Genre? Genre { get; set; }
    }
}
