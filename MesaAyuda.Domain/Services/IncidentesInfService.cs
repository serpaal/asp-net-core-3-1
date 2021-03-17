using AutoMapper;
using MesaAyuda.Domain.Repositories;
using MesaAyuda.Domain.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Services
{ 
    public class IncidentesInfService : IIncidentesInfService
    {
        private readonly IIncidentesInfRepository _incidentesInfRepository;
        private readonly IMapper _mapper;

        public IncidentesInfService(IIncidentesInfRepository incidentesInfRepository, IMapper mapper)
        {
            _incidentesInfRepository = incidentesInfRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<IncidentesInfResponse>> GetIncidentesInfAsync()
        {
            var result = await _incidentesInfRepository.GetAsync();
            return result.Select(x => _mapper.Map<IncidentesInfResponse>(x));
        } 

         public async Task<IEnumerable<IncidentesInfoResponse>> GetIncidentesAsync(string cod_u_rbl)
        {
            var result = await _incidentesInfRepository.GetIncidentesAsync(cod_u_rbl);
            return result.Select(x => _mapper.Map<IncidentesInfoResponse>(x));
        } 
    }
}
