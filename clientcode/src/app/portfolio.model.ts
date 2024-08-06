export interface CompanyDto {
    id: number;
    name: string;
    address: string;
    code: string;
    videoLink: string;
    fromDate: Date;
    toDate: Date;
    fromdateString:string;
    todateString:string;
    projects: ProjectDto[];
  }
  
  export interface EducationDto {
    schoolName: string;
    address: string;
    videoLink: string;
    website: string;
    certificateType : string;
    major: string;
    imageName: string;
  }  
 
  export interface PersonalInformationDto {
    firstName: string;
    lastName: string;
    email: string;
    phone: string;
    hobby: string;
    address: string;
    city: string;
    region: string;
    postalCode: string;
    country: string;
    linkinId: string;
    gitLink: string;
  }
  
  export interface ProjectDto {
    name: string;
    description: string;
    techniCalStack: string;
    projectTasks: ProjectTaskDto[];
    gitlink:string;
    website:string; 
    code:string; 
    companyCode: string;
    position:string;
  }
  
  export interface ProjectTaskDto {
    task: string;
    technicalUsage: string;
    projectCode: string;
    project: ProjectDto;
  }
  
  export interface SkillDto {
    percentage: string;
    skill: string;
  }
  
  export interface PortfolioViewModel {
    companys: CompanyDto[];
    skills: SkillDto[];
    personalInfo: PersonalInformationDto;
    educations: EducationDto[];
    projects: ProjectDto[];
    projectTasks: ProjectTaskDto[];
  }
  