using AutoMapper;
using MyApp.Application.DTOs.Music;
using MyApp.Domain.Entities.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Mappings.Music
{
    public class TrackProfile : Profile
    {
        public TrackProfile()
        {
            // Map from Track (Domain) to TrackDto (DTO)
            CreateMap<Track, TrackDto>();

            // Map from TrackDto (DTO) to Track (Domain)
            CreateMap<TrackDto, Track>();

            // Map from CreateTrackDto (DTO) to Track (Domain)
            CreateMap<CreateTrackDto, Track>();

            // Map from UpdateTrackDto (DTO) to Track (Domain)
            CreateMap<UpdateTrackDto, Track>();

            // Add missing mappings
            CreateMap<TrackDto, CreateTrackDto>();
            CreateMap<TrackDto, UpdateTrackDto>();
        }
    }
}
