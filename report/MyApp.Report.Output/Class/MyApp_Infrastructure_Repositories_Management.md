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

| Name | Signature |
|------|-----------|
| `AddAsync` | `public Task AddAsync(TaskItem TaskItem)` |
| `UpdateAsync` | `public Task UpdateAsync(TaskItem TaskItem)` |
| `DeleteAsync` | `public Task DeleteAsync(int id)` |
| `GetByIdAsync` | `public Task<TaskItem?> GetByIdAsync(int id)` |
| `GetAllAsync` | `public IQueryable<TaskItem> GetAllAsync()` |

#### Method: `AddAsync`

```csharp
public async Task AddAsync(TaskItem TaskItem)
        {
            await _context.TaskItems.AddAsync(TaskItem);
            await _context.SaveChangesAsync();
        }
```

#### Method: `UpdateAsync`

```csharp
public async Task UpdateAsync(TaskItem TaskItem)
        {
            _context.TaskItems.Update(TaskItem);
            await _context.SaveChangesAsync();
        }
```

#### Method: `DeleteAsync`

```csharp
public async Task DeleteAsync(int id)
        {
            var TaskItem = await GetByIdAsync(id);
            if (TaskItem != null)
            {
                _context.TaskItems.Remove(TaskItem);
                await _context.SaveChangesAsync();
            }
        }
```

#### Method: `GetByIdAsync`

```csharp
public async Task<TaskItem?> GetByIdAsync(int id)
        {
            return await _context.TaskItems
                .FirstOrDefaultAsync(a => a.ID == id);
        }
```

#### Method: `GetAllAsync`

```csharp
public IQueryable<TaskItem> GetAllAsync()
        {
            return _context.TaskItems
                .AsQueryable();
        }
```

