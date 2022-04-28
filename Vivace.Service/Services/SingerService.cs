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
    public class SingerService : ISingerService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IGenericRepository<Singer> repository;

        public SingerService(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Singer> repository)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.repository = repository;
        }
        public async Task<Response<SingerResponseDto>> GetAsync(int id)
        {
            var singer = await repository.
                Where(x => x.ID == id).
                SingleOrDefaultAsync();

            var singerResponseDto = mapper.Map<SingerResponseDto>(singer);

            return Response<SingerResponseDto>.Success(HttpStatusCode.OK, singerResponseDto);
        }
        public async Task<Response<IEnumerable<SingerResponseDto>>> GetAllAsync()
        {
            var singers = await repository.GetAllAsync();

            var singersResponseDtos = mapper.Map<IEnumerable<SingerResponseDto>>(singers);

            return Response<IEnumerable<SingerResponseDto>>.Success(HttpStatusCode.OK, singersResponseDtos);
        }
        public async Task<Response<NoContent>> CreateAsync(SingerRequestDto request)
        {
            var singer = mapper.Map<Singer>(request);

            await repository.AddAsync(singer);

            await unitOfWork.SaveChangesAsync();

            return Response<NoContent>.Success(HttpStatusCode.Created);
        }
        public async Task<Response<NoContent>> UpdateAsync(int id, SingerRequestDto request)
        {
            var singer = await repository.Where(x => x.ID == id).SingleOrDefaultAsync();

            singer.Name = request.Name;
            singer.Surname = request.Surname;

            repository.Update(singer);

            await unitOfWork.SaveChangesAsync();

            return Response<NoContent>.Success(HttpStatusCode.OK);
        }
        public async Task<Response<NoContent>> RemoveAsync(int id)
        {
            var singer = await repository.Where(x => x.ID == id).SingleOrDefaultAsync();

            singer.IsDeleted = true;

            repository.Update(singer);

            await unitOfWork.SaveChangesAsync();

            return Response<NoContent>.Success(HttpStatusCode.OK);
        }
    }
}
