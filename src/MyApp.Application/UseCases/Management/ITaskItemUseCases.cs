using MyApp.Application.DTOs.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Application.DTOs.Management;

namespace MyApp.Application.UseCases.Management
{
    public interface ITaskItemUseCases
    {
        Task<List<TaskItemDto>?> GetAllTaskItemsAsync(SearchTaskItemDto dto);
        Task<TaskItemDto?> GetTaskItemByIdAsync(int id);
        Task CreateTaskItemAsync(CreateTaskItemDto dto);
        Task UpdateTaskItemAsync(int id, UpdateTaskItemDto dto);
        Task DeleteTaskItemAsync(DeleteTaskItemDto dto);
    }
}
