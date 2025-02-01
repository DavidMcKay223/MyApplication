# Namespace: `MyApp.Application.UseCases.Music`

## Class: `AlbumUseCases`

- **File Path:** `MyApp.Application/UseCases/Music/AlbumUseCases.cs`
- **Inherits From:** `IAlbumUseCases`

### Class Code

```csharp
public class AlbumUseCases : IAlbumUseCases
{
    private readonly IAlbumRepository _albumRepo;
    private readonly IMapper _mapper;
    private readonly ILogger<AlbumUseCases> _logger;

    public AlbumUseCases(IAlbumRepository albumRepo, IMapper mapper, ILogger<AlbumUseCases> logger)
    {
        _albumRepo = albumRepo;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<List<AlbumDto>?> GetAllAlbumsAsync(SearchAlbumDto dto)
    {
        var query = _albumRepo.GetAllAsync().AsNoTracking();

        // Apply filters
        if (!string.IsNullOrEmpty(dto.ArtistName))
        {
            query = query.Where(a => a.ArtistName.Contains(dto.ArtistName));
        }

        if (!string.IsNullOrEmpty(dto.CdName))
        {
            query = query.Where(a => a.CDs.Any(c => c.Name.Contains(dto.CdName)));
        }

        if (!string.IsNullOrEmpty(dto.TrackTitle))
        {
            query = query.Where(a => a.CDs.Any(c => c.Tracks.Any(t => t.Title.Contains(dto.TrackTitle))));
        }

        if (dto.Genre.HasValue)
        {
            query = query.Where(a => a.CDs.Any(c => c.Genre == dto.Genre.Value));
        }

        // Apply sorting
        query = dto.SortBy switch
        {
            AlbumSortBy.CdName => dto.SortOrder == AlbumSortOrder.Asc
                                ? query.OrderBy(a => a.CDs.First().Name)
                                : query.OrderByDescending(a => a.CDs.First().Name),
            AlbumSortBy.ArtistName => dto.SortOrder == AlbumSortOrder.Asc
                                ? query.OrderBy(a => a.ArtistName)
                                : query.OrderByDescending(a => a.ArtistName),
            _ => dto.SortOrder == AlbumSortOrder.Asc
                                ? query.OrderBy(a => a.ArtistName)
                                : query.OrderByDescending(a => a.ArtistName),
        };

        // Count total items for pagination
        dto.TotalItems = await query.CountAsync();

        // Apply pagination
        var pagedAlbums = await query
            .Skip((dto.PageNumber) * dto.PageSize)
            .Take(dto.PageSize)
            .ToListAsync();

        // Further filter the CD and Track lists
        foreach (var album in pagedAlbums)
        {
            if (album.CDs != null)
            {
                if (!string.IsNullOrWhiteSpace(dto.CdName))
                {
                    album.CDs = album.CDs.Where(cd => cd.Name.Contains(dto.CdName)).ToList();
                }

                if (!string.IsNullOrWhiteSpace(dto.TrackTitle))
                {
                    foreach (var cd in album.CDs)
                    {
                        if (cd.Tracks != null)
                        {
                            cd.Tracks = cd.Tracks.Where(t => t.Title.Contains(dto.TrackTitle)).ToList();
                        }
                    }
                    album.CDs = album.CDs.Where(cd => cd.Tracks.Count != 0).ToList();
                }
            }
        }

        return _mapper.Map<List<AlbumDto>>(pagedAlbums);
    }

    public async Task CreateAlbumAsync(CreateAlbumDto dto)
    {
        ArgumentNullException.ThrowIfNull(dto);

        var album = _mapper.Map<Album>(dto);
        await _albumRepo.AddAsync(album);
        _logger.LogInformation("Album created with ID: {AlbumId}", album.ID);
    }

    public async Task DeleteAlbumAsync(DeleteAlbumDto dto)
    {
        await _albumRepo.DeleteAsync(dto.ID);
        _logger.LogInformation("Album deleted with ID: {AlbumId}", dto.ID);
    }

    public async Task<AlbumDto?> GetAlbumByIdAsync(int id)
    {
        var album = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");
        return _mapper.Map<AlbumDto>(album);
    }

    public async Task UpdateAlbumAsync(int id, UpdateAlbumDto dto)
    {
        var existingAlbum = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");

        // Ensure the ID in the DTO matches the provided ID (if applicable)
        if (dto.ID != 0 && dto.ID != id)
        {
            throw new BadRequestException("ID in the request body does not match the route ID.");
        }

        // Map updated album properties
        _mapper.Map(dto, existingAlbum);

        // Update CDs
        if (dto.CDs != null)
        {
            foreach (var cdDto in dto.CDs)
            {
                var existingCD = existingAlbum.CDs?.FirstOrDefault(cd => cd.ID == cdDto.ID);
                if (existingCD != null)
                {
                    _mapper.Map(cdDto, existingCD);
                }
                else
                {
                    var newCD = _mapper.Map<CD>(cdDto);
                    existingAlbum.CDs ??= []; // Ensure CDs list is initialized
                    existingAlbum.CDs.Add(newCD);
                }
            }

            // Remove CDs not present in the updated DTO
            var cdIds = dto.CDs.Select(cd => cd.ID).ToList();
            existingAlbum.CDs?.RemoveAll(cd => !cdIds.Contains(cd.ID));
        }

        // Update the album
        await _albumRepo.UpdateAsync(existingAlbum);
        _logger.LogInformation("Album updated with ID: {AlbumId}", id);
    }
}

```

### Methods

| Name | Signature |
|------|-----------|
| `GetAllAlbumsAsync` | `public Task<List<AlbumDto>?> GetAllAlbumsAsync(SearchAlbumDto dto)` |
| `CreateAlbumAsync` | `public Task CreateAlbumAsync(CreateAlbumDto dto)` |
| `DeleteAlbumAsync` | `public Task DeleteAlbumAsync(DeleteAlbumDto dto)` |
| `GetAlbumByIdAsync` | `public Task<AlbumDto?> GetAlbumByIdAsync(int id)` |
| `UpdateAlbumAsync` | `public Task UpdateAlbumAsync(int id, UpdateAlbumDto dto)` |

#### Method: `GetAllAlbumsAsync`

```csharp

public async Task<List<AlbumDto>?> GetAllAlbumsAsync(SearchAlbumDto dto)
{
    var query = _albumRepo.GetAllAsync().AsNoTracking();

    // Apply filters
    if (!string.IsNullOrEmpty(dto.ArtistName))
    {
        query = query.Where(a => a.ArtistName.Contains(dto.ArtistName));
    }

    if (!string.IsNullOrEmpty(dto.CdName))
    {
        query = query.Where(a => a.CDs.Any(c => c.Name.Contains(dto.CdName)));
    }

    if (!string.IsNullOrEmpty(dto.TrackTitle))
    {
        query = query.Where(a => a.CDs.Any(c => c.Tracks.Any(t => t.Title.Contains(dto.TrackTitle))));
    }

    if (dto.Genre.HasValue)
    {
        query = query.Where(a => a.CDs.Any(c => c.Genre == dto.Genre.Value));
    }

    // Apply sorting
    query = dto.SortBy switch
    {
        AlbumSortBy.CdName => dto.SortOrder == AlbumSortOrder.Asc
                            ? query.OrderBy(a => a.CDs.First().Name)
                            : query.OrderByDescending(a => a.CDs.First().Name),
        AlbumSortBy.ArtistName => dto.SortOrder == AlbumSortOrder.Asc
                            ? query.OrderBy(a => a.ArtistName)
                            : query.OrderByDescending(a => a.ArtistName),
        _ => dto.SortOrder == AlbumSortOrder.Asc
                            ? query.OrderBy(a => a.ArtistName)
                            : query.OrderByDescending(a => a.ArtistName),
    };

    // Count total items for pagination
    dto.TotalItems = await query.CountAsync();

    // Apply pagination
    var pagedAlbums = await query
        .Skip((dto.PageNumber) * dto.PageSize)
        .Take(dto.PageSize)
        .ToListAsync();

    // Further filter the CD and Track lists
    foreach (var album in pagedAlbums)
    {
        if (album.CDs != null)
        {
            if (!string.IsNullOrWhiteSpace(dto.CdName))
            {
                album.CDs = album.CDs.Where(cd => cd.Name.Contains(dto.CdName)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(dto.TrackTitle))
            {
                foreach (var cd in album.CDs)
                {
                    if (cd.Tracks != null)
                    {
                        cd.Tracks = cd.Tracks.Where(t => t.Title.Contains(dto.TrackTitle)).ToList();
                    }
                }
                album.CDs = album.CDs.Where(cd => cd.Tracks.Count != 0).ToList();
            }
        }
    }

    return _mapper.Map<List<AlbumDto>>(pagedAlbums);
}

```

#### Method: `CreateAlbumAsync`

```csharp

public async Task CreateAlbumAsync(CreateAlbumDto dto)
{
    ArgumentNullException.ThrowIfNull(dto);

    var album = _mapper.Map<Album>(dto);
    await _albumRepo.AddAsync(album);
    _logger.LogInformation("Album created with ID: {AlbumId}", album.ID);
}

```

#### Method: `DeleteAlbumAsync`

```csharp

public async Task DeleteAlbumAsync(DeleteAlbumDto dto)
{
    await _albumRepo.DeleteAsync(dto.ID);
    _logger.LogInformation("Album deleted with ID: {AlbumId}", dto.ID);
}

```

#### Method: `GetAlbumByIdAsync`

```csharp

public async Task<AlbumDto?> GetAlbumByIdAsync(int id)
{
    var album = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");
    return _mapper.Map<AlbumDto>(album);
}

```

#### Method: `UpdateAlbumAsync`

```csharp

public async Task UpdateAlbumAsync(int id, UpdateAlbumDto dto)
{
    var existingAlbum = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");

    // Ensure the ID in the DTO matches the provided ID (if applicable)
    if (dto.ID != 0 && dto.ID != id)
    {
        throw new BadRequestException("ID in the request body does not match the route ID.");
    }

    // Map updated album properties
    _mapper.Map(dto, existingAlbum);

    // Update CDs
    if (dto.CDs != null)
    {
        foreach (var cdDto in dto.CDs)
        {
            var existingCD = existingAlbum.CDs?.FirstOrDefault(cd => cd.ID == cdDto.ID);
            if (existingCD != null)
            {
                _mapper.Map(cdDto, existingCD);
            }
            else
            {
                var newCD = _mapper.Map<CD>(cdDto);
                existingAlbum.CDs ??= []; // Ensure CDs list is initialized
                existingAlbum.CDs.Add(newCD);
            }
        }

        // Remove CDs not present in the updated DTO
        var cdIds = dto.CDs.Select(cd => cd.ID).ToList();
        existingAlbum.CDs?.RemoveAll(cd => !cdIds.Contains(cd.ID));
    }

    // Update the album
    await _albumRepo.UpdateAsync(existingAlbum);
    _logger.LogInformation("Album updated with ID: {AlbumId}", id);
}

```

