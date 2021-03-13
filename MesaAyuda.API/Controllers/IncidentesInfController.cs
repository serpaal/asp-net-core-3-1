using MesaAyuda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MesaAyuda.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentesInfController : ControllerBase
    {
        private readonly IIncidentesInfService _incidentesInfService;
        public IncidentesInfController(IIncidentesInfService incidentesInfService)
        {
            _incidentesInfService = incidentesInfService;            
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _incidentesInfService.GetIncidentesAsync();
            return Ok(result);
        } 
    }
}
