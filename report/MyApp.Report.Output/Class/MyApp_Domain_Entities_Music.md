# Namespace: `MyApp.Domain.Entities.Music`

## Class: `Album`

- **File Path:** `MyApp.Domain/Entities/Music/Album.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `ArtistName` | `string` |
| `CDs` | `List<CD>` |

## Class: `CD`

- **File Path:** `MyApp.Domain/Entities/Music/CD.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `Name` | `string` |
| `Genre` | `Genre` |
| `Tracks` | `List<Track>` |
| `AlbumId` | `int` |
| `Album` | `Album?` |

## Class: `Track`

- **File Path:** `MyApp.Domain/Entities/Music/Track.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `Number` | `int` |
| `Title` | `string` |
| `Length` | `TimeSpan` |
| `CDId` | `int` |
| `CD` | `CD?` |

