using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); //variablen van het type Program met de naam program
            program.Run(); //de functie heet Run en is momenteel nog niks
            program.vraag0();
            Console.WriteLine(program.vraag7());
            program.GetVraag(0);
        }

        internal void Run()
        {
            Console.WriteLine("Hello World!");
        }

        internal void vraag0()
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

        internal string vraag7()
        {
            Console.WriteLine("wil de computer dat benthe typfus krijgt");
            string antwoord = Console.ReadLine();
            return antwoord;
        }

        string[] vragen = new string[]
        {
            "- How long do you think you'd survive in a zombie apocalypse?",
            "- What secret conspiracy would you like to actually start letting other people know?",
            "- If you can still remember, what are your funniest childhood memories?",
            "- What would you do if you won a million dollars?",
            "- What is the worst game you played but that you liked anyway?",
            "- Why do round pizzas come in square boxes?",
            "- Has someone caught you dancing in front of the mirror?",
            "- Have you ever tried talking to a animal?",
            "- What would you call a male ladybug?",
            "- Which species would be the rudest if all animals could talk?"
        };

        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
        }
    }
}
