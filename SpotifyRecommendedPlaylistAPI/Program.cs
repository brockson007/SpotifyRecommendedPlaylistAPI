using SpotifyRecommendedPlaylistAPI.Data;
using SpotifyRecommendedPlaylistAPI.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

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

var app = builder.Build();

// This runs migrations each time the service is ran
using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<SpotifyRecommendedPlaylistAPIDataContext>();
           
    dataContext.Database.Migrate();
    
}

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
