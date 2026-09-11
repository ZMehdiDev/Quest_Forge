using Microsoft.EntityFrameworkCore;
using Quest_Forge.Data;
using Quest_Forge.Service;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<QuestForgeDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<CharacterService>();
builder.Services.AddScoped<QuestService>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();