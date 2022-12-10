using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers
{
    [Route("api/[Controller")]
    [ApiController]
    public class AgencyControllers : ControllerBase
    {
        private readonly IServiceManager _service;

        public AgencyControllers(IServiceManager service) =>
            _service = service;
        [HttpGet]

        public IActionResult GetAgencies()
        {
            try
            {
                var agencies = _service.AgencyService.GetAllAgencies(trackChanges: false);
                return Ok(agencies);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server Error");
            }
        }
    }
}
