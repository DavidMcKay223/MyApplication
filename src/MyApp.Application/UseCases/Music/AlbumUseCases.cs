using AutoMapper;
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
        private readonly IMapper _mapper;

        public AlbumUseCases(IAlbumRepository albumRepo, IMapper mapper)
        {
            _albumRepo = albumRepo;
            _mapper = mapper;
        }

        public async Task<AlbumDto?> GetAlbumAsync(int id)
        {
            var album = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");
            return _mapper.Map<AlbumDto>(album);
        }

        public async Task<List<AlbumDto>?> GetAllAlbumsAsync(SearchAlbumDto dto)
        {
            var query = _albumRepo.GetAllAsync();

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

            query = dto.SortBy switch
            {
                AlbumSortBy.CdName => dto.SortOrder == AlbumSortOrder.Asc
                                        ? query.OrderBy(a => a.CDs.First().Name)
                                        : query.OrderByDescending(a => a.CDs.First().Name),
                AlbumSortBy.Artist => dto.SortOrder == AlbumSortOrder.Asc
                                        ? query.OrderBy(a => a.ArtistName)
                                        : query.OrderByDescending(a => a.ArtistName),
                _ => dto.SortOrder == AlbumSortOrder.Asc
                                        ? query.OrderBy(a => a.ArtistName)
                                        : query.OrderByDescending(a => a.ArtistName),
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
            var album = _mapper.Map<Album>(dto);
            await _albumRepo.AddAsync(album);
        }

        public async Task DeleteAlbumAsync(DeleteAlbumDto dto)
        {
            await _albumRepo.DeleteAsync(dto.ID);
        }

        public async Task<AlbumDto?> GetAlbumByIdAsync(int id)
        {
            var album = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");
            return _mapper.Map<AlbumDto>(album);
        }

        public async Task UpdateAlbumAsync(int id, UpdateAlbumDto dto)
        {
            var album = await _albumRepo.GetByIdAsync(id) ?? throw new NotFoundException("Album not found");
            _mapper.Map(dto, album);
            await _albumRepo.UpdateAsync(album);
        }
    }
}
