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
    public class CompanyFluentConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> modelBuilder)
        {

            modelBuilder.HasKey(b => b.Id);
            modelBuilder.Property(b => b.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Property(b => b.Address).HasMaxLength(150);
           



        }
    
    }
}
