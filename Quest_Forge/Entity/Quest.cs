namespace Quest_Forge.Entity;

public class Quest
{
    public int Id { get; set; }
    public string Name { get; set; } = "Unknown";
    public double Reward { get; set; }
    public int Progression { get; set; }
    public int Difficulty { get; set; }
    public bool IsFinished { get; set; }
    public Character? Holder { get; set; }

    public void AddProgression(int amount)
    {
        if (IsFinished)
            throw new Exception("Quest is already finished");

        Progression += amount;

        if (Progression >= Difficulty)
        {
            Progression = Difficulty;
            IsFinished = true;
            Holder?.Exp += Reward;
            Holder?.Quests.Remove(this);
        }
    }
}