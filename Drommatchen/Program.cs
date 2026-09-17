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


        }

    }
}

















// TODO: Skapa minst 2 spelare
// Spelare spelare1 = new Spelare("Namn", nummer, "Position");
// Spelare spelare2 = new Spelare(...);

// TODO: Skapa 1 match
// Match match = new Match("Hemmalag", "Bortalag", "Datum");

// TODO: Anropa match.Presentera()

// TODO: Anropa match.AnnounceraMålskytt() med båda spelarna
