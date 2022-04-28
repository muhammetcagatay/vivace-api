using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivace.Core.DTOs.Request;
using Vivace.Core.DTOs.Response;
using Vivace.Core.Models;

namespace Vivace.Service.Mapping
{
    public class SingerMapping : Profile
    {
        public SingerMapping()
        {
            CreateMap<Singer, SingerRequestDto>().ReverseMap();
            CreateMap<Singer, SingerResponseDto>().ReverseMap();
        }
    }
}
