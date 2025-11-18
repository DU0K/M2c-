namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); //variablen van het type Program met de naam program
            program.Run(); //de functie heet Run en is momenteel nog niks
            program.vraag1();
        }

        internal void Run()
        {
            Console.WriteLine("Hello World!");
        }

        internal void vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord0 = Console.ReadLine();
            Console.WriteLine(antwoord0);

            Console.WriteLine("is dit een nette vraag");
            string antwoord1 = Console.ReadLine();
            Console.WriteLine(antwoord1);

            Console.WriteLine("is poopoo een woord");
            string antwoord2 = Console.ReadLine();
            Console.WriteLine(antwoord2);

            Console.WriteLine("is noah soms niet zo snugger");
            string antwoord3 = Console.ReadLine();
            Console.WriteLine(antwoord3);

            Console.WriteLine("is het carlijn of carlerijn");
            string antwoord4 = Console.ReadLine();
            Console.WriteLine(antwoord4);

            Console.WriteLine("hoe oud is de kerstman");
            string antwoord5 = Console.ReadLine();
            Console.WriteLine(antwoord5);
        }
    }
}
