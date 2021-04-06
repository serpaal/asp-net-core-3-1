using AutoMapper;
using MesaAyuda.Domain.Repositories;
using MesaAyuda.Domain.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Services
{ 
    public class IncidentesService : IIncidentesService
    {
        private readonly IIncidentesRepository _incidentesRepository;
        private readonly IMapper _mapper;

        public IncidentesService(IIncidentesRepository incidentesRepository, IMapper mapper)
        {
            _incidentesRepository = incidentesRepository;
            _mapper = mapper;
        }
     
         public IEnumerable<IncidentesInfoResponse> GetIncidentes(string cod_u_rbl)
        {
            var result = _incidentesRepository.GetIncidentes(cod_u_rbl);
            return result.Select(x => _mapper.Map<IncidentesInfoResponse>(x));
        } 
    }
}
