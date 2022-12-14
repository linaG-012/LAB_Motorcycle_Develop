using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Contract;
using Contracts;
using shared.DataTransferObject;

namespace Presentation.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public  class AgencyController : ControllerBase 
    {
        private readonly IServiceManager _Service;

        public AgencyController(IServiceManager service) =>
            _Service = service;

        [HttpGet]
        public IActionResult GetAgencies()
        {
            //throw new Exception("Exception");
            var agencies = _Service.AgencyService.GetAllAgencies(trackchanges: false);
            return Ok(agencies);
        }
      
    }
}
