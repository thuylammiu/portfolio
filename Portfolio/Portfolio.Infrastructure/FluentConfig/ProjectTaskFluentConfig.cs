using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Infrastructure.FluentConfig
{
    public class ProjectTaskFluentConfig : IEntityTypeConfiguration<ProjectTask>
    {
        public void Configure(EntityTypeBuilder<ProjectTask> modelBuilder)
        {

            modelBuilder.HasKey(b => b.Id);
            modelBuilder.Property(b => b.Task).IsRequired().HasMaxLength(500);
            modelBuilder.Property(b => b.TechnicalUsage).HasMaxLength(300);



        }
    }
}
