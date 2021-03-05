using MesaAyuda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MesaAyuda.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequerimInfController : ControllerBase
    {
        private readonly RequerimInfService _requerimInfService;
        public RequerimInfController(RequerimInfService requerimInfService)
        {
            _requerimInfService = requerimInfService;            
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _requerimInfService.GetRequerimInfAsync();
            return Ok(result);
        } 
    }
}
