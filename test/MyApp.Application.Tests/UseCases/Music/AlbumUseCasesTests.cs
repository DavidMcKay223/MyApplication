using AutoMapper;
using Microsoft.Extensions.Logging;
using Moq;
using MockQueryable.Moq;
using MyApp.Application.DTOs.Music;
using MyApp.Application.UseCases.Music;
using MyApp.Domain.Entities.Music;
using MyApp.Domain.Exceptions;
using MyApp.Domain.Repositories.Music;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Application.Configurations;
using MockQueryable;
using MyApp.Application.Mappings.Music;

namespace MyApp.Application.Tests.UseCases.Music
{
    public class AlbumUseCasesTests
    {
        private readonly Mock<IAlbumRepository> _mockRepo;
        private readonly IMapper _mapper;
        private readonly Mock<ILogger<AlbumUseCases>> _mockLogger;
        private readonly AlbumUseCases _albumUseCases;

        public AlbumUseCasesTests()
        {
            _mockRepo = new Mock<IAlbumRepository>();

            // Initialize AutoMapper with your profiles
            var config = new MapperConfiguration(cfg =>
            {
                // Add your mapping profiles here
                cfg.AddProfile<AlbumProfile>();
                cfg.AddProfile<CDProfile>();
                cfg.AddProfile<TrackProfile>();
            });
            _mapper = config.CreateMapper();

            _mockLogger = new Mock<ILogger<AlbumUseCases>>();
            _albumUseCases = new AlbumUseCases(_mockRepo.Object, _mapper, _mockLogger.Object);
        }

        [Fact]
        public async Task UpdateAlbumAsync_WhenDtoIdMismatch_ThrowsBadRequest()
        {
            // Arrange
            var dto = new UpdateAlbumDto { ID = 999, ArtistName = "Some Artist" }; // ID different from route ID
            _mockRepo.Setup(r => r.GetByIdAsync(123)).ReturnsAsync(new Album { ID = 123, ArtistName = "Some Artist" });

            // Act & Assert
            await Assert.ThrowsAsync<BadRequestException>(() =>
                _albumUseCases.UpdateAlbumAsync(123, dto)
            );
        }

        [Fact]
        public async Task UpdateAlbumAsync_WhenAlbumNotFound_ThrowsNotFound()
        {
            // Arrange
            _mockRepo.Setup(r => r.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Album)null);

            // Act & Assert
            await Assert.ThrowsAsync<NotFoundException>(() =>
                _albumUseCases.UpdateAlbumAsync(123, new UpdateAlbumDto { ArtistName = "Some Artist" })
            );
        }

        [Fact]
        public async Task UpdateAlbumAsync_AddsNewCDs()
        {
            // Arrange
            var existingAlbum = new Album { CDs = new List<CD>(), ArtistName = "Some Artist" };
            var newCdDto = new UpdateCDDto { ID = 0, Name = "New CD" };
            var dto = new UpdateAlbumDto { CDs = new List<UpdateCDDto> { newCdDto }, ArtistName = "Some Artist" };

            _mockRepo.Setup(r => r.GetByIdAsync(123)).ReturnsAsync(existingAlbum);

            // Act
            await _albumUseCases.UpdateAlbumAsync(123, dto);

            // Assert
            Assert.Single(existingAlbum.CDs); // Ensure CD was added
            Assert.Equal("New CD", existingAlbum.CDs.First().Name); // Ensure correct CD was added
            _mockRepo.Verify(r => r.UpdateAsync(existingAlbum), Times.Once);
        }

        [Fact]
        public async Task UpdateAlbumAsync_RemovesMissingCDs()
        {
            // Arrange
            var existingCd = new CD { ID = 1, Name = "Old CD" };
            var existingAlbum = new Album { CDs = new List<CD> { existingCd }, ArtistName = "Some Artist" };
            var dto = new UpdateAlbumDto { CDs = new List<UpdateCDDto>(), ArtistName = "Some Artist" }; // No CDs in DTO

            _mockRepo.Setup(r => r.GetByIdAsync(123)).ReturnsAsync(existingAlbum);

            // Act
            await _albumUseCases.UpdateAlbumAsync(123, dto);

            // Assert
            Assert.Empty(existingAlbum.CDs); // CD was removed
        }

        [Fact]
        public async Task GetAllAlbumsAsync_AppliesArtistNameFilter()
        {
            // Arrange
            var albums = new List<Album>
            {
                new Album { ArtistName = "Artist1", CDs = new List<CD>() },
                new Album { ArtistName = "Artist2", CDs = new List<CD>() }
            }.AsQueryable().BuildMock();

            _mockRepo.Setup(r => r.GetAllAsync()).Returns(albums);
            var searchDto = new SearchAlbumDto { ArtistName = "Artist1" };

            // Act
            var result = await _albumUseCases.GetAllAlbumsAsync(searchDto);

            // Assert
            Assert.Single(result ?? []); // Only one album matches
            Assert.Equal("Artist1", result[0].ArtistName);
        }

        [Fact]
        public async Task CreateAlbumAsync_CallsAddOnRepository()
        {
            // Arrange
            var dto = new CreateAlbumDto { ArtistName = "Some Artist" };
            var album = _mapper.Map<Album>(dto);
            _mockRepo.Setup(r => r.AddAsync(It.IsAny<Album>())).Returns(Task.CompletedTask);

            // Act
            await _albumUseCases.CreateAlbumAsync(dto);

            // Assert
            _mockRepo.Verify(r => r.AddAsync(It.Is<Album>(a => a.ArtistName == "Some Artist")), Times.Once);
        }

        [Fact]
        public async Task GetAlbumByIdAsync_WhenAlbumExists_ReturnsMappedDto()
        {
            // Arrange
            var album = new Album { ArtistName = "Some Artist" };
            _mockRepo.Setup(r => r.GetByIdAsync(123)).ReturnsAsync(album);

            // Act
            var result = await _albumUseCases.GetAlbumByIdAsync(123);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Some Artist", result.ArtistName);
        }

        [Fact]
        public async Task GetAlbumByIdAsync_WhenAlbumMissing_ThrowsNotFound()
        {
            // Arrange
            _mockRepo.Setup(r => r.GetByIdAsync(123)).ReturnsAsync((Album)null);

            // Act & Assert
            await Assert.ThrowsAsync<NotFoundException>(() =>
                _albumUseCases.GetAlbumByIdAsync(123)
            );
        }

        [Fact]
        public async Task DeleteAlbumAsync_CallsDeleteOnRepository()
        {
            // Arrange
            var dto = new DeleteAlbumDto { ID = 123 };

            // Act
            await _albumUseCases.DeleteAlbumAsync(dto);

            // Assert
            _mockRepo.Verify(r => r.DeleteAsync(123), Times.Once);
        }

        [Fact]
        public async Task GetAllAlbumsAsync_AppliesMultipleFilters()
        {
            // Arrange
            var albums = new List<Album>
            {
                new Album
                {
                    ArtistName = "Artist1",
                    CDs = new List<CD>
                    {
                        new CD
                        {
                            Name = "CD1",
                            Tracks = new List<Track>
                            {
                                new Track { Title = "Track1" }
                            }
                        }
                    }
                },
                new Album
                {
                    ArtistName = "Artist2",
                    CDs = new List<CD>
                    {
                        new CD
                        {
                            Name = "CD2",
                            Tracks = new List<Track>
                            {
                                new Track { Title = "Track2" }
                            }
                        }
                    }
                }
            }.AsQueryable().BuildMock();

            _mockRepo.Setup(r => r.GetAllAsync()).Returns(albums);
            var searchDto = new SearchAlbumDto { ArtistName = "Artist1", CdName = "CD1", TrackTitle = "Track1" };

            // Act
            var result = await _albumUseCases.GetAllAlbumsAsync(searchDto);

            // Assert
            Assert.Single(result); // Only one album matches
            Assert.Equal("Artist1", result[0].ArtistName);
        }

        [Fact]
        public async Task UpdateAlbumAsync_UpdatesExistingCDs()
        {
            // Arrange
            var existingCd = new CD { ID = 1, Name = "Old CD" };
            var existingAlbum = new Album { CDs = new List<CD> { existingCd }, ArtistName = "Some Artist" };
            var updateCdDto = new UpdateCDDto { ID = 1, Name = "Updated CD" };
            var dto = new UpdateAlbumDto { CDs = new List<UpdateCDDto> { updateCdDto }, ArtistName = "Some Artist" };

            _mockRepo.Setup(r => r.GetByIdAsync(123)).ReturnsAsync(existingAlbum);

            // Act
            await _albumUseCases.UpdateAlbumAsync(123, dto);

            // Assert
            Assert.Equal("Updated CD", existingAlbum.CDs.First().Name); // Ensure CD was updated
            _mockRepo.Verify(r => r.UpdateAsync(existingAlbum), Times.Once);
        }
    }
}
