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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `public int ID { get; set; }` |
| `ArtistName` | `string` | `public required string ArtistName { get; set; }` |
| `CDs` | `List<CDDto>?` | `public List<CDDto>? CDs { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `public int ID { get; set; }` |
| `Name` | `string` | `public required string Name { get; set; }` |
| `Genre` | `Genre` | `public Genre Genre { get; set; }` |
| `Tracks` | `List<TrackDto>?` | `public List<TrackDto>? Tracks { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ArtistName` | `string` | `public required string ArtistName { get; set; }` |
| `CDs` | `List<CreateCDDto>?` | `public List<CreateCDDto>? CDs { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `Name` | `string` | `public required string Name { get; set; }` |
| `Genre` | `Genre` | `public Genre Genre { get; set; }` |
| `Tracks` | `List<CreateTrackDto>?` | `public List<CreateTrackDto>? Tracks { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `Number` | `int` | `public required int Number { get; set; }` |
| `Title` | `string` | `public required string Title { get; set; }` |
| `Length` | `TimeSpan` | `public required TimeSpan Length { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `public int ID { get; set; }` |
| `CDs` | `List<DeleteCDDto>?` | `public List<DeleteCDDto>? CDs { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `public int ID { get; set; }` |
| `Tracks` | `List<DeleteTrackDto>?` | `public List<DeleteTrackDto>? Tracks { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `public int ID { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ArtistName` | `string?` | `public string? ArtistName { get; set; }` |
| `CdName` | `string?` | `public string? CdName { get; set; }` |
| `TrackTitle` | `string?` | `public string? TrackTitle { get; set; }` |
| `Genre` | `Genre?` | `public Genre? Genre { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `public int ID { get; set; }` |
| `Number` | `int` | `public required int Number { get; set; }` |
| `Title` | `string` | `public required string Title { get; set; }` |
| `Length` | `TimeSpan` | `public required TimeSpan Length { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `public int ID { get; set; }` |
| `ArtistName` | `string` | `public required string ArtistName { get; set; }` |
| `CDs` | `List<UpdateCDDto>?` | `public List<UpdateCDDto>? CDs { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `public int ID { get; set; }` |
| `Name` | `string` | `public required string Name { get; set; }` |
| `Genre` | `Genre` | `public Genre Genre { get; set; }` |
| `AlbumId` | `int` | `public int AlbumId { get; set; }` |
| `Tracks` | `List<UpdateTrackDto>?` | `public List<UpdateTrackDto>? Tracks { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `public int ID { get; set; }` |
| `Number` | `int` | `public required int Number { get; set; }` |
| `Title` | `string` | `public required string Title { get; set; }` |
| `Length` | `TimeSpan` | `public required TimeSpan Length { get; set; }` |
| `CDId` | `int` | `public int CDId { get; set; }` |

