# Namespace: `MyApp.Application.DTOs.Music`

## Class: `AlbumDto`

- **File Path:** `MyApp.Application/DTOs/Music/AlbumDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `ArtistName` | `string` |
| `CDs` | `List<CDDto>?` |

## Class: `CDDto`

- **File Path:** `MyApp.Application/DTOs/Music/CDDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `Name` | `string` |
| `Genre` | `Genre` |
| `Tracks` | `List<TrackDto>?` |

## Class: `CreateAlbumDto`

- **File Path:** `MyApp.Application/DTOs/Music/CreateAlbumDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ArtistName` | `string` |
| `CDs` | `List<CreateCDDto>?` |

## Class: `CreateCDDto`

- **File Path:** `MyApp.Application/DTOs/Music/CreateCDDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `Name` | `string` |
| `Genre` | `Genre` |
| `Tracks` | `List<CreateTrackDto>?` |

## Class: `CreateTrackDto`

- **File Path:** `MyApp.Application/DTOs/Music/CreateTrackDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `Number` | `int` |
| `Title` | `string` |
| `Length` | `TimeSpan` |

## Class: `DeleteAlbumDto`

- **File Path:** `MyApp.Application/DTOs/Music/DeleteAlbumDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `CDs` | `List<DeleteCDDto>?` |

## Class: `DeleteCDDto`

- **File Path:** `MyApp.Application/DTOs/Music/DeleteCDDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `Tracks` | `List<DeleteTrackDto>?` |

## Class: `DeleteTrackDto`

- **File Path:** `MyApp.Application/DTOs/Music/DeleteTrackDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |

## Class: `SearchAlbumDto`

- **File Path:** `MyApp.Application/DTOs/Music/SearchAlbumDto.cs`
- **Inherits From:** `AbstractSearchDto<AlbumSortBy, AlbumSortOrder>`

### Properties

| Name | Type |
|------|------|
| `ArtistName` | `string?` |
| `CdName` | `string?` |
| `TrackTitle` | `string?` |
| `Genre` | `Genre?` |

## Class: `TrackDto`

- **File Path:** `MyApp.Application/DTOs/Music/TrackDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `Number` | `int` |
| `Title` | `string` |
| `Length` | `TimeSpan` |

## Class: `UpdateAlbumDto`

- **File Path:** `MyApp.Application/DTOs/Music/UpdateAlbumDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `ArtistName` | `string` |
| `CDs` | `List<UpdateCDDto>?` |

## Class: `UpdateCDDto`

- **File Path:** `MyApp.Application/DTOs/Music/UpdateCDDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `Name` | `string` |
| `Genre` | `Genre` |
| `AlbumId` | `int` |
| `Tracks` | `List<UpdateTrackDto>?` |

## Class: `UpdateTrackDto`

- **File Path:** `MyApp.Application/DTOs/Music/UpdateTrackDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `Number` | `int` |
| `Title` | `string` |
| `Length` | `TimeSpan` |
| `CDId` | `int` |

