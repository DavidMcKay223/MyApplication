using MyApp.Application.DTOs.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Music
{
    public interface IAlbumUseCases
    {
        Task<List<AlbumDto>?> GetAllAlbumsAsync(AlbumSearchDto dto);
        Task<AlbumDto?> GetAlbumByIdAsync(int id);
        Task CreateAlbumAsync(CreateAlbumDto dto);
        Task UpdateAlbumAsync(int id, UpdateAlbumDto dto);
        Task DeleteAlbumAsync(DeleteAlbumDto dto);
    }
}
