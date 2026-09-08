using Quest_Forge.Entity;

namespace Quest_Forge.Service;

public class CharacterService(List<Character> characters)
{
    private readonly List<Character> _characters = characters;

    public Character? FindCharacterById(int id)
    {
        foreach (var character in _characters)
        {
            if (character.Id == id)
            {
                return character;
            }
        }
        Console.WriteLine("This chacater does not exists");
        return null;
    }
    
    
    
}