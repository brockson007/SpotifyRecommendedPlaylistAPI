using SpotifyRecommendedPlaylistAPI.Data;
using SpotifyRecommendedPlaylistAPI.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Serilog;
using System.IO;
using System.Reflection;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

Serilog.Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File(path: @$"Logs\SpotifyRecommendedPlaylistAPI.log", 
                  rollingInterval: RollingInterval.Day,
                  rollOnFileSizeLimit: true,
                  fileSizeLimitBytes: 5000000)  
    .CreateLogger();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRepositories();
builder.Services.AddDbContext<SpotifyRecommendedPlaylistAPIDataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("local"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "SpotifyRecommendedPlaylistAPI", Version = "v1" });

    var xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    x.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFileName));
});

builder.Services.AddSwaggerGenNewtonsoftSupport();
builder.Services.AddHttpClient("Spotify", client =>
{
    client.BaseAddress = new Uri("https://api.spotify.com/v1");
});

builder.Services.AddMediatR(typeof(Program));

builder.Host.UseSerilog();


var app = builder.Build();

// This runs migrations each time the service is ran
//using (var scope = app.Services.CreateScope())
//{
//    var dataContext = scope.ServiceProvider.GetRequiredService<SpotifyRecommendedPlaylistAPIDataContext>();
           
//    dataContext.Database.Migrate();
    
//}

app.UseSwagger();
app.UseSwaggerUI(s =>
{
    s.SwaggerEndpoint("/swagger/v1/swagger.json", "SpotifyRecommendedPlaylistAPI");
    s.RoutePrefix = "";
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
