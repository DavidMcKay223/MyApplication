using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyApp.Application.DTOs.Music;
using MyApp.Domain.Entities.Music;

namespace MyApp.Application.Mappings.Music
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
            // Map from Album (Domain) to AlbumDto (DTO)
            CreateMap<Album, AlbumDto>();

            // Map from AlbumDto (DTO) to Album (Domain)
            CreateMap<AlbumDto, Album>();

            // Map from CreateAlbumDto (DTO) to Album (Domain)
            CreateMap<CreateAlbumDto, Album>();

            // Map from UpdateAlbumDto (DTO) to Album (Domain)
            CreateMap<UpdateAlbumDto, Album>();

            // Map nested objects (CDs and Tracks)
            CreateMap<CD, CDDto>().ReverseMap();
            CreateMap<Track, TrackDto>().ReverseMap();
        }
    }
}
