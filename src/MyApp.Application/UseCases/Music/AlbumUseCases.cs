using MyApp.Application.DTOs.Music;
using MyApp.Domain.Entities.Music;
using MyApp.Domain.Exceptions;
using MyApp.Domain.Repositories.Music;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Music
{
    public class AlbumUseCases : IAlbumUseCases
    {
        private readonly IAlbumRepository _albumRepo;

        public AlbumUseCases(IAlbumRepository albumRepo)
        {
            _albumRepo = albumRepo;
        }

        public async Task<AlbumDto?> GetAlbumAsync(int id)
        {
            var album = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");
            return MapToDto(album);
        }

        public async Task<List<AlbumDto>> GetAllAlbumsAsync()
        {
            var albums = await _albumRepo.GetAllAsync();
            return albums.Select(album => MapToDto(album)!)
                         .Where(dto => dto != null)
                         .ToList();
        }

        public async Task CreateAlbumAsync(CreateAlbumDto dto)
        {
            var album = new Album
            {
                Artist = dto.Artist
            };

            album.CDs ??= [];

            if (dto.CDs != null)
            {
                foreach (var cdDto in dto.CDs)
                {
                    var cd = new CD
                    {
                        Name = cdDto.Name,
                        Genre = cdDto.Genre
                    };

                    if (cdDto.Tracks != null)
                    {
                        cd.Tracks ??= [];

                        foreach (var trackDto in cdDto.Tracks)
                        {
                            var track = new Track
                            {
                                Number = trackDto.Number,
                                Title = trackDto.Title,
                                Length = trackDto.Length
                            };
                            cd.Tracks.Add(track);
                        }
                    }

                    album.CDs.Add(cd);
                }
            }

            await _albumRepo.AddAsync(album);
        }

        public async Task DeleteAlbumAsync(DeleteAlbumDto dto)
        {
            await _albumRepo.DeleteAsync(dto.Id);
        }

        private static AlbumDto? MapToDto(Album? album)
        {
            if (album == null) return null;

            return new AlbumDto()
            {
                Id = album.Id,
                Artist = album.Artist,
                CDs = album.CDs.Select(cd => new CDDto
                {
                    Id = cd.Id,
                    Name = cd.Name,
                    Genre = cd.Genre,
                    Tracks = cd.Tracks.Select(t => new TrackDto
                    {
                        Id = t.Id,
                        Number = t.Number,
                        Title = t.Title,
                        Length = t.Length
                    }).ToList()
                }).ToList()
            };
        }

        public async Task<AlbumDto?> GetAlbumByIdAsync(int id)
        {
            var album = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");
            return MapToDto(album);
        }

        public async Task UpdateAlbumAsync(int id, UpdateAlbumDto dto)
        {
            var album = await _albumRepo.GetByIdAsync(id);
            if (album != null)
            {
                album.Artist = dto.Artist;
                // Add logic to update CDs and tracks
                await _albumRepo.UpdateAsync(album);
            }
        }
    }
}
