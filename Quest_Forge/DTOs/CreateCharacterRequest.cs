using System.ComponentModel.DataAnnotations;
using Quest_Forge.Entity;

namespace Quest_Forge.DTOs;

public class CreateCharacterRequest
{
    public string Name { get; set; }
}