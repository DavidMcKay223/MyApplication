using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyApp.Application.DTOs.Management;
using MyApp.Domain.Entities.Management;
using MyApp.Domain.Enums.Management;
using MyApp.Domain.Exceptions;
using MyApp.Domain.Repositories.Management;

namespace MyApp.Application.UseCases.Management
{
    public class TaskItemUseCases : ITaskItemUseCases
    {
        private readonly ITaskItemRepository _taskItemRepo;
        private readonly IMapper _mapper;

        public TaskItemUseCases(ITaskItemRepository taskItemRepo, IMapper mapper)
        {
            _taskItemRepo = taskItemRepo;
            _mapper = mapper;
        }

        public async Task CreateTaskItemAsync(CreateTaskItemDto dto)
        {
            // Validate TaskSubType against TaskType
            if (!TaskTypeHelper.IsValidSubType(dto.TaskType, dto.TaskSubType))
            {
                throw new ValidationException("Invalid TaskSubType for the given TaskType.");
            }

            var taskItem = _mapper.Map<TaskItem>(dto);
            await _taskItemRepo.AddAsync(taskItem);
        }

        public async Task DeleteTaskItemAsync(DeleteTaskItemDto dto)
        {
            await _taskItemRepo.DeleteAsync(dto.ID);
        }

        public async Task<List<TaskItemDto>?> GetAllTaskItemsAsync(SearchTaskItemDto dto)
        {
            var query = _taskItemRepo.GetAllAsync();

            // Apply filters based on the SearchTaskItemDto
            if (!string.IsNullOrEmpty(dto.Title))
            {
                query = query.Where(t => t.Title.Contains(dto.Title));
            }

            if (!string.IsNullOrEmpty(dto.Description))
            {
                query = query.Where(t => t.Description.Contains(dto.Description));
            }

            if (dto.TaskType.HasValue)
            {
                query = query.Where(t => t.TaskType == dto.TaskType.Value);
            }

            if (dto.IsCompleted.HasValue)
            {
                query = query.Where(t => t.IsCompleted == dto.IsCompleted.Value);
            }

            // Apply sorting (default by CreatedDate descending)
            query = query.OrderByDescending(t => t.CreatedDate);

            // Pagination
            dto.TotalItems = await query.CountAsync();

            var pagedTaskItems = await query
                .Skip((dto.PageNumber) * dto.PageSize)
                .Take(dto.PageSize)
                .ToListAsync();

            return _mapper.Map<List<TaskItemDto>>(pagedTaskItems);
        }

        public async Task<TaskItemDto?> GetTaskItemByIdAsync(int id)
        {
            var taskItem = await _taskItemRepo.GetByIdAsync(id) ?? throw new NotFoundException("Task item not found");
            return _mapper.Map<TaskItemDto>(taskItem);
        }

        public async Task UpdateTaskItemAsync(int id, UpdateTaskItemDto dto)
        {
            var taskItem = await _taskItemRepo.GetByIdAsync(id) ?? throw new NotFoundException("Task item not found");

            _mapper.Map(dto, taskItem);
            await _taskItemRepo.UpdateAsync(taskItem);
        }
    }
}
