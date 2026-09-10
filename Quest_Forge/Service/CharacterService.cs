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
        return null;
    }
    
    public List<Character> FindAllCharacters()
    {
        return _characters;
    }

    public Character AddCharacter(Character character)
    {
        var id = _characters.Count + 100;
        character.Id = id;
        _characters.Add(character);
        return character;
    }
}