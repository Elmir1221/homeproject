using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Group
{
    public class GroupCreateDto
    {
        public int Capacity { get; set; }
        public string Name { get; set; }

    }

    public class GroupCreateDtoValidator :AbstractValidator<GroupCreateDto>
    {
        public GroupCreateDtoValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
            RuleFor(m => m.Capacity).NotEmpty().GreaterThan(1);
        }
    }
    
}
