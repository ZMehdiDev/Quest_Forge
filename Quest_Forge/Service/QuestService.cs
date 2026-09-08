using Quest_Forge.Entity;

namespace Quest_Forge.Service;

public class QuestService(List<Quest> quests)
{
    private readonly List<Quest> _quest = quests;

    public Quest? FindQuestById(int id)
    {
        foreach (var quest in _quest)
        {
            if (quest.Id == id)
            {
                return quest;
            }
        }
        Console.WriteLine("This quest does not exists...");
        return null;
    }
}