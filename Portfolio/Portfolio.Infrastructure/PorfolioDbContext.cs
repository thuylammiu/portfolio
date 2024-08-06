using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Infrastructure.FluentConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Infrastructure
{
    public class PorfolioDbContext : DbContext
    {
        public PorfolioDbContext(DbContextOptions<PorfolioDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Education> Educations { get; set; }

        public DbSet<PersonalInformation> PersonalInformations { get;set;}

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectTask> ProjectTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //we configure fluent API

            //category table name and column name         

            modelBuilder.ApplyConfiguration(new CompanyFluentConfig());
            modelBuilder.ApplyConfiguration(new EducationFluentConfig());
            modelBuilder.ApplyConfiguration(new PersonalInformationFluentConfig());
            modelBuilder.ApplyConfiguration(new ProjectFluentConfig());
            modelBuilder.ApplyConfiguration(new ProjectTaskFluentConfig());
            modelBuilder.ApplyConfiguration(new SkillFluentConfig());
        }
    }
}
