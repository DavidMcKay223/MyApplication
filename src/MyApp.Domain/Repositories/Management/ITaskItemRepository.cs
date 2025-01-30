using MyApp.Domain.Entities.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Repositories.Management
{
    public interface ITaskItemRepository
    {
        Task<TaskItem?> GetByIdAsync(int id);
        IQueryable<TaskItem> GetAllAsync();
        Task AddAsync(TaskItem TaskItem);
        Task UpdateAsync(TaskItem TaskItem);
        Task DeleteAsync(int id);
    }
}
