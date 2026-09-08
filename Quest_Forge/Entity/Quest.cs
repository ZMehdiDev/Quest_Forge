namespace Quest_Forge.Entity;

public abstract class Quest(int id, string? name, double reward, int progression, bool isFinished, Character? holder)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name ?? "Unknown";
    public double Reward { get; set; } = reward;
    public int Progression { get; set; } = progression;
    public bool IsFinished{ get; set; } = isFinished;
    public Character? Holder { get; set; } = holder;
}