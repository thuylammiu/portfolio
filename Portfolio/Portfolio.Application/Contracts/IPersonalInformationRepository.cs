using Portfolio.Core.Entities;
using Portfolio.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Contracts
{
    public interface IPersonalInformationRepository : IRepository<PersonalInformation>
    {
    }
}
