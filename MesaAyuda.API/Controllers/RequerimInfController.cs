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
        public async Task<IActionResult> Get()
        {
            //var result = await _requerimInfService.GetRequerimInfAsync();
            var result = await _requerimInfService.GetRequerimientosAsync();
            return Ok(result);
        } 
    }
}
