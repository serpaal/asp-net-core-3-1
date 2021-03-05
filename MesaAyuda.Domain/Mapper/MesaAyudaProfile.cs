using AutoMapper;
using MesaAyuda.Domain.Entities;
using MesaAyuda.Domain.Responses;

namespace MesaAyuda.Domain.Mapper
{
    public class MesaAyudaProfile : Profile
    {
        public MesaAyudaProfile()
        {
            CreateMap<RequerimInf, RequerimInfResponse>();
            CreateMap<ReqQdetalle, ReqQdetalleResponse>();
            /*CreateMap<RequerimientoInfo, RequerimientoInfoResponse>()
                .ForMember(dest => dest., opt => opt.MapFrom(src => src.Detalle)); */
        }
    }
}
