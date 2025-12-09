namespace ForHerhaling;

class Program
{
    static void Main(string[] args)
    {
        double[] prijzen = new double[] { 2.50, 3.75, 1.20, 4.00 };
        string[] artiekelen = {"Brood", "Melk", "Kaas", "Eieren" };
        Formulier[] formulieren = new Formulier[2];
        formulieren[0] = new Formulier()
        {
            Feedback = "Goede service",
            Sterren = 5
        };
        formulieren[1] = new Formulier()
        {
            Feedback = "Slechte service",
            Sterren = 1
        };
        for (int i = 0; i < artiekelen.Length; i++)
        {
            Console.WriteLine(artiekelen[i]);
            Console.WriteLine(prijzen[i]);
        };

        foreach (var Formulier in formulieren)
        {
            Console.WriteLine(Formulier.Feedback);
            Console.WriteLine(Formulier.Sterren);
        };
    }

    internal class Formulier
    {
        internal int Sterren { get; set; }
        internal string Feedback { get; set; }

    }
}
