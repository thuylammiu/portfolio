using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Api.Dtos;
using Portfolio.Api.ViewModels;
using Portfolio.Application.Contracts;
using Portfolio.Core.Entities;
using System.ComponentModel;

namespace Portfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IPersonalInformationRepository personalInformationRepository;
        private readonly IEducationRepository educationRepository;
        private readonly IProjectRepository projectRepository;
        private readonly IProjectTaskRepository projectTaskRepository;

        public PortfolioController(ICompanyRepository companyRepository, 
                                    IPersonalInformationRepository personalInformationRepository,
                                    IEducationRepository educationRepository,
                                    IProjectRepository projectRepository,
                                    IProjectTaskRepository projectTaskRepository)                                   
            
        {
            this.companyRepository = companyRepository;
            this.personalInformationRepository = personalInformationRepository;
            this.educationRepository = educationRepository;
            this.projectRepository = projectRepository;
            this.projectTaskRepository = projectTaskRepository;
        }


        [HttpGet(nameof(GetAll))]
        public async Task<ActionResult<PortfolioViewModel>> GetAll()
        {
            var result = new PortfolioViewModel();
            var company = await companyRepository.GetAllAsync();
            result.Companys = company.Adapt<List<CompanyDto>>();

            var education = await educationRepository.GetAllAsync();
            result.Educations = education.Adapt<List<EducationDto>>();

            var info = await personalInformationRepository.GetAsync();
            result.PersonalInfo = info.Adapt<PersonalInformationDto>();


            var projects = await projectRepository.GetAllAsync();
            result.Projects = projects.Adapt<List<ProjectDto>>();

            var projectTasks = await projectTaskRepository.GetAllAsync();
            result.ProjectTasks = projectTasks.Adapt<List<ProjectTaskDto>>();

            List<SkillDto> skills = new List<SkillDto>
            {
                new SkillDto { Percentage = "90%", Skill = "C#" },
                new SkillDto { Percentage = "80%", Skill = "JavaScript" },
                new SkillDto { Percentage = "70%", Skill = "HTML/CSS" },
                // Add more items as needed
            };
            result.Skills = skills;
            return result;

        }
       

        [HttpGet(nameof(GetCompany))]
        public async Task<ActionResult<CompanyDto>> GetCompany()
        {
            var result = await companyRepository.GetAsync();
            return result.Adapt<CompanyDto>();         

        }

        [HttpGet(nameof(GetEducations))]
        public async Task<List<EducationDto>> GetEducations()
        {
            var result = await educationRepository.GetAllAsync();
            return result.Adapt<List<EducationDto>>();
        }
        
        [HttpGet(nameof(GetPersonalInformation))]
        public async Task<PersonalInformationDto> GetPersonalInformation()
        {
            var result = await personalInformationRepository.GetAllAsync();
            return result.Adapt<PersonalInformationDto>();
        }

        [HttpGet(nameof(GetProjects))]
        public async Task<List<ProjectDto>> GetProjects()
        {
            var result = await projectRepository.GetAllAsync();
            return result.Adapt<List<ProjectDto>>();
        }

        [HttpGet(nameof(GetProjectTasks))]
        public async Task<List<ProjectTaskDto>> GetProjectTasks()
        {
            var result = await projectTaskRepository.GetAllAsync();
            return result.Adapt<List<ProjectTaskDto>>();
        }
    }
}
