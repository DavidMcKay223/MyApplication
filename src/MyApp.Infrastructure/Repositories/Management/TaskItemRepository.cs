using Microsoft.EntityFrameworkCore;
using MyApp.Domain.Entities.Management;
using MyApp.Domain.Repositories.Management;
using MyApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Repositories.Management
{
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
}
