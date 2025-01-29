using MyApp.Domain.Entities.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Repositories.Music
{
    public interface IAlbumRepository
    {
        Task<Album?> GetByIdAsync(int id);
        IQueryable<Album> GetAllAsync();
        Task AddAsync(Album album);
        Task UpdateAsync(Album album);
        Task DeleteAsync(int id);
    }
}
