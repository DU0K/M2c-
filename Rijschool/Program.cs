namespace Rijschool;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.run();
    }
    internal void run()
    {
        Auto auto1 = new Auto()
        {
            automaat = false,
            merk = "Volkswagen",
            kenteken = "AB-123-CD",
            kilometerStand = 150000
        };
        Auto auto2 = new Auto()
        {
            automaat = true,
            merk = "Toyota",
            kenteken = "EF-456-GH",
            kilometerStand = 80000
        };
        Rijleraar leraar1 = new RijLeraar()
        {
            naam = "Jan Jansen",
            leeftijd = 45,
            zzp = false
        };
        LesUur lesUur1 = new LesUur()
        {
            tijd = 10,
            rijLeraar = leraar1,
            auto = auto1
        };
        student student1 = new Student()
        {
            naam = "Piet Pietersen",
            leeftijd = 18,
            leraar = leraar1,
            lespakket = new LesPakket()
            {
                urenGekocht = 20,
                urenverbruikt = 5,
                examenpogingen = 0,
                automaat = false
            },
            leraar = new RijLeraar()
            {
                naam = "Jan Jansen",
                leeftijd = 45,
                zzp = false
            },
            theorieTests = new therieTest()
            {
                aantalfouten = 3,
                gehaald = true,
                afnameDatum = new DateTime(2023, 5, 1)
            },
            rijTests = new RijTest()
            {
                geslaagd = false,
                afnameDatum = new DateTime(2023, 6, 1)
            }
        };
    }
}
