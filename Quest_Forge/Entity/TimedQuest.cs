namespace Quest_Forge.Entity;

public class TimedQuest(int id, string? name, double reward, int progression, int difficulty, Character holder,double time)
    : Quest(id, name, reward, progression, difficulty, holder)
{
    public double Time { get; set; } = time;
    public double TimeRemaining { get; set; }
}