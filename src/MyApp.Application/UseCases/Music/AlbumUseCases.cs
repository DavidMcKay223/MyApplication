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

        public async Task<List<AlbumDto>?> GetAllAlbumsAsync(SearchAlbumDto dto)
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

            query = dto.SortBy switch
            {
                AlbumSortBy.CdName => dto.SortOrder == AlbumSortOrder.Asc
                                        ? query.OrderBy(a => a.CDs.First().Name)
                                        : query.OrderByDescending(a => a.CDs.First().Name),
                AlbumSortBy.Artist => dto.SortOrder == AlbumSortOrder.Asc
                                        ? query.OrderBy(a => a.Artist)
                                        : query.OrderByDescending(a => a.Artist),
                _ => dto.SortOrder == AlbumSortOrder.Asc
                                        ? query.OrderBy(a => a.Artist)
                                        : query.OrderByDescending(a => a.Artist),
            };

            dto.TotalItems = await query.CountAsync();

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
                        album.CDs = album.CDs
                            .Where(cd => cd.Name.Contains(dto.CdName))
                            .ToList();
                    }

                    if (!string.IsNullOrWhiteSpace(dto.TrackTitle))
                    {
                        foreach (var cd in album.CDs)
                        {
                            if (cd.Tracks != null)
                            {
                                cd.Tracks = cd.Tracks
                                    .Where(t => t.Title.Contains(dto.TrackTitle))
                                    .ToList();
                            }
                        }
                        album.CDs = album.CDs.Where(cd => cd.Tracks.Count != 0).ToList();
                    }
                }
            }

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
            var album = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");

            // Update album properties
            album.Artist = dto.Artist;

            // Update or add CDs
            if (dto.CDs != null)
            {
                // Ensure album.CDs is initialized
                album.CDs ??= [];

                // Create a dictionary of existing CDs for quick lookup
                var existingCDs = album.CDs.ToDictionary(cd => cd.Id);

                foreach (var cdDto in dto.CDs)
                {
                    if (cdDto.Id == 0)
                    {
                        // Add new CD
                        var newCD = new CD
                        {
                            Name = cdDto.Name,
                            Genre = cdDto.Genre,
                            Tracks = cdDto.Tracks?.Select(trackDto => new Track
                            {
                                Number = trackDto.Number,
                                Title = trackDto.Title,
                                Length = trackDto.Length
                            }).ToList() ?? []
                        };

                        album.CDs.Add(newCD);
                    }
                    else if (existingCDs.TryGetValue(cdDto.Id, out var existingCD))
                    {
                        // Update existing CD
                        existingCD.Name = cdDto.Name;
                        existingCD.Genre = cdDto.Genre;

                        // Update or add tracks
                        if (cdDto.Tracks != null)
                        {
                            // Ensure existingCD.Tracks is initialized
                            existingCD.Tracks ??= [];

                            // Create a dictionary of existing tracks for quick lookup
                            var existingTracks = existingCD.Tracks.ToDictionary(track => track.Id);

                            foreach (var trackDto in cdDto.Tracks)
                            {
                                if (trackDto.Id == 0)
                                {
                                    // Add new track
                                    var newTrack = new Track
                                    {
                                        Number = trackDto.Number,
                                        Title = trackDto.Title,
                                        Length = trackDto.Length
                                    };

                                    existingCD.Tracks.Add(newTrack);
                                }
                                else if (existingTracks.TryGetValue(trackDto.Id, out var existingTrack))
                                {
                                    // Update existing track
                                    existingTrack.Number = trackDto.Number;
                                    existingTrack.Title = trackDto.Title;
                                    existingTrack.Length = trackDto.Length;
                                }
                            }

                            // Remove tracks that are no longer in the DTO
                            var tracksToRemove = existingCD.Tracks
                                .Where(track => !cdDto.Tracks.Any(trackDto => trackDto.Id == track.Id))
                                .ToList();

                            foreach (var track in tracksToRemove)
                            {
                                existingCD.Tracks.Remove(track);
                            }
                        }
                    }
                }

                // Remove CDs that are no longer in the DTO
                var cdsToRemove = album.CDs
                    .Where(cd => !dto.CDs.Any(cdDto => cdDto.Id == cd.Id))
                    .ToList();

                foreach (var cd in cdsToRemove)
                {
                    album.CDs.Remove(cd);
                }
            }

            // Save changes to the database
            await _albumRepo.UpdateAsync(album);
        }
    }
}
