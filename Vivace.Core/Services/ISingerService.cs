using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivace.Core.DTOs;
using Vivace.Core.DTOs.Request;
using Vivace.Core.DTOs.Response;

namespace Vivace.Core.Services
{
    public interface ISingerService
    {
        Task<Response<SingerResponseDto>> GetAsync(int id);
        Task<Response<IEnumerable<SingerResponseDto>>> GetAllAsync();
        Task<Response<NoContent>> CreateAsync(SingerRequestDto request);
        Task<Response<NoContent>> UpdateAsync(int id, SingerRequestDto request);
        Task<Response<NoContent>> RemoveAsync(int id);
    }
}
