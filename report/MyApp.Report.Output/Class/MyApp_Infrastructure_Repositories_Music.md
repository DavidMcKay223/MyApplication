# Namespace: `MyApp.Infrastructure.Repositories.Music`

## Class: `AlbumRepository`

- **File Path:** `MyApp.Infrastructure/Repositories/Music/AlbumRepository.cs`
- **Inherits From:** `IAlbumRepository`

### Class Code

```csharp
public class AlbumRepository : IAlbumRepository
{
    private readonly AppDbContext _context;
    public AlbumRepository(AppDbContext context) => _context = context;

    public async Task AddAsync(Album album)
    {
        await _context.Albums.AddAsync(album);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Album album)
    {
        _context.Albums.Update(album);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var album = await GetByIdAsync(id);
        if (album != null)
        {
            _context.Albums.Remove(album);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<Album?> GetByIdAsync(int id)
    {
        return await _context.Albums
        .Include(a => a.CDs)
        .ThenInclude(c => c.Tracks)
        .FirstOrDefaultAsync(a => a.ID == id);
    }

    public IQueryable<Album> GetAllAsync()
    {
        return _context.Albums
            .Include(a => a.CDs)
            .ThenInclude(c => c.Tracks)
            .AsQueryable();
    }
}

```

### Methods

| Name | Signature |
|------|-----------|
| `AddAsync` | `public Task AddAsync(Album album)` |
| `UpdateAsync` | `public Task UpdateAsync(Album album)` |
| `DeleteAsync` | `public Task DeleteAsync(int id)` |
| `GetByIdAsync` | `public Task<Album?> GetByIdAsync(int id)` |
| `GetAllAsync` | `public IQueryable<Album> GetAllAsync()` |

#### Method: `AddAsync`

```csharp

public async Task AddAsync(Album album)
{
    await _context.Albums.AddAsync(album);
    await _context.SaveChangesAsync();
}

```

#### Method: `UpdateAsync`

```csharp

public async Task UpdateAsync(Album album)
{
    _context.Albums.Update(album);
    await _context.SaveChangesAsync();
}

```

#### Method: `DeleteAsync`

```csharp

public async Task DeleteAsync(int id)
{
    var album = await GetByIdAsync(id);
    if (album != null)
    {
        _context.Albums.Remove(album);
        await _context.SaveChangesAsync();
    }
}

```

#### Method: `GetByIdAsync`

```csharp

public async Task<Album?> GetByIdAsync(int id)
{
    return await _context.Albums
    .Include(a => a.CDs)
    .ThenInclude(c => c.Tracks)
    .FirstOrDefaultAsync(a => a.ID == id);
}

```

#### Method: `GetAllAsync`

```csharp

public IQueryable<Album> GetAllAsync()
{
    return _context.Albums
        .Include(a => a.CDs)
        .ThenInclude(c => c.Tracks)
        .AsQueryable();
}

```

