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
    public class CDProfile : Profile
    {
        public CDProfile()
        {
            // Map from CD (Domain) to CDDto (DTO)
            CreateMap<CD, CDDto>();

            // Map from CDDto (DTO) to CD (Domain)
            CreateMap<CDDto, CD>();

            // Map from CreateCDDto (DTO) to CD (Domain)
            CreateMap<CreateCDDto, CD>();

            // Map from UpdateCDDto (DTO) to CD (Domain)
            CreateMap<UpdateCDDto, CD>()
                .ForMember(dest => dest.Tracks, opt => opt.MapFrom(src => src.Tracks));

            // Add missing mappings
            CreateMap<CDDto, CreateCDDto>();
            CreateMap<CDDto, UpdateCDDto>();
        }
    }
}
