using System.ComponentModel.DataAnnotations;

namespace Quest_Forge.DTOs;

public class ProgressQuestRequest
{
    [Required]
    public int Amount { get; set; }
}