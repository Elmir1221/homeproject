using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entity
{
    public class Group : BaseEntity
    {
        public int Capacity { get; set; }
        public string Name { get; set; }
        public List<StudentGroup> StudentGroups { get; set; }
    }
}
