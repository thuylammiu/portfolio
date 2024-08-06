using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Entities
{
    public class Company: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public string Code {  get; set; } = string.Empty;
        public string VideoLink { get; set; } = string.Empty;

        public DateOnly FromDate { get; set; }
        public DateOnly ToDate { get; set; }

        ICollection<Project> Projects { get; set; }
    }
}
