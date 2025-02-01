# Namespace: `MyApp.Domain.Entities.Music`

## Class: `Album`

- **File Path:** `MyApp.Domain/Entities/Music/Album.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[Table("Music_Album")]
public class Album
{
    [Key]
    public int ID { get; set; }

    [MaxLength(500)]
    public required string ArtistName { get; set; }
    public List<CD> CDs { get; set; } = [];
}

```

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `ArtistName` | `string` |
| `CDs` | `List<CD>` |

#### Property: `ID`

```csharp
[Key]
public int ID { get; set; }

```

#### Property: `ArtistName`

```csharp

[MaxLength(500)]
public required string ArtistName { get; set; }

```

#### Property: `CDs`

```csharp
public List<CD> CDs { get; set; } = [];

```

## Class: `CD`

- **File Path:** `MyApp.Domain/Entities/Music/CD.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[Table("Music_CD")]
public class CD
{
    [Key]
    public int ID { get; set; }

    [MaxLength(500)]
    public required string Name { get; set; }
    public Genre Genre { get; set; }
    public List<Track> Tracks { get; set; } = [];
    public int AlbumId { get; set; }
    public Album? Album { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `Name` | `string` |
| `Genre` | `Genre` |
| `Tracks` | `List<Track>` |
| `AlbumId` | `int` |
| `Album` | `Album?` |

#### Property: `ID`

```csharp
[Key]
public int ID { get; set; }

```

#### Property: `Name`

```csharp

[MaxLength(500)]
public required string Name { get; set; }

```

#### Property: `Genre`

```csharp
public Genre Genre { get; set; }

```

#### Property: `Tracks`

```csharp
public List<Track> Tracks { get; set; } = [];

```

#### Property: `AlbumId`

```csharp
public int AlbumId { get; set; }

```

#### Property: `Album`

```csharp
public Album? Album { get; set; }

```

## Class: `Track`

- **File Path:** `MyApp.Domain/Entities/Music/Track.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[Table("Music_Track")]
public class Track
{
    [Key]
    public int ID { get; set; }
    public int Number { get; set; }
    [MaxLength(500)]
    public required string Title { get; set; }
    public TimeSpan Length { get; set; }
    public int CDId { get; set; }
    public CD? CD { get; set; }
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
| `CD` | `CD?` |

#### Property: `ID`

```csharp
[Key]
public int ID { get; set; }

```

#### Property: `Number`

```csharp
public int Number { get; set; }

```

#### Property: `Title`

```csharp
[MaxLength(500)]
public required string Title { get; set; }

```

#### Property: `Length`

```csharp
public TimeSpan Length { get; set; }

```

#### Property: `CDId`

```csharp
public int CDId { get; set; }

```

#### Property: `CD`

```csharp
public CD? CD { get; set; }

```

