using Microsoft.AspNetCore.Mvc;
using Quest_Forge.DTOs;
using Quest_Forge.Entity;
using Quest_Forge.Service;

namespace Quest_Forge.Controller;

[ApiController]
[Route("api/[controller]")]
public class QuestController (QuestService questService) : ControllerBase
{
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetQuestById(int id)
    {

        var quest = questService.FindQuestById(id);
        if (quest==null)
        {
            return NotFound();
        }

        return Ok(quest);
    }

    [HttpGet]
    public async Task<List<Quest>> GetAllQuests()
    {
        return await questService.FindAllQuests();
    }

    [HttpPost("{id:int}/progress")]
    public async Task<IActionResult> AddProgression(int id, ProgressQuestRequest request)
    {
        var quest = await questService.AddProgression(id, request.Amount);

        if (quest == null)
            return NotFound();

        return Ok(quest);
    }
    
}