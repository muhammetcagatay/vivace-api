using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vivace.Core.DTOs.Request;
using Vivace.Core.Services;

namespace Vivace.API.Controllers
{
    public class SingersController : BaseController
    {
        private readonly ISingerService singerService;
        public SingersController(ISingerService singerService)
        {
            this.singerService = singerService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) => CreateResult(await singerService.GetAsync(id));

        [HttpGet]
        public async Task<IActionResult> GetAll() => CreateResult(await singerService.GetAllAsync());

        [HttpPost]
        public async Task<IActionResult> Create(SingerRequestDto request) => CreateResult(await singerService.CreateAsync(request));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, SingerRequestDto request) => CreateResult(await singerService.UpdateAsync(id, request));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) => CreateResult(await singerService.RemoveAsync(id));
    }
}
