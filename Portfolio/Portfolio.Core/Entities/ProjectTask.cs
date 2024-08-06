using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Entities
{
    public class ProjectTask: BaseEntity
    {
        public string Task { get; set; } = string.Empty;
        public string TechnicalUsage { get; set; } = string.Empty;

        public string ProjectCode { get; set; }
       // public Project Project { get; set; }
    }
}
