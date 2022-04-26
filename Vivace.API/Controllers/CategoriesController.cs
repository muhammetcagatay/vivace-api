using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vivace.Core.DTOs.Request;
using Vivace.Core.Services;

namespace Vivace.API.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly ICategoryService categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) => CreateResult(await categoryService.GetAsync(id));

        [HttpGet]
        public async Task<IActionResult> GetAll() => CreateResult(await categoryService.GetAllAsync());

        [HttpPost]
        public async Task<IActionResult> Create(CategoryRequestDto request) => CreateResult(await categoryService.CreateAsync(request));
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CategoryRequestDto request) => CreateResult(await categoryService.UpdateAsync(id, request));
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) => CreateResult(await categoryService.RemoveAsync(id));
    }
}
