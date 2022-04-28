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
    public interface ISongService
    {
        Task<Response<SongResponseDto>> GetAsync(int id);
        Task<Response<IEnumerable<SongResponseDto>>> GetAllAsync();
        Task<Response<NoContent>> CreateAsync(SongRequestDto request);
        Task<Response<NoContent>> UpdateAsync(int id, SongRequestDto request);
        Task<Response<NoContent>> RemoveAsync(int id);
    }
}
