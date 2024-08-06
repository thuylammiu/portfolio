using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Infrastructure.FluentConfig
{
    public class EducationFluentConfig : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> modelBuilder)
        {
            modelBuilder.HasKey(b => b.Id);
            modelBuilder.Property(b => b.SchoolName).IsRequired().HasMaxLength(100);
            modelBuilder.Property(b => b.Address).HasMaxLength(150);
            modelBuilder.Property(b => b.VideoLink).HasMaxLength(200);
            modelBuilder.Property(b => b.Major).HasMaxLength(100);
            modelBuilder.Property(b => b.ImageName).HasMaxLength(50);
        }    
    }
}
