using AutoMapper;
using MyApp.Application.DTOs.NPI;
using MyApp.Domain.Entities.NPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Mappings.NPI
{
    public class ProviderProfile : Profile
    {
        public ProviderProfile()
        {
            // Provider DTO ↔ Entity
            CreateMap<ProviderDto, Provider>()
                .ReverseMap(); // Add ReverseMap() if you need bidirectional mapping

            // Identifier DTO ↔ Entity
            CreateMap<IdentifierDto, Identifier>()
                .ReverseMap();

            // Endpoint DTO ↔ Entity (assuming you have an Endpoint entity)
            CreateMap<EndpointDto, Endpoint>()
                .ReverseMap();
        }
    }
}
