using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MesaAyuda.Domain.Repositories;
using MesaAyuda.Domain.Responses;

namespace MesaAyuda.Domain.Services
{ 
    public class RequerimientosService : IRequerimientosService
    {
        private readonly IRequerimientosRepository _requerimientosRepository;
        private readonly IMapper _mapper;

        public RequerimientosService(IRequerimientosRepository requerimientosRepository, IMapper mapper)
        {
            _requerimientosRepository = requerimientosRepository;
            _mapper = mapper;
        }       

        public IEnumerable<RequerimientoInfoResponse> GetRequerimientos(string cod_u_rbl)
        {
            var result = _requerimientosRepository.GetRequerimientos(cod_u_rbl);
            return result.Select(x => _mapper.Map<RequerimientoInfoResponse>(x));
        } 
    }
}
