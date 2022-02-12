using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.API.Application.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;
        private readonly IErpIntegrationService _erpIntegrationService;
        public PeopleService(IPeopleRepository peopleRepository, IErpIntegrationService erpIntegrationService)
        {
            _peopleRepository = peopleRepository;
            _erpIntegrationService = erpIntegrationService;
        }
    }
}
