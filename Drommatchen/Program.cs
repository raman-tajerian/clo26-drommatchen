using System;

namespace Drommatchen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Skapar matchen
            Match drommatchen = new Match("FC Barcelona", "Real Madrid", "2009-05-02");

            // Skapar två spelare med namn, nummer, antal mål och position
            Spelare messi = new Spelare("Lionel Messi", 10, "Forward", 2);
            Spelare raul = new Spelare("Raul Gonzalez", 7, "Forward", 0);

            // Presentererar match
            drommatchen.Presentera();

            // Målskyttar
            drommatchen.AnnounceraMålskytt(messi);
            drommatchen.AnnounceraMålskytt(raul);

            Console.WriteLine();

            //Matchhjälte eller inte
            Console.WriteLine($"ÄrMatchhjälte - {messi.Namn}: {drommatchen.ÄrMatchhjälte(messi)}");
            Console.WriteLine($"ÄrMatchhjälte - {raul.Namn}: {drommatchen.ÄrMatchhjälte(raul)}");

        }

    }
}










