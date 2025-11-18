namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); //variablen van het type Program met de naam program
            program.Run(); //de functie heet Run en is momenteel nog niks
        }

        void Run()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
