using System.Text.Json;
using Quest_Forge.Entity;
using Quest_Forge.Service;

var builder = WebApplication.CreateBuilder(args);

var jsonChar = File.ReadAllText("Data/characters.json");

var characters = JsonSerializer.Deserialize<List<Character>>(jsonChar)
                 ?? [];

var jsonQuests = File.ReadAllText("Data/quests.json");

var quests = JsonSerializer.Deserialize<List<Quest>>(jsonQuests)
             ?? [];

builder.Services.AddSingleton(quests);
builder.Services.AddSingleton(characters);

builder.Services.AddControllers();
builder.Services.AddScoped<CharacterService>();
builder.Services.AddScoped<QuestService>();

var app = builder.Build();

app.MapControllers();

app.Run();