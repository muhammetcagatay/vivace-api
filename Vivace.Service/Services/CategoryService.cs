using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Vivace.Core.DTOs;
using Vivace.Core.DTOs.Request;
using Vivace.Core.DTOs.Response;
using Vivace.Core.Models;
using Vivace.Core.Repositories;
using Vivace.Core.Services;
using Vivace.Core.UnitOfWorks;

namespace Vivace.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IGenericRepository<Category> repository;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Category> repository)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.repository = repository;
        }
        public async Task<Response<CategoryResponseDto>> GetAsync(int id)
        {
            var category = await repository.
                Where(x => x.ID == id).
                SingleOrDefaultAsync();

            var categoryResponseDto = mapper.Map<CategoryResponseDto>(category);

            return Response<CategoryResponseDto>.Success(HttpStatusCode.OK, categoryResponseDto);
        }
        public async Task<Response<IEnumerable<CategoryResponseDto>>> GetAllAsync()
        {
            var categories = await repository.GetAllAsync();

            var categoriesResponseDto = mapper.Map<IEnumerable<CategoryResponseDto>>(categories);

            return Response<IEnumerable<CategoryResponseDto>>.Success(HttpStatusCode.OK, categoriesResponseDto);
        }
        public async Task<Response<NoContent>> CreateAsync(CategoryRequestDto request)
        {
            var category = mapper.Map<Category>(request);

            await repository.AddAsync(category);

            await unitOfWork.SaveChangesAsync();

            return Response<NoContent>.Success(HttpStatusCode.Created);
        }
        public async Task<Response<NoContent>> UpdateAsync(int id, CategoryRequestDto request)
        {
            var category = await repository.Where(x => x.ID==id).SingleOrDefaultAsync();

            category.Name = request.Name;

            repository.Update(category);

            await unitOfWork.SaveChangesAsync();

            return Response<NoContent>.Success(HttpStatusCode.OK);
        }
        public async Task<Response<NoContent>> RemoveAsync(int id)
        {
            var category =  await repository.Where(x => x.ID == id).SingleOrDefaultAsync();

            category.IsDeleted = true;

            repository.Update(category);

            await unitOfWork.SaveChangesAsync();

            return Response<NoContent>.Success(HttpStatusCode.OK);
        }

    }
}
