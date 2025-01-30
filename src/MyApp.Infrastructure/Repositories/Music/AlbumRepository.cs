using Microsoft.EntityFrameworkCore;
using MyApp.Domain.Entities.Music;
using MyApp.Domain.Repositories.Music;
using MyApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Repositories.Music
{
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
}
