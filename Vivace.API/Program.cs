using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Vivace.Core.Repositories;
using Vivace.Core.Services;
using Vivace.Core.UnitOfWorks;
using Vivace.Data;
using Vivace.Data.Repositories;
using Vivace.Data.UnitOfWorks;
using Vivace.Service.Mapping;
using Vivace.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddAutoMapper(typeof(CategoryMapping));

builder.Services.AddDbContext<VivaceDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("Mssql"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(VivaceDbContext)).GetName().Name);
    });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
