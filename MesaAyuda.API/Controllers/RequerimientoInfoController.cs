using MesaAyuda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MesaAyuda.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequerimientoInfoController : ControllerBase
    {
        private readonly IRequerimientoInfoService _requerimientoInfoService;
        public RequerimientoInfoController(IRequerimientoInfoService requerimientoInfoService)
        {
            _requerimientoInfoService = requerimientoInfoService;            
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _requerimientoInfoService.GetRequerimientosInfoAsync();
            return Ok(result);
        } 
    }
}
