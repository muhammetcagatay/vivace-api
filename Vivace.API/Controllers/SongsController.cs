using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vivace.Core.DTOs.Request;
using Vivace.Core.Services;

namespace Vivace.API.Controllers
{
    public class SongsController : BaseController
    {
        private readonly ISongService songService;
        public SongsController(ISongService songService)
        {
            this.songService = songService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) => CreateResult(await songService.GetAsync(id));

        [HttpGet]
        public async Task<IActionResult> GetAll() => CreateResult(await songService.GetAllAsync());

        [HttpPost]
        public async Task<IActionResult> Create(SongRequestDto request) => CreateResult(await songService.CreateAsync(request));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, SongRequestDto request) => CreateResult(await songService.UpdateAsync(id, request));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) => CreateResult(await songService.RemoveAsync(id));
    }
}
