using AutoMapper;
using MesaAyuda.Domain.Repositories;
using MesaAyuda.Domain.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Services
{ 
    public class RequerimInfService : IRequerimInfService
    {
        private readonly IRequerimInfRepository _requerimInfRepository;
        private readonly IMapper _mapper;

        public RequerimInfService(IRequerimInfRepository requerimInfRepository, IMapper mapper)
        {
            _requerimInfRepository = requerimInfRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<RequerimInfResponse>> GetRequerimInfAsync()
        {
            var result = await _requerimInfRepository.GetAsync();
            return result.Select(x => _mapper.Map<RequerimInfResponse>(x));
        } 

         public async Task<IEnumerable<RequerimientoInfoResponse>> GetRequerimientosAsync()
        {
            var result = await _requerimInfRepository.GetRequerimientosAsync();
            return result.Select(x => _mapper.Map<RequerimientoInfoResponse>(x));
        } 
    }
}
