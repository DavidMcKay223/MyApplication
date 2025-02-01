# Namespace: `MyApp.Application.Mappings.Music`

## Class: `AlbumProfile`

- **File Path:** `MyApp.Application/Mappings/Music/AlbumProfile.cs`
- **Inherits From:** `Profile`

### Class Code

```csharp
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
            CreateMap<UpdateAlbumDto, Album>()
                .ForMember(dest => dest.CDs, opt => opt.MapFrom(src => src.CDs));

            // Map AlbumDto to CreateAlbumDto
            CreateMap<AlbumDto, CreateAlbumDto>();

            // Map AlbumDto to UpdateAlbumDto
            CreateMap<AlbumDto, UpdateAlbumDto>();

            // Map nested objects (CDs and Tracks)
            CreateMap<CD, CDDto>().ReverseMap();
            CreateMap<Track, TrackDto>().ReverseMap();

            // Add missing mappings
            CreateMap<CDDto, CreateCDDto>();
            CreateMap<CDDto, UpdateCDDto>();
            CreateMap<TrackDto, CreateTrackDto>();
            CreateMap<TrackDto, UpdateTrackDto>();
        }
    }
```

## Class: `CDProfile`

- **File Path:** `MyApp.Application/Mappings/Music/CDProfile.cs`
- **Inherits From:** `Profile`

### Class Code

```csharp
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
```

## Class: `TrackProfile`

- **File Path:** `MyApp.Application/Mappings/Music/TrackProfile.cs`
- **Inherits From:** `Profile`

### Class Code

```csharp
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
```

