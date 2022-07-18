using HotelListing.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Serilog;
using HotelListing.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//new
builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console());
builder.Services.AddCors(O=> 
{
    O.AddPolicy("AllowALL", build =>
    build.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

});
builder.Services.AddAutoMapper(typeof(MapperInitializer));

builder.Services.AddDbContext<DatabaseContext>(o =>
o.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));

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
