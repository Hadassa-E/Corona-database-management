using BLL;
using BLL.Functions;
using BLL.Interfaces;
using DAL.Functions;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(o => o.JsonSerializerOptions.PropertyNamingPolicy = null);
builder.Services.AddCors(opotion => opotion.AddPolicy("AllowAll",
                p => p.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<CoronaProjectContext>(x => x.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=CoronaProject;Trusted_Connection=True;"));
builder.Services.AddScoped(typeof(IcityDAL), typeof(CityDAL));
builder.Services.AddScoped(typeof(IcoronaInfectionDAL), typeof(CoronaInfectionDAL));
builder.Services.AddScoped(typeof(ImemberDAL), typeof(MemberDAL));
builder.Services.AddScoped(typeof(IvaccineDAL), typeof(VaccineDAL));
builder.Services.AddScoped(typeof(IvaccineTypeDAL), typeof(VaccineTypeDAL));
builder.Services.AddScoped(typeof(IcityBLL), typeof(CityBLL));
builder.Services.AddScoped(typeof(IcoronaInfectionBLL), typeof(CoronaInfectionBLL));
builder.Services.AddScoped(typeof(ImemberBLL), typeof(MemberBLL));
builder.Services.AddScoped(typeof(IvaccineBLL), typeof(VaccineBLL));
builder.Services.AddScoped(typeof(IvaccineTypeBLL), typeof(VaccineTypeBLL));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();