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
    public interface ICategoryService
    {
        Task<Response<CategoryResponseDto>> GetAsync(int id);
        Task<Response<IEnumerable<CategoryResponseDto>>> GetAllAsync();
        Task<Response<NoContent>> CreateAsync(CategoryRequestDto request);
        Task<Response<NoContent>> UpdateAsync(int id,CategoryRequestDto request);
        Task<Response<NoContent>> RemoveAsync(int id);
    }
}
