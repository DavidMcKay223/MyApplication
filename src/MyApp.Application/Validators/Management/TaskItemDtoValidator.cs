using FluentValidation;
using MyApp.Application.DTOs.Management;
using MyApp.Domain.Entities.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Validators.Management
{
    public class TaskItemDtoValidator : AbstractValidator<TaskItemDto>
    {
        public TaskItemDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required.")
                .MaximumLength(500).WithMessage("Title must be less than 500 characters.");
            
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required.")
                .MaximumLength(5000).WithMessage("Description must be less than 500 characters.");

            RuleFor(x => x.TaskSubType)
                .Must((dto, taskSubType) => TaskTypeHelper.IsValidSubType(dto.TaskType, taskSubType))
                .WithMessage("Invalid Task SubType for the selected Task Type.");
        }
    }
}
