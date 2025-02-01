# Namespace: `MyApp.Application.DTOs.Music`

## Class: `AlbumDto`

- **File Path:** `MyApp.Application/DTOs/Music/AlbumDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class AlbumDto
{
    public int ID { get; set; }
    public required string ArtistName { get; set; }
    public List<CDDto>? CDs { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `ArtistName` | `string` |
| `CDs` | `List<CDDto>?` |

## Class: `CDDto`

- **File Path:** `MyApp.Application/DTOs/Music/CDDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class CDDto
{
    public int ID { get; set; }
    public required string Name { get; set; }
    public Genre Genre { get; set; }
    public List<TrackDto>? Tracks { get; set; }
}

```

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

### Class Code

```csharp
public class CreateAlbumDto
{
    public required string ArtistName { get; set; }
    public List<CreateCDDto>? CDs { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `ArtistName` | `string` |
| `CDs` | `List<CreateCDDto>?` |

## Class: `CreateCDDto`

- **File Path:** `MyApp.Application/DTOs/Music/CreateCDDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class CreateCDDto
{
    public required string Name { get; set; }
    public Genre Genre { get; set; }
    public List<CreateTrackDto>? Tracks { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `Name` | `string` |
| `Genre` | `Genre` |
| `Tracks` | `List<CreateTrackDto>?` |

## Class: `CreateTrackDto`

- **File Path:** `MyApp.Application/DTOs/Music/CreateTrackDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class CreateTrackDto
{
    public required int Number { get; set; }
    public required string Title { get; set; }
    public required TimeSpan Length { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `Number` | `int` |
| `Title` | `string` |
| `Length` | `TimeSpan` |

## Class: `DeleteAlbumDto`

- **File Path:** `MyApp.Application/DTOs/Music/DeleteAlbumDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class DeleteAlbumDto
{
    public int ID { get; set; }
    public List<DeleteCDDto>? CDs { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `CDs` | `List<DeleteCDDto>?` |

## Class: `DeleteCDDto`

- **File Path:** `MyApp.Application/DTOs/Music/DeleteCDDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class DeleteCDDto
{
    public int ID { get; set; }
    public List<DeleteTrackDto>? Tracks { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `Tracks` | `List<DeleteTrackDto>?` |

## Class: `DeleteTrackDto`

- **File Path:** `MyApp.Application/DTOs/Music/DeleteTrackDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class DeleteTrackDto
{
    public int ID { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |

## Class: `SearchAlbumDto`

- **File Path:** `MyApp.Application/DTOs/Music/SearchAlbumDto.cs`
- **Inherits From:** `AbstractSearchDto<AlbumSortBy, AlbumSortOrder>`

### Class Code

```csharp
public class SearchAlbumDto : AbstractSearchDto<AlbumSortBy, AlbumSortOrder>
{
    public string? ArtistName { get; set; }
    public string? CdName { get; set; }
    public string? TrackTitle { get; set; }
    public Genre? Genre { get; set; }
}

```

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

### Class Code

```csharp
public class TrackDto
{
    public int ID { get; set; }
    public required int Number { get; set; }
    public required string Title { get; set; }
    public required TimeSpan Length { get; set; }
}

```

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

### Class Code

```csharp
public class UpdateAlbumDto
{
    public int ID { get; set; }
    public required string ArtistName { get; set; }
    public List<UpdateCDDto>? CDs { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `ArtistName` | `string` |
| `CDs` | `List<UpdateCDDto>?` |

## Class: `UpdateCDDto`

- **File Path:** `MyApp.Application/DTOs/Music/UpdateCDDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class UpdateCDDto
{
    public int ID { get; set; }
    public required string Name { get; set; }
    public Genre Genre { get; set; }
    public int AlbumId { get; set; }
    public List<UpdateTrackDto>? Tracks { get; set; }
}

```

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

### Class Code

```csharp
public class UpdateTrackDto
{
    public int ID { get; set; }
    public required int Number { get; set; }
    public required string Title { get; set; }
    public required TimeSpan Length { get; set; }
    public int CDId { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `Number` | `int` |
| `Title` | `string` |
| `Length` | `TimeSpan` |
| `CDId` | `int` |

