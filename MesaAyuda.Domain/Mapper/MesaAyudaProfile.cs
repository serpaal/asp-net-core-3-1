﻿using AutoMapper;
using MesaAyuda.Domain.Entities;
using MesaAyuda.Domain.Responses;

namespace MesaAyuda.Domain.Mapper
{
    public class MesaAyudaProfile : Profile
    {
        public MesaAyudaProfile()
        {
            //CreateMap<RequerimientoInfoResponse, RequerimientoInfo>().ReverseMap();
            CreateMap<RequerimientoInfo, RequerimientoInfoResponse>()
                .ForMember(dest => dest.Detalis, opt => opt.MapFrom(src => src.Detalle)); //Map from RequerimientoInfo Object to RequerimientoInfoResponse Object
        }
    }
}