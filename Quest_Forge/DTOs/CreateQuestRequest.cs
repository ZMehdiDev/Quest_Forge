using System.ComponentModel.DataAnnotations;
using Quest_Forge.Entity;

namespace Quest_Forge.DTOs;

public class CreateQuestRequest
{

    public string Name { get; set; } 
    [Required]
    public double Reward { get; set; } 
    [Required]
    public int Difficulty { get; set; } 

}