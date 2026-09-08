namespace Quest_Forge.Entity;

public abstract class Quest(
    int id,
    string? name,
    double reward,
    int progression,
    int difficulty,
    Character? holder)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name ?? "Unknown";

    private double Reward { get; set; } = reward;
    public int Progression { get; private set; } = progression;
    private int Difficulty { get; set; } = difficulty;
    private bool IsFinished { get; set; }

    public Character? Holder { get; set; } = holder;
    
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
            return;
        }
    }
}