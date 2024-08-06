using Portfolio.Core.Entities;

namespace Portfolio.Api.Dtos
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Code { get; set; }

        public int Size { get; set; }

        public string Position { get; set; }
        public string Description { get; set; }
        public string TechniCalStack { get; set; }
        public string CompanyCode { get; set; }
       // ICollection<ProjectTask> ProjectTasks { get; set; }

      //  public Company Company { get; set; }

        public string GitLink { get; set; }

        public string WebSite { get; set; }
    }
}
