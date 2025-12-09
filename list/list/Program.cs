namespace list;

class Program
{
        string[] characters = {"Pac-Man","Samus","Crash Bandicoot","Spyro the Dragon","Donkey Kong","Mario","Luigi","Astro","Solid Snake","Master Chief","Kratos","Sonic the Hedgehog","Link"};
        List<string> characterList =new List<string>() ;
    static void Main(string[] args)
    {
        Program program = new Program();
        program.run();
    }

    internal Program()
    {
         characterList.AddRange(characters);
    }

    internal void run()
    {
      //  characterList.Add("Indina Jones");   

        foreach (var character in characterList)
        {
            Console.WriteLine(character);
        };

        Console.WriteLine("Enter character to add:");
        string newCharacter = Console.ReadLine();
        characterList.Add(newCharacter);

        run();
    }
}
