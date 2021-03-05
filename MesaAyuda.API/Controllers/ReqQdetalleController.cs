using MesaAyuda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MesaAyuda.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReqQdetalleController : ControllerBase
    {
        private readonly IReqQdetalleService _reqQdetalleService;
        public ReqQdetalleController(IReqQdetalleService reqQdetalleService)
        {
            _reqQdetalleService = reqQdetalleService;            
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _reqQdetalleService.GetReqQdetalleAsync();
            return Ok(result);
        } 
    }
}
