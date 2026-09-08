using Quest_Forge.Entity;
using Quest_Forge.Service;

// Characters
var characters = new List<Character>
{
    new Character(1, "Arthas", 150, []),
    new Character(2, "Luna", 230, []),
    new Character(3, "Garen", 80, [])
};

// Quests
var quests = new List<Quest>
{
    new TimedQuest(
        1,
        "Slay the Goblin King",
        100,
        0,
        100,
        null,
        30
    ),

    new TimedQuest(
        2,
        "Collect 10 Herbs",
        50,
        5,
        10,
        null,
        15
    )
};

// Services
var characterService = new CharacterService(characters);
var questService = new QuestService(quests);

// Assign quests
var arthas = characterService.FindCharacterById(1);
var luna = characterService.FindCharacterById(2);

var goblinQuest = questService.FindQuestById(1);
var herbsQuest = questService.FindQuestById(2);

arthas?.TakeQuest(goblinQuest!);
luna?.TakeQuest(herbsQuest!);

// Display initial state
Console.WriteLine("=== Characters ===");

foreach (var character in characters)
{
    Console.WriteLine($"{character.Id} - {character.Name} - {character.Exp} XP");
    character.DisplayQuests();
}

// First progression
Console.WriteLine("\n=== Quest Progression ===");

try
{
    goblinQuest?.AddProgression(30);
    Console.WriteLine(
        $"Goblin Quest: {goblinQuest?.Progression}/100"
    );
}
catch (Exception e)
{
    Console.WriteLine($"Could not progress Goblin Quest: {e.Message}");
}

try
{
    herbsQuest?.AddProgression(3);
    Console.WriteLine(
        $"Herbs Quest: {herbsQuest?.Progression}/10"
    );
}
catch (Exception e)
{
    Console.WriteLine($"Could not progress Herbs Quest: {e.Message}");
}

// Second progression
Console.WriteLine("\n=== More Progression ===");

try
{
    goblinQuest?.AddProgression(20);
    Console.WriteLine(
        $"Goblin Quest: {goblinQuest?.Progression}/100"
    );
}
catch (Exception e)
{
    Console.WriteLine($"Could not progress Goblin Quest: {e.Message}");
}

try
{
    herbsQuest?.AddProgression(2);
    Console.WriteLine(
        $"Herbs Quest: {herbsQuest?.Progression}/10"
    );
}
catch (Exception e)
{
    Console.WriteLine($"Could not progress Herbs Quest: {e.Message}");
}

// Final progression
Console.WriteLine("\n=== Final Progression ===");

try
{
    goblinQuest?.AddProgression(50);
    Console.WriteLine(
        $"Goblin Quest: {goblinQuest?.Progression}/100"
    );
}
catch (Exception e)
{
    Console.WriteLine($"Could not progress Goblin Quest: {e.Message}");
}

// Final state
Console.WriteLine("\n=== Final Characters ===");

foreach (var character in characters)
{
    Console.WriteLine($"{character.Name} - {character.Exp} XP");
    character.DisplayQuests();
}