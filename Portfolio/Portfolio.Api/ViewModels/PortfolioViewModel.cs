using Portfolio.Api.Dtos;

namespace Portfolio.Api.ViewModels
{
    public class PortfolioViewModel
    {
        public List<CompanyDto> Companys { get; set; }
        public List<SkillDto> Skills { get; set; }
        public PersonalInformationDto PersonalInfo { get; set; }

        public List<EducationDto>  Educations { get; set; }


        public List<ProjectDto> Projects { get; set; }

        public List<ProjectTaskDto> ProjectTasks { get; set; }
    }
}

