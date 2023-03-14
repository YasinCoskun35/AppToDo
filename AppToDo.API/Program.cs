using System.Reflection;
using AppToDo.Core.Repositories;
using AppToDo.Core.UnitOfWorks;
using AppToDo.Repository.DBContext;
using AppToDo.Repository.Repositories;
using AppToDo.Repository.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
//builder.Services.AddScoped(typeof(IService<>),typeof(Service<>));

builder.Services.AddDbContext<AppToDoDbContext>(x =>
{
    x.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSql"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppToDoDbContext)).GetName().Name);
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
