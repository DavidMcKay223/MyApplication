# Namespace: `MyApp.Application.UseCases.Management`

## Class: `TaskItemUseCases`

- **File Path:** `MyApp.Application/UseCases/Management/TaskItemUseCases.cs`
- **Inherits From:** `ITaskItemUseCases`

### Class Code

```csharp
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
```

### Methods

| Name | Signature | Definition |
|------|-----------|-------------|
| `CreateTaskItemAsync` | `public Task CreateTaskItemAsync(CreateTaskItemDto dto)` | `public async Task CreateTaskItemAsync(CreateTaskItemDto dto)<br>        {<br>            // Validate TaskSubType against TaskType<br>            if (!TaskTypeHelper.IsValidSubType(dto.TaskType, dto.TaskSubType))<br>            {<br>                throw new ValidationException("Invalid TaskSubType for the given TaskType.");<br>            }<br><br>            var taskItem = _mapper.Map<TaskItem>(dto);<br>            await _taskItemRepo.AddAsync(taskItem);<br>        }` |
| `DeleteTaskItemAsync` | `public Task DeleteTaskItemAsync(DeleteTaskItemDto dto)` | `public async Task DeleteTaskItemAsync(DeleteTaskItemDto dto)<br>        {<br>            await _taskItemRepo.DeleteAsync(dto.ID);<br>        }` |
| `GetAllTaskItemsAsync` | `public Task<List<TaskItemDto>?> GetAllTaskItemsAsync(SearchTaskItemDto dto)` | `public async Task<List<TaskItemDto>?> GetAllTaskItemsAsync(SearchTaskItemDto dto)<br>        {<br>            var query = _taskItemRepo.GetAllAsync();<br><br>            // Apply filters based on the SearchTaskItemDto<br>            if (!string.IsNullOrEmpty(dto.Title))<br>            {<br>                query = query.Where(t => t.Title.Contains(dto.Title));<br>            }<br><br>            if (!string.IsNullOrEmpty(dto.Description))<br>            {<br>                query = query.Where(t => t.Description.Contains(dto.Description));<br>            }<br><br>            if (dto.TaskType.HasValue)<br>            {<br>                query = query.Where(t => t.TaskType == dto.TaskType.Value);<br>            }<br><br>            if (dto.IsCompleted.HasValue)<br>            {<br>                query = query.Where(t => t.IsCompleted == dto.IsCompleted.Value);<br>            }<br><br>            // Apply sorting (default by CreatedDate descending)<br>            query = query.OrderByDescending(t => t.CreatedDate);<br><br>            // Pagination<br>            dto.TotalItems = await query.CountAsync();<br><br>            var pagedTaskItems = await query<br>                .Skip((dto.PageNumber) * dto.PageSize)<br>                .Take(dto.PageSize)<br>                .ToListAsync();<br><br>            return _mapper.Map<List<TaskItemDto>>(pagedTaskItems);<br>        }` |
| `GetTaskItemByIdAsync` | `public Task<TaskItemDto?> GetTaskItemByIdAsync(int id)` | `public async Task<TaskItemDto?> GetTaskItemByIdAsync(int id)<br>        {<br>            var taskItem = await _taskItemRepo.GetByIdAsync(id) ?? throw new NotFoundException("Task item not found");<br>            return _mapper.Map<TaskItemDto>(taskItem);<br>        }` |
| `UpdateTaskItemAsync` | `public Task UpdateTaskItemAsync(int id, UpdateTaskItemDto dto)` | `public async Task UpdateTaskItemAsync(int id, UpdateTaskItemDto dto)<br>        {<br>            var taskItem = await _taskItemRepo.GetByIdAsync(id) ?? throw new NotFoundException("Task item not found");<br><br>            _mapper.Map(dto, taskItem);<br>            await _taskItemRepo.UpdateAsync(taskItem);<br>        }` |

