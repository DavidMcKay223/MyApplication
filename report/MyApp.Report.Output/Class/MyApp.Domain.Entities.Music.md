# Album

**Namespace:** `MyApp.Domain.Entities.Music`

**File Path:** `MyApp.Domain/Entities/Music/Album.cs`

## Properties

- `int ID`
- `string ArtistName`
- `List<CD> CDs`

# CD

**Namespace:** `MyApp.Domain.Entities.Music`

**File Path:** `MyApp.Domain/Entities/Music/CD.cs`

## Properties

- `int ID`
- `string Name`
- `Genre Genre`
- `List<Track> Tracks`
- `int AlbumId`
- `Album? Album`

# Track

**Namespace:** `MyApp.Domain.Entities.Music`

**File Path:** `MyApp.Domain/Entities/Music/Track.cs`

## Properties

- `int ID`
- `int Number`
- `string Title`
- `TimeSpan Length`
- `int CDId`
- `CD? CD`

