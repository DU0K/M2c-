namespace Remove;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.run();
    }

    internal void run()
    {
        List<double>reviews = new List<double>() {4.5, 3.0, 551.0, 2.5,};
        reviews.Remove(551.0);

        reviews.RemoveAt(1);

        foreach (var review in reviews)
        {
            Console.WriteLine(review);
        }
    }
}
