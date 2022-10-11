internal class Program
{
    private static void Main(string[] args)
    {
        MadlibsGame madlibs = new MadlibsGame();
        madlibs.Execute();
        Console.ReadLine();
    }
}

public class Stories
{
    public void StoryOne(GrammarStuff grammar)
    {
        Console.WriteLine($"The {grammar.Adjective1} {grammar.Noun1} {grammar.Verb1} on the {grammar.Noun2} and {grammar.Verb2} all over the {grammar.Adjective2} {grammar.Noun2}");
    }
    public void StoryTwo(GrammarStuff grammar)
    {
        Console.WriteLine($"The {grammar.Adjective1} {grammar.Noun1} {grammar.Verb1} over to the {grammar.Adjective2} {grammar.Noun2} and {grammar.Verb2} away");
    }
}
public class GrammarStuff
{
    public GrammarStuff(string? verb1, string? verb2, string? adjective1, string? adjective2, string? noun1, string? noun2)
    {
        Verb1 = verb1;
        Verb2 = verb2;
        Adjective1 = adjective1;
        Adjective2 = adjective2;
        Noun1 = noun1;
        Noun2 = noun2;
    }

    public string? Verb1 { get; set; }
    public string? Verb2 { get; set; }
    public string? Adjective1 { get; set; }
    public string? Adjective2 { get; set; }
    public string? Noun1 { get; set; }
    public string? Noun2 { get; set; }
}

public class MadlibsGame
{
    public void Execute()
    {
        Console.WriteLine("First, enter a verb");
        string? Verb1 = Console.ReadLine();
        Console.WriteLine("Enter another verb");
        string? Verb2 = Console.ReadLine();
        Console.WriteLine("Enter an adjective");
        string? Adjective1 = Console.ReadLine();
        Console.WriteLine("Another adjective");
        string? Adjective2 = Console.ReadLine();
        Console.WriteLine("Enter a noun");
        string? Noun1 = Console.ReadLine();
        Console.WriteLine("Another noun");
        string? Noun2 = Console.ReadLine();
        GrammarStuff grammar = new GrammarStuff(Verb1, Verb2, Adjective1, Adjective2, Noun1, Noun2);
        Stories stories = new Stories();
        stories.StoryOne(grammar);
        stories.StoryTwo(grammar);
    }
}