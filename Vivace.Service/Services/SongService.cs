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
    public class SongService : ISongService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IGenericRepository<Song> repository;

        public SongService(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Song> repository)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.repository = repository;
        }
        public async Task<Response<SongResponseDto>> GetAsync(int id)
        {
            var song = await repository.
                Where(x => x.ID == id).
                SingleOrDefaultAsync();

            var songResponseDto = mapper.Map<SongResponseDto>(song);

            return Response<SongResponseDto>.Success(HttpStatusCode.OK, songResponseDto);
        }
        public async Task<Response<IEnumerable<SongResponseDto>>> GetAllAsync()
        {
            var songs = await repository.GetAllAsync();

            var songsResponseDto = mapper.Map<IEnumerable<SongResponseDto>>(songs);

            return Response<IEnumerable<SongResponseDto>>.Success(HttpStatusCode.OK, songsResponseDto);
        }
        public async Task<Response<NoContent>> CreateAsync(SongRequestDto request)
        {
            var song = mapper.Map<Song>(request);

            await repository.AddAsync(song);

            await unitOfWork.SaveChangesAsync();

            return Response<NoContent>.Success(HttpStatusCode.Created);
        }
        public async Task<Response<NoContent>> UpdateAsync(int id, SongRequestDto request)
        {
            var song = await repository.Where(x => x.ID == id).SingleOrDefaultAsync();

            song.Name = request.Name;
            song.Duration = request.Duration;

            repository.Update(song);

            await unitOfWork.SaveChangesAsync();

            return Response<NoContent>.Success(HttpStatusCode.OK);
        }
        public async Task<Response<NoContent>> RemoveAsync(int id)
        {
            var song = await repository.Where(x => x.ID == id).SingleOrDefaultAsync();

            song.IsDeleted = true;

            repository.Update(song);

            await unitOfWork.SaveChangesAsync();

            return Response<NoContent>.Success(HttpStatusCode.OK);
        }
    }
}
