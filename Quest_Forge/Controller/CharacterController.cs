using Microsoft.AspNetCore.Mvc;
using Quest_Forge.DTOs;
using Quest_Forge.Entity;
using Quest_Forge.Service;

namespace Quest_Forge.Controller;


[ApiController]
[Route("api/[controller]")]
public class CharacterController (CharacterService characterService, QuestService questService): ControllerBase
{

    [HttpGet("{id:int}")]
    public IActionResult GetCharacterById(int id)
    {

        var character = characterService.FindCharacterById(id);
        if (character == null)
        {
            return NotFound();
        }

        return Ok(character);
    }
    
    [HttpGet]
    public List<Character> GetAllCharacters()
    {
        return characterService.FindAllCharacters();
    }

    [HttpPost("{characterId:int}/quest/{questId:int}")]
    public IActionResult TakeQuest(int characterId, int questId)
    {
        var character = characterService.FindCharacterById(characterId);
        if (character == null)
        {
            return NotFound();
        }
        
        var quest = questService.FindQuestById(questId);
        if (quest==null)
        {
            return NotFound();
        }
        
        character.TakeQuest(quest);
        return Ok();
    }

    [HttpPost]
    public IActionResult CreateCharacter(CreateCharacterRequest request)
    {
        var character = new Character(0, request.Name, 0, []);
        characterService.AddCharacter(character);
        return Created();
    }
    
}