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
    public class SkillFluentConfig: IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> modelBuilder)
        {

            modelBuilder.HasKey(b => b.Id);
            modelBuilder.Property(b => b.Name).IsRequired().HasMaxLength(100);         




        }
    
    }
}
