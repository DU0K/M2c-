namespace Constructors;

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