using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Entities
{
    public class Education : BaseEntity
    {
        public string SchoolName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string WebSite { get; set; } = string.Empty;
        public string CertificateType { get; set; } = string.Empty;
        public string VideoLink { get; set; } = string.Empty;
        public string Major { get; set; } = string.Empty;
        public string ImageName { get; set; } = string.Empty;



    }
}
