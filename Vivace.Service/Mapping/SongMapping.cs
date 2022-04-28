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
    public class SongMapping : Profile
    {
        public SongMapping()
        {
            CreateMap<Song, SongRequestDto>().ReverseMap();
            CreateMap<Song, SongResponseDto>().ReverseMap();
        }
    }
}
