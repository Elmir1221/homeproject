using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations
{
    public class StudentCofiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(m => m.Name).IsRequired();
            builder.Property(m => m.Surname ).IsRequired();
            builder.Property(m => m.Adress).IsRequired();
            builder.Property(m => m.Email).IsRequired();
            builder.Property(m => m.Age).IsRequired();
        }
    }
}
