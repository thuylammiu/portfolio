using Portfolio.Core.Entities;

namespace Portfolio.Api.Dtos
{
    public class ProjectTaskDto
    {
        public string Task { get; set; } = string.Empty;
        public string TechnicalUsage { get; set; } = string.Empty;

        public string ProjectCode { get; set; }
        // public Project Project { get; set; }
    }
}
