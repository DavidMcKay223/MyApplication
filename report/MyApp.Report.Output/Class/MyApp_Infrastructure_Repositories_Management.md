# Namespace: `MyApp.Infrastructure.Repositories.Management`

## Class: `TaskItemRepository`

- **File Path:** `MyApp.Infrastructure/Repositories/Management/TaskItemRepository.cs`
- **Inherits From:** `ITaskItemRepository`

### Class Code

```csharp
public class TaskItemRepository : ITaskItemRepository
    {
        private readonly AppDbContext _context;
        public TaskItemRepository(AppDbContext context) => _context = context;

        public async Task AddAsync(TaskItem TaskItem)
        {
            await _context.TaskItems.AddAsync(TaskItem);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TaskItem TaskItem)
        {
            _context.TaskItems.Update(TaskItem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var TaskItem = await GetByIdAsync(id);
            if (TaskItem != null)
            {
                _context.TaskItems.Remove(TaskItem);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<TaskItem?> GetByIdAsync(int id)
        {
            return await _context.TaskItems
                .FirstOrDefaultAsync(a => a.ID == id);
        }

        public IQueryable<TaskItem> GetAllAsync()
        {
            return _context.TaskItems
                .AsQueryable();
        }
    }
```

### Methods

| Name | Signature | Definition |
|------|-----------|-------------|
| `AddAsync` | `public Task AddAsync(TaskItem TaskItem)` | `public async Task AddAsync(TaskItem TaskItem)<br>        {<br>            await _context.TaskItems.AddAsync(TaskItem);<br>            await _context.SaveChangesAsync();<br>        }` |
| `UpdateAsync` | `public Task UpdateAsync(TaskItem TaskItem)` | `public async Task UpdateAsync(TaskItem TaskItem)<br>        {<br>            _context.TaskItems.Update(TaskItem);<br>            await _context.SaveChangesAsync();<br>        }` |
| `DeleteAsync` | `public Task DeleteAsync(int id)` | `public async Task DeleteAsync(int id)<br>        {<br>            var TaskItem = await GetByIdAsync(id);<br>            if (TaskItem != null)<br>            {<br>                _context.TaskItems.Remove(TaskItem);<br>                await _context.SaveChangesAsync();<br>            }<br>        }` |
| `GetByIdAsync` | `public Task<TaskItem?> GetByIdAsync(int id)` | `public async Task<TaskItem?> GetByIdAsync(int id)<br>        {<br>            return await _context.TaskItems<br>                .FirstOrDefaultAsync(a => a.ID == id);<br>        }` |
| `GetAllAsync` | `public IQueryable<TaskItem> GetAllAsync()` | `public IQueryable<TaskItem> GetAllAsync()<br>        {<br>            return _context.TaskItems<br>                .AsQueryable();<br>        }` |

