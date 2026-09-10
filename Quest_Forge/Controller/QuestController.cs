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
    public IActionResult GetQuestById(int id)
    {

        var quest = questService.FindQuestById(id);
        if (quest==null)
        {
            return NotFound();
        }

        return Ok(quest);
    }

    [HttpGet]
    public List<Quest> GetAllQuests()
    {
        return questService.FindAllQuests();
    }

    [HttpPost("{id:int}/progress")]
    public IActionResult AddProgression(int id, ProgressQuestRequest request)
    {
        var quest = questService.FindQuestById(id);
        if (quest==null)
        {
            return NotFound();
        }
        quest.AddProgression(request.Amount);
        return Ok();
    }
    
}