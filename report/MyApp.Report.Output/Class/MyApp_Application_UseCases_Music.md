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

| Name | Signature | Definition |
|------|-----------|-------------|
| `GetAllAlbumsAsync` | `public Task<List<AlbumDto>?> GetAllAlbumsAsync(SearchAlbumDto dto)` | `public async Task<List<AlbumDto>?> GetAllAlbumsAsync(SearchAlbumDto dto)<br>        {<br>            var query = _albumRepo.GetAllAsync().AsNoTracking();<br><br>            // Apply filters<br>            if (!string.IsNullOrEmpty(dto.ArtistName))<br>            {<br>                query = query.Where(a => a.ArtistName.Contains(dto.ArtistName));<br>            }<br><br>            if (!string.IsNullOrEmpty(dto.CdName))<br>            {<br>                query = query.Where(a => a.CDs.Any(c => c.Name.Contains(dto.CdName)));<br>            }<br><br>            if (!string.IsNullOrEmpty(dto.TrackTitle))<br>            {<br>                query = query.Where(a => a.CDs.Any(c => c.Tracks.Any(t => t.Title.Contains(dto.TrackTitle))));<br>            }<br><br>            if (dto.Genre.HasValue)<br>            {<br>                query = query.Where(a => a.CDs.Any(c => c.Genre == dto.Genre.Value));<br>            }<br><br>            // Apply sorting<br>            query = dto.SortBy switch<br>            {<br>                AlbumSortBy.CdName => dto.SortOrder == AlbumSortOrder.Asc<br>                                    ? query.OrderBy(a => a.CDs.First().Name)<br>                                    : query.OrderByDescending(a => a.CDs.First().Name),<br>                AlbumSortBy.ArtistName => dto.SortOrder == AlbumSortOrder.Asc<br>                                    ? query.OrderBy(a => a.ArtistName)<br>                                    : query.OrderByDescending(a => a.ArtistName),<br>                _ => dto.SortOrder == AlbumSortOrder.Asc<br>                                    ? query.OrderBy(a => a.ArtistName)<br>                                    : query.OrderByDescending(a => a.ArtistName),<br>            };<br><br>            // Count total items for pagination<br>            dto.TotalItems = await query.CountAsync();<br><br>            // Apply pagination<br>            var pagedAlbums = await query<br>                .Skip((dto.PageNumber) * dto.PageSize)<br>                .Take(dto.PageSize)<br>                .ToListAsync();<br><br>            // Further filter the CD and Track lists<br>            foreach (var album in pagedAlbums)<br>            {<br>                if (album.CDs != null)<br>                {<br>                    if (!string.IsNullOrWhiteSpace(dto.CdName))<br>                    {<br>                        album.CDs = album.CDs.Where(cd => cd.Name.Contains(dto.CdName)).ToList();<br>                    }<br><br>                    if (!string.IsNullOrWhiteSpace(dto.TrackTitle))<br>                    {<br>                        foreach (var cd in album.CDs)<br>                        {<br>                            if (cd.Tracks != null)<br>                            {<br>                                cd.Tracks = cd.Tracks.Where(t => t.Title.Contains(dto.TrackTitle)).ToList();<br>                            }<br>                        }<br>                        album.CDs = album.CDs.Where(cd => cd.Tracks.Count != 0).ToList();<br>                    }<br>                }<br>            }<br><br>            return _mapper.Map<List<AlbumDto>>(pagedAlbums);<br>        }` |
| `CreateAlbumAsync` | `public Task CreateAlbumAsync(CreateAlbumDto dto)` | `public async Task CreateAlbumAsync(CreateAlbumDto dto)<br>        {<br>            ArgumentNullException.ThrowIfNull(dto);<br><br>            var album = _mapper.Map<Album>(dto);<br>            await _albumRepo.AddAsync(album);<br>            _logger.LogInformation("Album created with ID: {AlbumId}", album.ID);<br>        }` |
| `DeleteAlbumAsync` | `public Task DeleteAlbumAsync(DeleteAlbumDto dto)` | `public async Task DeleteAlbumAsync(DeleteAlbumDto dto)<br>        {<br>            await _albumRepo.DeleteAsync(dto.ID);<br>            _logger.LogInformation("Album deleted with ID: {AlbumId}", dto.ID);<br>        }` |
| `GetAlbumByIdAsync` | `public Task<AlbumDto?> GetAlbumByIdAsync(int id)` | `public async Task<AlbumDto?> GetAlbumByIdAsync(int id)<br>        {<br>            var album = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");<br>            return _mapper.Map<AlbumDto>(album);<br>        }` |
| `UpdateAlbumAsync` | `public Task UpdateAlbumAsync(int id, UpdateAlbumDto dto)` | `public async Task UpdateAlbumAsync(int id, UpdateAlbumDto dto)<br>        {<br>            var existingAlbum = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");<br><br>            // Ensure the ID in the DTO matches the provided ID (if applicable)<br>            if (dto.ID != 0 && dto.ID != id)<br>            {<br>                throw new BadRequestException("ID in the request body does not match the route ID.");<br>            }<br><br>            // Map updated album properties<br>            _mapper.Map(dto, existingAlbum);<br><br>            // Update CDs<br>            if (dto.CDs != null)<br>            {<br>                foreach (var cdDto in dto.CDs)<br>                {<br>                    var existingCD = existingAlbum.CDs?.FirstOrDefault(cd => cd.ID == cdDto.ID);<br>                    if (existingCD != null)<br>                    {<br>                        _mapper.Map(cdDto, existingCD);<br>                    }<br>                    else<br>                    {<br>                        var newCD = _mapper.Map<CD>(cdDto);<br>                        existingAlbum.CDs ??= []; // Ensure CDs list is initialized<br>                        existingAlbum.CDs.Add(newCD);<br>                    }<br>                }<br><br>                // Remove CDs not present in the updated DTO<br>                var cdIds = dto.CDs.Select(cd => cd.ID).ToList();<br>                existingAlbum.CDs?.RemoveAll(cd => !cdIds.Contains(cd.ID));<br>            }<br><br>            // Update the album<br>            await _albumRepo.UpdateAsync(existingAlbum);<br>            _logger.LogInformation("Album updated with ID: {AlbumId}", id);<br>        }` |

