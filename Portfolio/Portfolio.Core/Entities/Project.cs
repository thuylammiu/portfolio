using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Entities
{
    public class Project: BaseEntity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public int Size { get; set; }

        public string Position { get; set; }
        public string Description {get; set; }
        public string TechniCalStack { get; set; }
        public string CompanyCode { get; set; }
        ICollection<ProjectTask> ProjectTasks { get; set; }

       // public Company Company { get; set; }

        public string GitLink { get; set; }

        public string WebSite { get; set; }

    }
}
