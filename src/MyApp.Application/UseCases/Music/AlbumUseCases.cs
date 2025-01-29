using Microsoft.EntityFrameworkCore;
using MyApp.Application.DTOs.Music;
using MyApp.Domain.Entities.Music;
using MyApp.Domain.Enums.Music;
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

        public async Task<List<AlbumDto>?> GetAllAlbumsAsync(AlbumSearchDto dto)
        {
            var query = _albumRepo.GetAllAsync();

            if (!string.IsNullOrEmpty(dto.ArtistName))
            {
                query = query.Where(a => a.Artist.Contains(dto.ArtistName));
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

            switch (dto.SortBy)
            {
                case AlbumSortBy.CdName:
                    query = dto.SortOrder == AlbumSortOrder.Asc
                        ? query.OrderBy(a => a.CDs.First().Name)
                        : query.OrderByDescending(a => a.CDs.First().Name);
                    break;
                case AlbumSortBy.Artist:
                    query = dto.SortOrder == AlbumSortOrder.Asc
                        ? query.OrderBy(a => a.Artist)
                        : query.OrderByDescending(a => a.Artist);
                    break;
                default:
                    break;
            }

            // Apply paging
            var pagedAlbums = await query
                .Skip((dto.PageNumber) * dto.PageSize)
                .Take(dto.PageSize)
                .ToListAsync();

            return pagedAlbums.Select(MapToDto).ToList();
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

        private static AlbumDto MapToDto(Album album)
        {
            if (album == null)
            {
                throw new ArgumentNullException(nameof(album), "Album cannot be null.");
            }

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
