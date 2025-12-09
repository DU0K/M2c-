namespace Constructors;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class QuizVraagAntwoord
{
    internal QuizVraag Vraag;
    internal bool Goed;
    internal QuizVraagAntwoord(QuizVraag Vraag, bool Goed)
    {
        this.Vraag = Vraag;
        this.Goed = Goed;
    }
}

class Quiz
{
    internal QuizVraag[] Vragen;
    internal QuizVraagAntwoord[] Antwoorden;
    internal Quiz(QuizVraag[] Vragen, QuizVraagAntwoord[] Antwoorden)
    {
        this.Vragen = Vragen;
        this.Antwoorden = Antwoorden;
    }
}

class QuizVraag
{
    internal string Antwoord;
    internal string Vraag;

    internal QuizVraag(string Vraag, string Antwoord)
    {
        this.Vraag = Vraag;
        this.Antwoord = Antwoord;
    }

    private void run()
    {
        QuizVraag vraag1 = new QuizVraag("Hier komt de vraag", "hier komt het antwoord");
    }
}