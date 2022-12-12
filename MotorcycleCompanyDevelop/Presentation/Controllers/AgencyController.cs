using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Contract;
using Contracts;

namespace Presentation.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public  class AgencyController
    {
        private readonly IServiceManager _Service;

        public AgencyController(IServiceManager service) =>
            _Service = service;

        [HttpGet]
        public IActionResult GetAgencies()
        {
            try
            {
                var agencies = _Service.AgencyService.GetAllAgencies(trackchanges: false);
                return Ok(agencies);
            }
            catch (Exception)
            {
                return StatusCode(500, "internal server Error");
            }
        }

        private IActionResult Ok(IEnumerable<IAgency> agencies)
        {
            throw new NotImplementedException();
        }

        private IActionResult StatusCode(int v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
