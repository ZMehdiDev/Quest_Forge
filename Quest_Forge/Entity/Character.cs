namespace Quest_Forge.Entity;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Exp { get; set; }
    public List<Quest> Quests { get; set; } = [];

    public Character(int id, string? name, double exp, List<Quest>? quests)
    {
        Id = id;
        Name = name ?? "Unknown";
        Exp = exp;
        Quests = quests ?? [];
    }
}