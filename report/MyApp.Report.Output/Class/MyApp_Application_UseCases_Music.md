# Namespace: `MyApp.Application.UseCases.Music`

## Class: `AlbumUseCases`

- **File Path:** `MyApp.Application/UseCases/Music/AlbumUseCases.cs`
- **Inherits From:** `IAlbumUseCases`

### Methods

| Name | Return Type | Access Modifier | Static | Parameters |
|------|-------------|-----------------|--------|------------|
| `GetAllAlbumsAsync` | `Task<List<AlbumDto>?>` | `public` | `No` | `SearchAlbumDto dto` |
| `CreateAlbumAsync` | `Task` | `public` | `No` | `CreateAlbumDto dto` |
| `DeleteAlbumAsync` | `Task` | `public` | `No` | `DeleteAlbumDto dto` |
| `GetAlbumByIdAsync` | `Task<AlbumDto?>` | `public` | `No` | `int id` |
| `UpdateAlbumAsync` | `Task` | `public` | `No` | `int id`, `UpdateAlbumDto dto` |

