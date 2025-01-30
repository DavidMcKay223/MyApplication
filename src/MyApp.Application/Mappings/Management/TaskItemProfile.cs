using AutoMapper;
using AutoMapper.Configuration;
using MyApp.Application.DTOs.Management;
using MyApp.Domain.Entities.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Mappings.Management
{
    public class TaskItemProfile : Profile
    {
        public TaskItemProfile()
        {
            // Map TaskItem to TaskItemDto
            CreateMap<TaskItem, TaskItemDto>();

            // Map CreateTaskItemDto to TaskItem
            CreateMap<CreateTaskItemDto, TaskItem>();

            // Map UpdateTaskItemDto to TaskItem (only editable fields)
            CreateMap<UpdateTaskItemDto, TaskItem>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.IsCompleted, opt => opt.MapFrom(src => src.IsCompleted))
                .ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(_ => DateTime.UtcNow)) // Automatically set UpdatedDate
                .ForMember(dest => dest.ID, opt => opt.Ignore()) // Ignore ID
                .ForMember(dest => dest.TaskType, opt => opt.Ignore()) // Ignore TaskType
                .ForMember(dest => dest.TaskSubType, opt => opt.Ignore()) // Ignore TaskSubType
                .ForMember(dest => dest.TaskObjectType, opt => opt.Ignore()) // Ignore TaskObjectType
                .ForMember(dest => dest.TaskObjectId, opt => opt.Ignore()) // Ignore TaskObjectId
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore()); // Ignore CreatedDate
        }
    }
}
