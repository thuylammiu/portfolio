using Portfolio.Core.Entities;

namespace Portfolio.Api.Dtos
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;
        public string VideoLink { get; set; } = string.Empty;

        public DateOnly FromDate { get; set; }
        public DateOnly ToDate { get; set; }

        public string FromdateString => this.FromDate.ToString(("MM.yyyy"));
        public string TodateString => this.ToDate.ToString(("MM.yyyy"));
        
    }
}
