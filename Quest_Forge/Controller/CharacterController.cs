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

        return Ok(character);
    }
    
    [HttpGet]
    public Task<List<Character>> GetAllCharacters()
    {
        return characterService.FindAllCharacters();
    }

    [HttpPost("{characterId:int}/quest/{questId:int}")]
    public async Task<IActionResult> TakeQuest(int characterId, int questId)
    {
        var character = await characterService.FindCharacterById(characterId);

        var quest = await questService.FindQuestById(questId);

        if (character == null || quest == null)
        {
            return NotFound();
        }

        character.TakeQuest(quest);

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateCharacter(CreateCharacterRequest request)
    {
        var character =  new Character(0, request.Name, 0, []);
        _ = await characterService.AddCharacter(character);
        return Created();
    }
    
}