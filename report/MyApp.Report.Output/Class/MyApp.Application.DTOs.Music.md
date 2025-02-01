# AlbumDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/AlbumDto.cs`

## Properties

- `int ID`
- `string ArtistName`
- `List<CDDto>? CDs`

# CDDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/CDDto.cs`

## Properties

- `int ID`
- `string Name`
- `Genre Genre`
- `List<TrackDto>? Tracks`

# CreateAlbumDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/CreateAlbumDto.cs`

## Properties

- `string ArtistName`
- `List<CreateCDDto>? CDs`

# CreateCDDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/CreateCDDto.cs`

## Properties

- `string Name`
- `Genre Genre`
- `List<CreateTrackDto>? Tracks`

# CreateTrackDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/CreateTrackDto.cs`

## Properties

- `int Number`
- `string Title`
- `TimeSpan Length`

# DeleteAlbumDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/DeleteAlbumDto.cs`

## Properties

- `int ID`
- `List<DeleteCDDto>? CDs`

# DeleteCDDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/DeleteCDDto.cs`

## Properties

- `int ID`
- `List<DeleteTrackDto>? Tracks`

# DeleteTrackDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/DeleteTrackDto.cs`

## Properties

- `int ID`

# SearchAlbumDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/SearchAlbumDto.cs`

## Inherits From

- `AbstractSearchDto<AlbumSortBy, AlbumSortOrder>`

## Properties

- `string? ArtistName`
- `string? CdName`
- `string? TrackTitle`
- `Genre? Genre`

# TrackDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/TrackDto.cs`

## Properties

- `int ID`
- `int Number`
- `string Title`
- `TimeSpan Length`

# UpdateAlbumDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/UpdateAlbumDto.cs`

## Properties

- `int ID`
- `string ArtistName`
- `List<UpdateCDDto>? CDs`

# UpdateCDDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/UpdateCDDto.cs`

## Properties

- `int ID`
- `string Name`
- `Genre Genre`
- `int AlbumId`
- `List<UpdateTrackDto>? Tracks`

# UpdateTrackDto

**Namespace:** `MyApp.Application.DTOs.Music`

**File Path:** `MyApp.Application/DTOs/Music/UpdateTrackDto.cs`

## Properties

- `int ID`
- `int Number`
- `string Title`
- `TimeSpan Length`
- `int CDId`

