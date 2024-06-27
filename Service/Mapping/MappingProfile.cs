using AutoMapper;
using Domain.Entity;
using Service.DTOs.Group;
using Service.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentCreateDto, Student>();
            CreateMap<StudentEditDto, Student>();

            CreateMap<Group, GroupDto>();
            CreateMap<GroupCreateDto, Group>();
            CreateMap<GroupEditDto, Group>();
        }
    }
}
