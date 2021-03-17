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
        public async Task<IActionResult> Get(string cod_u_rbl = "VBUS01")
        {
            var result = await _incidentesInfService.GetIncidentesAsync(cod_u_rbl);
            return Ok(result);
        } 
    }
}
