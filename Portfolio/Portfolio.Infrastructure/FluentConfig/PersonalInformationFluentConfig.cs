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
    public class PersonalInformationFluentConfig : IEntityTypeConfiguration<PersonalInformation>
    {
        public void Configure(EntityTypeBuilder<PersonalInformation> modelBuilder)
        {
            modelBuilder.HasKey(b => b.Id);
            modelBuilder.Property(b => b.FirstName).IsRequired().HasMaxLength(100);
            modelBuilder.Property(b => b.LastName).HasMaxLength(150);
            modelBuilder.Property(b => b.Address).HasMaxLength(200);
            modelBuilder.Property(b => b.City).HasMaxLength(50);
            modelBuilder.Property(b => b.PostalCode).HasMaxLength(50);
            modelBuilder.Property(b => b.GitLink).HasMaxLength(50);
            modelBuilder.Property(b => b.Country).HasMaxLength(50);
            modelBuilder.Property(b => b.Hobby).HasMaxLength(100);
            modelBuilder.Property(b => b.LinkinId).HasMaxLength(100);
            modelBuilder.Property(b => b.Phone).HasMaxLength(20);
            modelBuilder.Property(b => b.Region).HasMaxLength(100);
            
        }  
    
    }
}
