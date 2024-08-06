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
    public class ProjectFluentConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> modelBuilder)
        {
            modelBuilder.HasKey(b => b.Id);
            modelBuilder.Property(b => b.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Property(b => b.Description).HasMaxLength(3000);
            modelBuilder.Property(b => b.TechniCalStack).HasMaxLength(3000);
            modelBuilder.Property(b => b.GitLink).HasMaxLength(300);
            modelBuilder.Property(b => b.WebSite).HasMaxLength(100);
        }
    
    }
}
