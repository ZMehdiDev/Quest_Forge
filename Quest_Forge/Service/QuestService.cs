using Microsoft.EntityFrameworkCore;
using Quest_Forge.Data;
using Quest_Forge.Entity;

namespace Quest_Forge.Service;

public class QuestService(QuestForgeDbContext dbContext)
{
    private readonly QuestForgeDbContext _dbContext = dbContext;

    public async Task<Quest?> FindQuestById(int id)
    {
        return await _dbContext.Quests.FindAsync(id);
    }

    public async Task<List<Quest>> FindAllQuests()
    {
        return await _dbContext.Quests.ToListAsync();
    }

    public async Task<Quest?> AddProgression(int id, int amount)
    {
        var quest = await FindQuestById(id);

        if (quest == null)
            return null;

        quest.AddProgression(amount);

        await _dbContext.SaveChangesAsync();

        return quest;
    }
}