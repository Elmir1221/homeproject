using Service.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IStudentServicse
    {
        Task CreateAsync(StudentCreateDto request);
        Task DeleteAsync(int? id);
        Task EditAsync(StudentEditDto request);
        Task<IEnumerable<StudentDto>> GetAllAsync();
    }
}
