using AutoMapper;
using MesaAyuda.Domain.Repositories;
using MesaAyuda.Domain.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Services
{ 
    public class ReqQdetalleService : IReqQdetalleService
    {
        private readonly IReqQdetalleRepository _reqQdetalleRepository;
        private readonly IMapper _mapper;

        public ReqQdetalleService(IReqQdetalleRepository reqQdetalleRepository, IMapper mapper)
        {
            _reqQdetalleRepository = reqQdetalleRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ReqQdetalleResponse>> GetReqQdetalleAsync()
        {
            var result = await _reqQdetalleRepository.GetAsync();
            return result.Select(x => _mapper.Map<ReqQdetalleResponse>(x));
        } 
    }
}
