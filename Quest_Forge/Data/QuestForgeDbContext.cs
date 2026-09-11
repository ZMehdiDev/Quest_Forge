using Microsoft.EntityFrameworkCore;
using Quest_Forge.Entity;

namespace Quest_Forge.Data;

public class QuestForgeDbContext(DbContextOptions<QuestForgeDbContext> options)
    : DbContext(options)
{
    public DbSet<Character> Characters { get; set; }
    public DbSet<Quest> Quests { get; set; }
}