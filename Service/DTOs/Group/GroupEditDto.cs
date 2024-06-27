using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Group
{
    public class GroupEditDto
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }
    }

    public class GroupEditDtoValidator: AbstractValidator<GroupEditDto>
    {
        public GroupEditDtoValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
            RuleFor(m => m.Capacity).NotEmpty().GreaterThan(0);

        }
    }
}
