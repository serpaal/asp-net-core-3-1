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
        private readonly IIncidentesService _incidentesService;
        public IncidentesInfController(IIncidentesInfService incidentesInfService, IIncidentesService incidentesService)
        {
            _incidentesInfService = incidentesInfService;
            _incidentesService = incidentesService;
        }

        /*[HttpGet]
        public async Task<IActionResult> Get(string cod_u_rbl = "VBUS01")
        {
            var result = await _incidentesInfService.GetIncidentesAsync(cod_u_rbl);
            return Ok(result);
        }*/

        [HttpGet]
        public IActionResult Get(string cod_u_rbl = "VBUS01")
        {
            var result = _incidentesService.GetIncidentes(cod_u_rbl);
            return Ok(result);
        }
    }
}
