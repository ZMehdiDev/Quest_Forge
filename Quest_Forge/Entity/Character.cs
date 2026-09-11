namespace Quest_Forge.Entity;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Exp { get; set; }
    public List<Quest> Quests { get; set; } = [];
    
    public Character()
    {
    }

    public Character(int id, string? name, double exp, List<Quest>? quests)
    {
        Id = id;
        Name = name ?? "Unknown";
        Exp = exp;
        Quests = quests ?? [];
    }

    public void DisplayQuests()
    {
        foreach (var quest in Quests )
        {
            Console.WriteLine(quest.Name);
        }
    }

    public void TakeQuest(Quest quest)
    {
        Quests.Add(quest);
        quest.Holder = this;
    }
    
}