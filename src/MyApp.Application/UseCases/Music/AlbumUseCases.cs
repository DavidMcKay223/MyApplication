﻿using MyApp.Application.DTOs.Music;
using MyApp.Domain.Entities.Music;
using MyApp.Domain.Exceptions;
using MyApp.Domain.Repositories.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Music
{
    public class AlbumUseCases : IAlbumUseCases
    {
        private readonly IAlbumRepository _albumRepo;

        public AlbumUseCases(IAlbumRepository albumRepo) => _albumRepo = albumRepo;

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
                Artist = dto.Artist,
                //CDs = dto.CDs.Select(cd => new CD
                //{
                //    Name = cd.Name,
                //    Genre = cd.Genre,
                //    Tracks = cd.Tracks.Select(t => new Track
                //    {
                //        Number = t.Number,
                //        Title = t.Title,
                //        Length = t.Length
                //    }).ToList()
                //}).ToList()
            };

            await _albumRepo.AddAsync(album);
        }

        public async Task DeleteAlbumAsync(int id) => await _albumRepo.DeleteAsync(id);

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
