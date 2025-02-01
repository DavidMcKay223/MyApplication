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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `[Key]<br>        public int ID { get; set; }` |
| `ArtistName` | `string` | `[MaxLength(500)]<br>        public required string ArtistName { get; set; }` |
| `CDs` | `List<CD>` | `public List<CD> CDs { get; set; } = [];` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `[Key]<br>        public int ID { get; set; }` |
| `Name` | `string` | `[MaxLength(500)]<br>        public required string Name { get; set; }` |
| `Genre` | `Genre` | `public Genre Genre { get; set; }` |
| `Tracks` | `List<Track>` | `public List<Track> Tracks { get; set; } = [];` |
| `AlbumId` | `int` | `public int AlbumId { get; set; }` |
| `Album` | `Album?` | `public Album? Album { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `[Key]<br>        public int ID { get; set; }` |
| `Number` | `int` | `public int Number { get; set; }` |
| `Title` | `string` | `[MaxLength(500)]<br>        public required string Title { get; set; }` |
| `Length` | `TimeSpan` | `public TimeSpan Length { get; set; }` |
| `CDId` | `int` | `public int CDId { get; set; }` |
| `CD` | `CD?` | `public CD? CD { get; set; }` |

