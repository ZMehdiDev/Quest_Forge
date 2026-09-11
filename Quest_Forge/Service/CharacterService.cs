using Microsoft.EntityFrameworkCore;
using Quest_Forge.Data;
using Quest_Forge.Entity;

namespace Quest_Forge.Service;

public class CharacterService(QuestForgeDbContext dbContext)
{
    private readonly QuestForgeDbContext _dbContext = dbContext;

    public async Task<Character?> FindCharacterById(int id)
    {
        return await _dbContext.Characters.FindAsync(id);
    }
    
    public async Task<List<Character>> FindAllCharacters()
    {
        return await _dbContext.Characters.ToListAsync();
    }

    public async Task<Character> AddCharacter(Character character)
    {
        _dbContext.Characters.Add(character);
        await _dbContext.SaveChangesAsync();
        return character;
    }
    
}