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

| Name | Signature | Definition |
|------|-----------|-------------|
| `AddAsync` | `public Task AddAsync(Album album)` | `public async Task AddAsync(Album album)<br>        {<br>            await _context.Albums.AddAsync(album);<br>            await _context.SaveChangesAsync();<br>        }` |
| `UpdateAsync` | `public Task UpdateAsync(Album album)` | `public async Task UpdateAsync(Album album)<br>        {<br>            _context.Albums.Update(album);<br>            await _context.SaveChangesAsync();<br>        }` |
| `DeleteAsync` | `public Task DeleteAsync(int id)` | `public async Task DeleteAsync(int id)<br>        {<br>            var album = await GetByIdAsync(id);<br>            if (album != null)<br>            {<br>                _context.Albums.Remove(album);<br>                await _context.SaveChangesAsync();<br>            }<br>        }` |
| `GetByIdAsync` | `public Task<Album?> GetByIdAsync(int id)` | `public async Task<Album?> GetByIdAsync(int id)<br>        {<br>            return await _context.Albums<br>            .Include(a => a.CDs)<br>            .ThenInclude(c => c.Tracks)<br>            .FirstOrDefaultAsync(a => a.ID == id);<br>        }` |
| `GetAllAsync` | `public IQueryable<Album> GetAllAsync()` | `public IQueryable<Album> GetAllAsync()<br>        {<br>            return _context.Albums<br>                .Include(a => a.CDs)<br>                .ThenInclude(c => c.Tracks)<br>                .AsQueryable();<br>        }` |

