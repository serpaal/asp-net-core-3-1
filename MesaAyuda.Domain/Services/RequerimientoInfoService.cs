using AutoMapper;
using MesaAyuda.Domain.Mapper;
using MesaAyuda.Domain.Repositories;
using MesaAyuda.Domain.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Services
{ 
    public class RequerimientoInfoService : IRequerimientoInfoService
    {
        private readonly IRequerimientoInfoRepository _requerimientoInfoRepository;
        //private readonly IRequerimientoInfoMapper _requerimientoInfoMapper;
        private readonly IMapper _requerimientoInfoMapper;

        public RequerimientoInfoService(IRequerimientoInfoRepository requerimientoInfoRepository, IMapper requerimientoInfoMapper)
        {
            _requerimientoInfoRepository = requerimientoInfoRepository;
            _requerimientoInfoMapper = requerimientoInfoMapper;
        }
        public async Task<IEnumerable<RequerimientoInfoResponse>> GetRequerimientosInfoAsync()
        {
            var result = await _requerimientoInfoRepository.GetAsync();
            return result.Select(x => _requerimientoInfoMapper.Map<RequerimientoInfoResponse>(x));
        } 
    }
}
