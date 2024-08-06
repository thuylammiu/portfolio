using Portfolio.Application.Contracts;
using Portfolio.Core.Entities;
using Portfolio.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Services
{
    public class PersonalInformationRepository : Repository<PersonalInformation>, IPersonalInformationRepository
    {
        public PersonalInformationRepository(PorfolioDbContext portfolioDbContext) : base(portfolioDbContext)
        {
        }
    }
}
