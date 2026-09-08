namespace Quest_Forge.Entity;

public class TimedQuest(int id, string? name, double reward, int progression, bool isFinished, Character holder,double time)
    : Quest(id, name, reward, progression, isFinished, holder)
{
    public double Time { get; set; } = time;
    public double TimeRemaining { get; set; }
}