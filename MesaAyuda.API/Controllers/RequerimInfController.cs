using MesaAyuda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MesaAyuda.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class RequerimInfController : ControllerBase
    {
        private readonly IRequerimInfService _requerimInfService;
        public RequerimInfController(IRequerimInfService requerimInfService)
        {
            _requerimInfService = requerimInfService;            
        }

        [HttpGet]
        public async Task<IActionResult> Get(string cod_u_rbl = "VBUS01")
        {
            var result = await _requerimInfService.GetRequerimientosAsync(cod_u_rbl);
            return Ok(result);
        } 
    }
}
