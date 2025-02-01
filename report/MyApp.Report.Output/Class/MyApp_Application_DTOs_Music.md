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

#### Property: `ID`

```csharp
public int ID { get; set; }

```

#### Property: `ArtistName`

```csharp
public required string ArtistName { get; set; }

```

#### Property: `CDs`

```csharp
public List<CDDto>? CDs { get; set; }

```

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

#### Property: `ID`

```csharp
public int ID { get; set; }

```

#### Property: `Name`

```csharp
public required string Name { get; set; }

```

#### Property: `Genre`

```csharp
public Genre Genre { get; set; }

```

#### Property: `Tracks`

```csharp
public List<TrackDto>? Tracks { get; set; }

```

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

#### Property: `ArtistName`

```csharp
public required string ArtistName { get; set; }

```

#### Property: `CDs`

```csharp
public List<CreateCDDto>? CDs { get; set; }

```

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

#### Property: `Name`

```csharp
public required string Name { get; set; }

```

#### Property: `Genre`

```csharp
public Genre Genre { get; set; }

```

#### Property: `Tracks`

```csharp
public List<CreateTrackDto>? Tracks { get; set; }

```

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

#### Property: `Number`

```csharp
public required int Number { get; set; }

```

#### Property: `Title`

```csharp
public required string Title { get; set; }

```

#### Property: `Length`

```csharp
public required TimeSpan Length { get; set; }

```

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

#### Property: `ID`

```csharp
public int ID { get; set; }

```

#### Property: `CDs`

```csharp
public List<DeleteCDDto>? CDs { get; set; }

```

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

#### Property: `ID`

```csharp
public int ID { get; set; }

```

#### Property: `Tracks`

```csharp
public List<DeleteTrackDto>? Tracks { get; set; }

```

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

#### Property: `ID`

```csharp
public int ID { get; set; }

```

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

#### Property: `ArtistName`

```csharp
public string? ArtistName { get; set; }

```

#### Property: `CdName`

```csharp
public string? CdName { get; set; }

```

#### Property: `TrackTitle`

```csharp
public string? TrackTitle { get; set; }

```

#### Property: `Genre`

```csharp
public Genre? Genre { get; set; }

```

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

#### Property: `ID`

```csharp
public int ID { get; set; }

```

#### Property: `Number`

```csharp
public required int Number { get; set; }

```

#### Property: `Title`

```csharp
public required string Title { get; set; }

```

#### Property: `Length`

```csharp
public required TimeSpan Length { get; set; }

```

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

#### Property: `ID`

```csharp
public int ID { get; set; }

```

#### Property: `ArtistName`

```csharp
public required string ArtistName { get; set; }

```

#### Property: `CDs`

```csharp
public List<UpdateCDDto>? CDs { get; set; }

```

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

#### Property: `ID`

```csharp
public int ID { get; set; }

```

#### Property: `Name`

```csharp
public required string Name { get; set; }

```

#### Property: `Genre`

```csharp
public Genre Genre { get; set; }

```

#### Property: `AlbumId`

```csharp
public int AlbumId { get; set; }

```

#### Property: `Tracks`

```csharp
public List<UpdateTrackDto>? Tracks { get; set; }

```

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

#### Property: `ID`

```csharp
public int ID { get; set; }

```

#### Property: `Number`

```csharp
public required int Number { get; set; }

```

#### Property: `Title`

```csharp
public required string Title { get; set; }

```

#### Property: `Length`

```csharp
public required TimeSpan Length { get; set; }

```

#### Property: `CDId`

```csharp
public int CDId { get; set; }

```

